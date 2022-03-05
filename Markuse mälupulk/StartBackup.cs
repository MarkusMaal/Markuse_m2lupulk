using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows.Forms.Layout;

namespace Markuse_mälupulk
{
    public partial class StartBackup : Form
    {
        internal string drive = "null";
        internal string dest = "null";
        internal List<Backup> bclasses = new List<Backup>();
        internal Form parent;
        string[] syncfolders;
        string[] syncfiles;
        int current_id = 0;
        long walks = 0;
        bool allowclose = false;
        long max = 0;
        List<string> SrcFolders = new List<string>();
        List<string> SrcFiles = new List<string>();
        List<string> wildlymissing = new List<string>();

        short action = 0;

        public StartBackup()
        {
            InitializeComponent();
        }



        private void StartBackup_Load(object sender, EventArgs e)
        {
            foreach (Control control in (ArrangedElementCollection)this.flowLayoutPanel1.Controls)
            {
                control.BackColor = this.BackColor;
                control.ForeColor = this.ForeColor;
            }
            trayIcon.Visible = false;
            label2.Text = "Asukoht: " + drive;
            label3.Text = "Sihtkaust: " + dest;
            waitasecond.Enabled = true;
            driveReadCounter.InstanceName = dest.Substring(0, 2);
            driveWriteCounter.InstanceName = dest.Substring(0, 2);
            flashReadCounter.InstanceName = drive.Substring(0, 2);
            flashWriteCounter.InstanceName = drive.Substring(0, 2);
            statFinder.Enabled = true;
            if (Program.simulation)
            {
                label5.Visible = true;
            }
            ThreadStart ts = new ThreadStart(CheckStats);
            Thread th = new Thread(ts);
            th.Start();
        }

        private void CheckStats()
        {
            while (true)
            {
                List<int> flist = new List<int>();
                try
                {
                    flashReadCounter.NextValue();
                    Thread.Sleep(1000);
                    flist.Add((int)Math.Ceiling(flashReadCounter.NextValue()));

                    flashWriteCounter.NextValue();
                    Thread.Sleep(1000);
                    flist.Add((int)Math.Ceiling(flashWriteCounter.NextValue()));

                    driveReadCounter.NextValue();
                    Thread.Sleep(1000);
                    flist.Add((int)Math.Ceiling(driveReadCounter.NextValue()));

                    driveWriteCounter.NextValue();
                    Thread.Sleep(1000);
                    flist.Add((int)Math.Ceiling(driveWriteCounter.NextValue()));

                }
                catch
                {
                    Console.WriteLine("Statistika kogumine nurjus. Kas mälupulk on ühendatud?");
                    Thread.Sleep(15000);
                }
            }
        }

        private void CreateSourceTree(DirectoryInfo root)
        {
            string temp;
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo fi in root.GetFiles("*.*"))
            {
                temp = fi.FullName;
                files.Add(fi);
            }
            foreach (FileInfo fi in files)
            {
                SrcFiles.Add(fi.FullName.Replace(drive, ""));
            }
            var subDirs = root.GetDirectories();

            foreach (DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                SrcFolders.Add(dirInfo.FullName.Replace(drive, ""));
                CreateSourceTree(dirInfo);
            }
        }

        private void waitasecond_Tick(object sender, EventArgs e)
        {
            waitasecond.Enabled = false;
            switch (action)
            {
                case 0:
                    CreateSourceTree(new DirectoryInfo(drive));
                    this.syncfolders = this.SrcFolders.ToArray();
                    this.syncfiles = this.SrcFiles.ToArray();
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Value = 0;
                    Directory.CreateDirectory(dest);
                    Program.folders = syncfolders;
                    Program.dest = dest;
                    Program.done = false;
                    Program.pbar = 0;
                    ThreadStart bts = new ThreadStart(CreateFoldersForBackup);
                    progressBar1.Maximum = syncfolders.Length;
                    Thread bt = new Thread(bts);
                    bt.Start();
                    folderCreator.Enabled = true;
                    checkBox1.CheckState = CheckState.Checked;
                    checkBox2.CheckState = CheckState.Indeterminate;
                    break;
                case 1:
                    checkBox2.CheckState = CheckState.Checked;
                    checkBox3.CheckState = CheckState.Indeterminate;
                    progressBar1.Value = 0;
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    Program.done = false;
                    ThreadStart bts2 = new ThreadStart(CountEach);
                    Thread bt2 = new Thread(bts2);
                    bt2.Start();
                    eachCount.Enabled = true;
                    current_id = bclasses.Count - 1;
                    label4.Text = "Analüüsin teisi varukoopiaid...";
                    break;
                case 2:
                    checkBox3.CheckState = CheckState.Checked;
                    checkBox4.CheckState = CheckState.Indeterminate;
                    progressBar1.Value = 0;
                    Program.pbar = 0;
                    Program.labeltext = "";
                    Program.done = false;
                    Program.folders = syncfiles;
                    progressBar1.Maximum = syncfiles.Length;
                    current_id = 0;
                    listBox1.Items.Clear();
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    label4.Text = "Kopeerin faile...";
                    ThreadStart bts3 = new ThreadStart(CopyFilesForBackup);
                    Thread bt3 = new Thread(bts3);
                    bt3.Start();
                    copyFiles.Enabled = true;
                    break;
                default:
                    checkBox4.CheckState = CheckState.Checked;
                    label4.Text = "Valmis!";
                    allowclose = true;
                    if (trayIcon.Visible)
                    {
                        trayIcon.BalloonTipTitle = "Varundamine viidi lõpule";
                        trayIcon.BalloonTipText = "Klõpsake teavitust või topeltklõpsake ikooni, et programm nähtavale tuua.";
                        trayIcon.ShowBalloonTip(30000);
                    }
                    break;
            }
        }

        public void CopyFilesForBackup()
        {
            Program.done = false;
            int current_id = 0;
            while (current_id < syncfiles.Length)
            {
                if (!Program.done)
                {
                    while (wildlymissing.Contains("/" + syncfiles[current_id].Replace("\\", "/")))
                    {
                        current_id++;
                        if (current_id == syncfiles.Length - 1)
                        {
                            Program.pbar = syncfiles.Length - 1;
                            Program.done = true;
                            break;
                        }
                    }
                    try
                    {
                        if (!Program.simulation)
                        {
                            File.Copy(drive + syncfiles[current_id], dest + syncfiles[current_id], true);
                        }
                        else
                        {
                            Thread.Sleep(20);
                        }
                    }
                    catch
                    {

                    }
                    if (current_id < syncfiles.Length - 1)
                    {
                        string[] tempt = syncfiles[current_id + 1].Split('\\');
                        Program.labeltext = "Fail: " + tempt[tempt.Length - 1] + " (" + Convert.ToInt32((Convert.ToDouble(current_id) / Convert.ToDouble(syncfiles.Length)) * 100.0).ToString() + "%)";
                    }
                    Program.pbar = current_id;
                    current_id++;
                }
            }
            Program.done = true;
            Thread.CurrentThread.Abort();
        }

        private void copyFiles_Tick(object sender, System.EventArgs e)
        {
            if (Program.done)
            {
                progressBar1.Value = progressBar1.Maximum;
                copyFiles.Enabled = false;
                action++;
                waitasecond.Enabled = true;
            }
            else
            {
                progressBar1.Value = Convert.ToInt32(Program.pbar);
                label4.Text = Program.labeltext;
            }
        }

        private static void CreateFoldersForBackup()
        {
            Program.done = false;
            int current_id = 0;
            while (current_id < Program.folders.Length)
            {
                Program.pbar = current_id;
                if (!Program.simulation)
                {
                    Directory.CreateDirectory(Program.dest + Program.folders[current_id]);
                }
                else
                {
                    //Thread.Sleep(5);
                }
                current_id++;
            }
            Program.done = true;
            Thread.CurrentThread.Abort();
        }

        private void folderCreator_Tick(object sender, EventArgs e)
        {
            if (Program.done)
            {
                action++;
                waitasecond.Enabled = true;
                folderCreator.Enabled = false;
            }
            else
            {
                progressBar1.Value = Convert.ToInt32(Program.pbar);
                label4.Text = Convert.ToInt32(((double)(progressBar1.Value) / (double)progressBar1.Maximum) * 100.0).ToString() + "%";
            }
        }

        public bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read);

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }

        public void CountEach()
        {
            Program.done = false;
            walks = 0;
            max = 0;
            int backup = current_id + 1 - 1;
            for (; this.current_id != 0; --this.current_id)
            {
                foreach (string source in this.bclasses[this.current_id].GetSourceArray())
                {
                    max ++;
                }
            }
            current_id = backup + 1 - 1;
            for (; this.current_id != 0; --this.current_id)
            {
                foreach (string source in this.bclasses[this.current_id].GetSourceArray())
                {
                    foreach (string syncfile in this.syncfiles)
                    {
                        if (source == "\\" + syncfile &&
                            new FileInfo(this.drive + syncfile).Length == new FileInfo(this.bclasses[this.current_id].Locate() + source).Length &&
                            !this.wildlymissing.Contains(source.Replace("\\", "/")))
                        {
                            if (FileCompare(this.drive + "\\" + syncfile, this.bclasses[this.current_id].Locate() + source))
                            {
                                this.wildlymissing.Add(source.Replace("\\", "/"));
                            }
                        }
                    }
                    walks++;
                }
            }
            string content = "";
            foreach (string s in wildlymissing)
            {
                content += s + "\n";
            }
            if (!Program.simulation)
            {
                File.WriteAllText(dest + ".MISSING", content, Encoding.UTF8);
            }
            Program.done = true;
            Thread.CurrentThread.Abort();
        }

        private void eachCount_Tick(object sender, System.EventArgs e)
        {
            if (max >= walks)
            {
                progressBar1.Maximum = (int)(max);
                progressBar1.Value = (int)(walks);
            }
            if (Program.done)
            {
                eachCount.Enabled = false;
                Program.done = false;
                action++;
                waitasecond.Enabled = true;
            }
            else
            {
                label4.Text = "Leiti " + wildlymissing.Count.ToString() + " faili, tihendusprotsent " + Convert.ToInt32(
                    (Convert.ToDouble(wildlymissing.Count) / Convert.ToDouble(syncfiles.Length)) * 100
                    ).ToString() + "%";
            }
        }
        private void checkBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void checkBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void StartBackup_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (allowclose)
            {
                parent.Enabled = true;
                parent.WindowState = FormWindowState.Normal;
                e.Cancel = false;
            }
            else
            {
                this.ShowInTaskbar = true;
                e.Cancel = true;
                if (MessageBox.Show("Varukoopia loomist ei saa katkestada.\r\n" +
                                    "Kas soovite toimingut jätkata taustal?", "Varukoopia katkestamine", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                {
                    trayIcon.Visible = true;
                    trayIcon.BalloonTipTitle = "Varukoopiat luuakse taustal";
                    trayIcon.BalloonTipText = "Mälupulga sünkroonimistarkvara töötab taustal. Kui protsess lõpeb, saadetakse teile teavitus. Kui soovite näha kuidas protsess kulgeb, topeltklõpsake tegumiriba ikoonil.";
                    trayIcon.ShowBalloonTip(15000);
                    this.Hide();
                }
                else
                {

                }
            }
        }

        private void statFinder_Tick(object sender, EventArgs e)
        {

            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.IsReady)
                {
                    if (di.RootDirectory.ToString() == dest.Substring(0, 3))
                    {
                        spaceUsage.Maximum = 10000;
                        spaceUsage.Value = spaceUsage.Maximum - Convert.ToInt32(((double)di.TotalFreeSpace / (double)di.TotalSize) * 10000.0);
                        label6.Text = "Kõvaketta ruumikasutus: " + Math.Round(100 - (((double)di.TotalFreeSpace / (double)di.TotalSize) * 100.0), 2) + "%";
                    }
                }
            }
            if (this.drive.Substring(0, 2) != "nu")
            {
                if (!this.Visible)
                {
                    trayIcon.Visible = true;
                }
                this.flashBufferCounter.InstanceName = this.drive.Substring(0, 2);
                if ((double)this.flashBufferCounter.NextValue() > 0.0)
                    this.flashBuffer.BackColor = Color.Yellow;
                else
                    this.flashBuffer.BackColor = Color.Olive;
                flashBufferCounter.InstanceName = drive.Substring(0, 2);
                if ((double)this.flashBufferCounter.NextValue() > 0.0)
                    this.hardBuffer.BackColor = Color.Yellow;
                else
                    this.hardBuffer.BackColor = Color.Olive;
                if (this.flashReadCounter.NextValue() > 0.0)
                    this.flashRead.BackColor = Color.Lime;
                else
                    this.flashRead.BackColor = Color.DarkGreen;
                if (this.flashWriteCounter.NextValue() > 0.0)
                    this.flashWrite.BackColor = Color.Red;
                else
                    this.flashWrite.BackColor = Color.DarkRed;
                if (this.driveReadCounter.NextValue() > 0.0)
                    this.hardRead.BackColor = Color.Lime;
                else
                    this.hardRead.BackColor = Color.DarkGreen;
                if (this.driveWriteCounter.NextValue() > 0.0)
                    this.hardWrite.BackColor = Color.Red;
                else
                    this.hardWrite.BackColor = Color.DarkRed;
            }
        }

        private void trayIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            this.ShowInTaskbar = false;
            this.Show();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            this.ShowInTaskbar = false;
            this.Show();
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
        }

    }
}
