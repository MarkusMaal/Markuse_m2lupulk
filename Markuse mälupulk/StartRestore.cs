using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;

namespace Markuse_mälupulk
{
    public partial class StartRestore : Form
    {

        internal string bdir = "null";
        internal string dest = "null";
        internal string broot = "null";
        internal Form parent = null;
        bool allowclose = false;
        internal Backup[] bclasses = null;
        internal Backup currentbackup = null;
        string[] backupfiles;
        string[] backupfolders;
        List<string> lostfound = new List<string>();
        int current_id = 0;
        short action = 0;
        public StartRestore()
        {
            InitializeComponent();
        }



        public delegate void IntDelegate(int Int);
        public static System.Windows.Forms.Timer t = null;
        public static void CopyFileWithProgress(string source, string destination)
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(source), destination);
            });
            thread.Start();
        }

        private static void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            Program.labeltext = "Kopeeritud " + Convert.ToInt32((double)e.BytesReceived / (double)1024 / (double)1024).ToString() + "kB/" + Convert.ToInt32((double)e.TotalBytesToReceive / (double)1024).ToString() + " kB";
            Program.pbar = double.Parse(e.TotalBytesToReceive.ToString());
        }

        private static void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Program.done = true;
        }
        private void StartRestore_Load(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            label2.Text = "Varukoopia asukoht: " + bdir;
            label3.Text = "Taaste sihtkaust: " + dest;
            driveReadCounter.InstanceName = bdir.Substring(0, 2);
            driveWriteCounter.InstanceName = bdir.Substring(0, 2);
            flashReadCounter.InstanceName = dest.Substring(0, 2);
            flashWriteCounter.InstanceName = dest.Substring(0, 2);
            statFinder.Enabled = true;
            if (Program.simulation)
            {
                label5.Visible = true;
            }
            waitasec.Enabled = true;
            ThreadStart ts = new ThreadStart(CheckStats);
            Thread th = new Thread(ts);
            th.Start();
        }

        public static void DeleteFiles()
        {
            Program.done = false;
            if (!Program.simulation)
            {
                try
                {
                    Directory.Delete(Program.dest, true);
                }
                catch (UnauthorizedAccessException)
                {

                }
                catch (FileNotFoundException)
                {

                }
                catch
                {

                }
            }
            else
            {
                Thread.Sleep(5000);
            }
            Program.done = true;
            Thread.CurrentThread.Abort();
        }

        private void waitasec_Tick(object sender, EventArgs e)
        {
            waitasec.Enabled = false;
            switch (action)
            {
                case 0:
                    Program.dest = dest;
                    ThreadStart child = new ThreadStart(DeleteFiles);
                    Thread eraser = new Thread(child);
                    checkDelete.Enabled = true;
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Maximum = 100;
                    eraser.Start();
                    break;
                case 1:
                    Program.done = false;
                    checkBox1.CheckState = CheckState.Checked;
                    checkBox2.CheckState = CheckState.Indeterminate;
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Value = 0;
                    this.backupfolders = currentbackup.GetFolderArray();
                    progressBar1.Maximum = backupfolders.Length;
                    Program.folders = backupfolders;
                    this.backupfiles = this.currentbackup.GetSourceArray();
                    label4.Text = "0%";
                    Program.dest = dest;
                    ThreadStart ths = new ThreadStart(CreateFolders);
                    Thread th = new Thread(ths);
                    th.Start();
                    createFolders.Enabled = true;
                    break;
                case 2:
                    checkBox2.CheckState = CheckState.Checked;
                    checkBox3.CheckState = CheckState.Indeterminate;
                    progressBar1.Maximum = backupfiles.Length;
                    progressBar1.Value = 0;
                    current_id = 0;
                    copyFiles.Enabled = true;
                    t = copyFiles;
                    checkT.Enabled = true;
                    label4.Text = "0%";
                    break;
                case 3:
                    checkT.Enabled = false;
                    checkBox3.CheckState = CheckState.Checked;
                    checkBox4.CheckState = CheckState.Indeterminate;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = currentbackup.GetMissing().Length;
                    current_id = 0;
                    fileSearcher.Enabled = true;
                    break;
                case 4:
                    checkBox4.CheckState = CheckState.Checked;
                    checkBox5.CheckState = CheckState.Indeterminate;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = lostfound.Count;
                    current_id = 0;
                    copyMissing.Enabled = true;
                    t = copyMissing;
                    checkT.Enabled = true;
                    break;
                case 5:
                    checkT.Enabled = false;
                    allowclose = true;
                    checkBox5.CheckState = CheckState.Checked;
                    progressBar1.Value = progressBar1.Maximum;
                    label4.Text = "Valmis";
                    break;
            }
        }

        private void checkDelete_Tick(object sender, EventArgs e)
        {
            if (Program.done)
            {
                action++;
                Program.done = false;
                Program.dest = "";
                waitasec.Enabled = true;
                checkDelete.Enabled = false;
            }
            else
            {
                foreach (DriveInfo di in DriveInfo.GetDrives())
                {
                    if (di.IsReady)
                    {
                        if (di.DriveType == DriveType.Removable)
                        {
                            if (di.RootDirectory.ToString() == dest)
                            {
                                progressBar1.Value = Convert.ToInt32(((double)di.TotalFreeSpace / (double)di.TotalSize) * (double)100);
                                if (progressBar1.Value == progressBar1.Maximum)
                                {
                                    progressBar1.Style = ProgressBarStyle.Marquee;
                                    label4.Text = "Kaustade kustutamine...";
                                }
                                else
                                {
                                    label4.Text = progressBar1.Value.ToString() + "%";
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CreateFolders()
        {
            int current_id = 0;
            while (current_id < Program.folders.Length)
            {
                Program.pbar = current_id;
                if (!Program.simulation)
                {
                    Directory.CreateDirectory(Program.dest.Substring(0, Program.dest.Length - 1) + Program.folders[current_id]);
                }
                current_id++;
            }
            Program.done = true;
            Thread.CurrentThread.Abort();
        }

        private void createFolders_Tick(object sender, EventArgs e)
        {
            if (Program.done)
            {
                createFolders.Enabled = false;
                action++;
                waitasec.Enabled = true;
            }
            else
            {
                progressBar1.Value = Convert.ToInt32(Program.pbar);
                label4.Text = Convert.ToInt32((Convert.ToDouble(progressBar1.Value) /
                                               Convert.ToDouble(progressBar1.Maximum))
                                               * 100.0).ToString() + "%";
            }
        }

        private void copyFiles_Tick(object sender, EventArgs e)
        {
            if (current_id < backupfiles.Length)
            {

                Program.done = false;
                Program.currentfile = backupfiles[current_id];
                if (!Program.simulation)
                {
                    CopyFileWithProgress(currentbackup.Locate() + backupfiles[current_id], dest.Substring(0, dest.Length - 1) + backupfiles[current_id]);
                }
                progressBar1.Value = current_id;
                string[] si = backupfiles[current_id].Split('\\');
                label4.Text = "Fail: " + si[si.Length - 1] + " ( " +
                              Convert.ToInt32((Convert.ToDouble(progressBar1.Value) /
                                               Convert.ToDouble(progressBar1.Maximum))
                                               * 100.0).ToString() + "%)";
                current_id++;
                if (!Program.simulation)
                {
                    copyFiles.Enabled = false;
                }
            }
            else
            {
                copyFiles.Enabled = false;
                checkT.Enabled = false;
                action++;
                waitasec.Enabled = true;
            }
        }

        private void fileSearcher_Tick(object sender, EventArgs e)
        {
            string[] missingarray = currentbackup.GetMissing();
            if (current_id < missingarray.Length)
            {
                try
                {
                    string str = this.currentbackup.Find(this.bclasses, missingarray[this.current_id]);
                    string[] si = missingarray[current_id].Split('\\');
                    bool flag = str != "";
                    progressBar1.Value = current_id;
                    if (!flag)
                    {
                        this.fileSearcher.Enabled = false;
                        //int num = (int)MessageBox.Show("Faili \"" + si[si.Length - 1] + "\" ei leitud");
                        this.fileSearcher.Enabled = true;
                    }
                    else
                        this.lostfound.Add(str);
                    if (flag)
                    {
                        label4.Text = "Leitud fail: " + si[si.Length - 1] + " (" +
                                      Convert.ToInt32((Convert.ToDouble(progressBar1.Value) /
                                                       Convert.ToDouble(progressBar1.Maximum))
                                                       * 100.0).ToString() + "%)";
                    } else
                    {
                        label4.Text = "Ei leitud faili: " + si[si.Length - 1] + " (" +
                                      Convert.ToInt32((Convert.ToDouble(progressBar1.Value) /
                                                       Convert.ToDouble(progressBar1.Maximum))
                                                       * 100.0).ToString() + "%)";
                    }
                    current_id++;
                }
                catch
                {
                    fileSearcher.Enabled = false;
                    action++;
                    waitasec.Enabled = true;
                    return;
                }
            }
            else
            {
                fileSearcher.Enabled = false;
                action++;
                waitasec.Enabled = true;
            }
        }

        private void copyMissing_Tick(object sender, EventArgs e)
        {
            if (current_id < lostfound.Count)
            {
                Program.currentfile = lostfound[current_id];
                Program.done = false;
                string[] si = lostfound[current_id].Split('\\');
                string backupfolder = lostfound[current_id].Replace(broot, "").Split('\\')[1];
                string destinationpath = lostfound[current_id].Replace(broot + "\\" + backupfolder + "\\", dest);
                label4.Text = "Kopeeriti fail: " + si[si.Length - 1] + " (" + Math.Round(((double)new FileInfo(Program.currentfile).Length / 1024.0 / 1024.0), 2).ToString() + " MB, " +
                              Convert.ToInt32((Convert.ToDouble(progressBar1.Value) /
                                               Convert.ToDouble(progressBar1.Maximum))
                                               * 100.0).ToString() + "%)";
                if (!Program.simulation)
                {
                    CopyFileWithProgress(lostfound[current_id], destinationpath);
                }
                progressBar1.Value = current_id;
                current_id++;
                if (!Program.simulation)
                {
                    copyMissing.Enabled = false;
                }
            }
            else
            {
                checkT.Enabled = false;
                copyMissing.Enabled = false;
                action++;
                waitasec.Enabled = true;
            }
        }

        private void checkT_Tick(object sender, EventArgs e)
        {
            if (Program.done)
            {
                t.Enabled = true;
            }
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
                }
                catch
                {
                }

                driveReadCounter.NextValue();
                Thread.Sleep(1000);
                flist.Add((int)Math.Ceiling(driveReadCounter.NextValue()));

                driveWriteCounter.NextValue();
                Thread.Sleep(1000);
                flist.Add((int)Math.Ceiling(driveWriteCounter.NextValue()));

            }
        }

        private void statFinder_Tick(object sender, EventArgs e)
        {
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.IsReady)
                {
                    if (di.RootDirectory.ToString() == dest)
                    {
                        spaceUsage.Maximum = 10000;
                        spaceUsage.Value = spaceUsage.Maximum - Convert.ToInt32(((double)di.TotalFreeSpace / (double)di.TotalSize) * 10000.0);
                        label6.Text = "Mälupulga ruumikasutus: " + Math.Round(100 - (((double)di.TotalFreeSpace / (double)di.TotalSize) * 100.0), 2) + "%";
                    }
                }
            }
            if (dest.Substring(0, 2) != "nu")
            {
                this.flashBufferCounter.InstanceName = this.dest.Substring(0, 2);
                try
                {
                    if ((double)this.flashBufferCounter.NextValue() > 0.0)
                        this.flashBuffer.BackColor = Color.Yellow;
                    else
                        this.flashBuffer.BackColor = Color.Olive;
                }
                catch
                {
                    this.flashBuffer.BackColor = Color.Yellow;
                }
                flashBufferCounter.InstanceName = dest.Substring(0, 2);
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

        private void StartRestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowclose)
            {
                parent.Enabled = true;
                parent.WindowState = FormWindowState.Normal;
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                if (MessageBox.Show("Taastet ei saa katkestada.\r\n" +
                                    "Kas soovite toimingut jätkata taustal?", "Taaste katkestamine", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                {
                    trayIcon.Visible = true;
                    trayIcon.BalloonTipTitle = "Taaste toimub taustal";
                    trayIcon.BalloonTipText = "Mälupulga sünkroonimistarkvara töötab taustal. Kui protsess lõpeb, saadetakse teile teavitus. Kui soovite näha kuidas protsess kulgeb, topeltklõpsake tegumiriba ikoonil.";
                    trayIcon.ShowBalloonTip(15000);
                    this.Hide();
                }
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
            checkBox5.Enabled = false;
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
        }

    }
}
