using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Linq;

namespace Markuse_mälupulk
{
    public partial class BackupManager : Form
    {
        internal string dest_drive = null;
        internal string broot = @"D:\Varukoopiad\";
        bool finished = false;
        bool cancel = false;
        short waitType = 9;
        internal Form parent;
        private List<Backup> bclasses = new List<Backup>();
        public BackupManager()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Mälupulk: " + dest_drive + "\r\nVarukoopiate asukoht: " + broot;
            if (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                button3.Visible = true;
            }
            button1.PerformClick();
            newBackup.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "explorer.exe";
            p.StartInfo.Arguments = bclasses[backups.SelectedIndex].Locate();
            p.Start();
        }

        private void backups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backups.SelectedIndices.Count > 0)
            {
                otherLocation.Visible = true;
                renameButton.Visible = true;
                openFolder.Visible = true;
                fileObj.Visible = true;
                restoreNow.Visible = true;
                deleteButton.Visible = true;
            }
            else
            {
                otherLocation.Visible = false;
                renameButton.Visible = false;
                openFolder.Visible = false;
                fileObj.Visible = false;
                restoreNow.Visible = false;
                deleteButton.Visible = false;
            }
        }

        private void otherLocation_Click(object sender, EventArgs e)
        {
            waitType = 0;
            otherLocation.Enabled = false;
            waitForLoad.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancel = true;
            foreach (Backup b in bclasses) b.Clean();
            this.Dispose();
            bclasses = null;
            parent.Show();
        }

        private void fileObj_Click(object sender, EventArgs e)
        {
            waitType = 1;
            fileObj.Enabled = false;
            waitForLoad.Enabled = true;
        }

        private void waitForLoad_Tick(object sender, EventArgs e)
        {
            waitForLoad.Enabled = false;
            Dependencies d = new Dependencies();
            switch (waitType)
            {
                case 0:
                    d.depends = bclasses[backups.SelectedIndex].GetMissing();
                    d.backupname = bclasses[backups.SelectedIndex];
                    d.Text += " (kokku " + (d.depends.Length - 1) + " sõltuvust)";
                    d.Show();
                    otherLocation.Enabled = true;
                    break;
                case 1:
                    break;
                case 2:
                    bclasses.Clear();
                    backups.Items.Clear();
                    Thread t = new Thread(new ThreadStart(PopulateBackups));
                    t.Start();
                    waitforpopulate.Enabled = true;
                    break;
                case 3:
                    if (!Program.simulation)
                    {
                        bclasses[backups.SelectedIndex].Delete();
                    }
                    else
                    {
                        MessageBox.Show(bclasses[backups.SelectedIndex].Locate());
                    }
                    button1.PerformClick();
                    deleteButton.Enabled = true;
                    break;
            }
        }

        void PopulateBackups()
        {
            foreach (string s in Directory.GetDirectories(broot))
            {
                if (File.Exists(s + "\\.MISSING") && !cancel)
                {
                    bclasses.Add(new Backup(s, broot));
                } else if (cancel)
                {
                    bclasses = null;
                    break;
                }
            }
            finished = true;
            Thread.CurrentThread.Abort();
        }


        private void newBackup_Click(object sender, EventArgs e)
        {
            Backupname bn = new Backupname();
            if (bn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Enabled = false;
                StartBackup sb = new StartBackup();
                DateTime today = DateTime.Today;
                string sbd = broot + "\\" + bn.backuplabel.Text + " (" + today.Year + "-" + today.Month + "-" + today.Day + ")\\";
                if (MessageBox.Show("Varukoopia allikas: " + dest_drive + "\r\nVarukoopia sihtkaust: " + sbd + "\r\nKas olete kindel, et soovite jätkata?", "Alustatakse varundamisega", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    sb.dest = sbd;
                    sb.drive = dest_drive;
                    sb.bclasses = bclasses;
                    sb.parent = this;
                    this.WindowState = FormWindowState.Minimized;
                    sb.Show();
                }
                else
                {
                    this.Enabled = true;
                }
            }
        }

        private void restoreNow_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            StartRestore sr = new StartRestore();
            sr.parent = this;
            sr.dest = dest_drive;
            sr.bclasses = bclasses.ToArray();
            sr.bdir = bclasses[backups.SelectedIndex].Locate() + "\\";
            sr.currentbackup = bclasses[backups.SelectedIndex];
            sr.broot = broot;
            if (MessageBox.Show("See toiming kustutab olemasolevad failid mälupulgalt.\r\nKas olete kindel, et soovite jätkata?", "Kinnitus taastamiseks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Program.simulation)
                {
                    this.WindowState = FormWindowState.Minimized;
                    sr.Show();
                }
                else
                {
                    if (MessageBox.Show("See on viimane hoiatus. Simulatsioonirežiim on välja lülitatud.\r\nKas olete kindel, et soovite kindlasti jätkata?", "Kinnitus taastamiseks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.WindowState = FormWindowState.Minimized;
                        sr.Show();
                    }
                }
            }
            else
            {
                this.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("See toiming kustutab varukoopia jäädavalt.\r\nKas olete kindel, et soovite jätkata?", "Varukoopia kustutamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                deleteButton.Enabled = false;
                waitType = 3;
                waitForLoad.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            openFolder.Visible = false;
            otherLocation.Visible = false;
            fileObj.Visible = false;
            renameButton.Visible = false;
            restoreNow.Visible = false;
            deleteButton.Visible = false;
            newBackup.Enabled = false;
            waitType = 2;
            label1.Visible = false;
            label2.Text = "Varukoopiate avastamine...";
            progressBar1.Visible = true;
            waitForLoad.Enabled = true;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            Backupname bn = new Backupname();
            bn.backuplabel.Text = bclasses[backups.SelectedIndex].GetMedia();
            if (bn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bclasses[backups.SelectedIndex].Rename(bn.backuplabel.Text);
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectDrive sd = new SelectDrive();
            foreach (DriveInfo drv in DriveInfo.GetDrives()) {
                if (drv.IsReady)
                {
                    string[] items = new string[4];
                    string s = drv.RootDirectory.Name.ToString().Replace("\\", "");
                    items[0] = s;
                    items[1] = Math.Round(Convert.ToDouble(drv.TotalSize / 1000 / 1000 / 1000), 2).ToString() + " GB";
                    if (drv.VolumeLabel.ToString() != "")
                    {
                        items[2] = drv.VolumeLabel.ToString();
                    }
                    else
                    {
                        if (!File.Exists(drv.RootDirectory + "autorun.inf"))
                        {
                            items[2] = "Sildita irdseade";
                        }
                        else
                        {
                            string[] autoruninf = File.ReadAllText(drv.RootDirectory + "autorun.inf", Encoding.GetEncoding("windows-1252")).Replace("\r\n", "\n").Split('\n');
                            foreach (string str in autoruninf)
                            {
                                if (str.ToLower().Contains("label="))
                                {
                                    string label = str.Split('=')[1];
                                    items[2] = label;
                                }
                            }
                        }
                    }
                    ListViewItem li = new ListViewItem(items);
                    sd.listView1.Items.Add(li);
                }
            }
            sd.parent = this;
            if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.dest_drive = sd.listView1.SelectedItems[0].SubItems[0].Text + "\\";
                label1.Text = "Mälupulk: " + this.dest_drive + "\r\nVarukoopiate asukoht: " + this.broot;
            }
        }

        private void waitforpopulate_Tick(object sender, EventArgs e)
        {
            if (finished)
            {
                finished = false;
                label2.Text = "Varundamine ja taaste";
                waitforpopulate.Enabled = false;
                label1.Visible = true;
                foreach (Backup b in bclasses)
                {
                    b.Populate(backups);
                }
                newBackup.Enabled = true;
                label1.Text = "Mälupulk: " + dest_drive + "\r\nVarukoopiate asukoht: " + broot;
                if (backups.Items.Count == 0)
                {
                    if (MessageBox.Show("Tundub, et ühtegi varukoopiat pole loodud. Seetõttu tuleb\r\n" +
                                        "luua nn baasvarukoopia. Selle põhjal luuakse järgmised\r\n" +
                                        "varukoopiad. Esimese varukoopia loomine võib võtta kaua\r\n" +
                                        "aega. Palun olge kannatlikud ja oodake kuni varukoopia\r\n" +
                                        "loomine viiakse lõpule.\r\n\r\n" +
                                        "Kas olete valmis kohe baasvarukoopia looma?", "Varukoopiaid ei leitud", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        newBackup.PerformClick();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    backups.SelectedIndex = 0;
                }
                button1.Enabled = true;
                button2.Enabled = true;
                if (!this.Enabled) { this.Enabled = true; }
                progressBar1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



    public class Backup
    {
        // declarations
        string[] hrs = { "jaanuar", "veebruar", "märts", "aprill", "mai", "juuni", "juuli", "august", "september",
                                "oktoober", "november", "detsember"};
        public DateTime creation;
        public string[] MissingFiles;
        private List<string> SourceTree = new List<string>();
        private List<string> Folders = new List<string>();
        private string medianame = "";

        // root, static across all objects
        static string root;

        // class constructor
        public Backup(string fullname, string broot)
        {
            fullname = fullname.Replace(broot, "");
            this.medianame = fullname.Split('(')[0].Substring(1, fullname.Split('(')[0].Length - 2);
            string date_elements = fullname.Split('(')[1].Replace(")", "");
            string[] datums = date_elements.Split('-');
            int[] idats = { Convert.ToInt32(datums[0]), Convert.ToInt32(datums[1]), Convert.ToInt32(datums[2]) };
            creation = new DateTime(idats[0], idats[1], idats[2]);
            root = broot;
            if (File.Exists(this.Locate() + "\\.MISSING"))
            {
                this.MissingFiles = File.ReadAllText(this.Locate() + "\\.MISSING").Split('\n');
            }
            if (this.MissingFiles != null)
            {
                for (int i = 0; i < this.MissingFiles.Length; i++)
                {
                    if (this.MissingFiles[i] == "")
                    {
                        this.MissingFiles[i] = null;
                    }
                    else
                    {
                        this.MissingFiles[i] = this.MissingFiles[i].Replace("/", "\\");
                    }
                }
            }
            this.CreateSourceTree(new System.IO.DirectoryInfo(this.Locate()));

            for (int i = 0; i < this.SourceTree.Count; i++)
            {
                this.SourceTree[i] = this.SourceTree[i].Replace(this.Locate(), "");
            }
        }

        public override string ToString()
        {
            string str = this.creation.Year.ToString();
            string hr = this.hrs[this.creation.Month - 1];
            return this.creation.Day.ToString() + ". " + hr + " " + str;
        }

        public string[] GetMissing() => this.MissingFiles;

        public string[] GetSourceArray() => this.SourceTree.ToArray<string>();

        public string[] GetFolderArray() => this.Folders.ToArray<string>();

        private void CreateSourceTree(DirectoryInfo root)
        {
            foreach (FileInfo file in root.GetFiles("*.*"))
            {
                if (file.Name != ".MISSING")
                    this.SourceTree.Add(file.FullName);
            }
            foreach (DirectoryInfo directory in root.GetDirectories())
            {
                this.Folders.Add(directory.FullName.Replace(this.Locate(), ""));
                this.CreateSourceTree(directory);
            }
        }

        public void Clean()
        {
            this.SourceTree = null;
            this.Folders = null;
            this.MissingFiles = null;
        }

        public string Locate() => Backup.root + "\\" + this.medianame + " (" + (object)this.creation.Year + "-" + (object)this.creation.Month + "-" + (object)this.creation.Day + ")";

        public string Find(Backup[] bclasses, string filename)
        {
            try
            {
                string str1 = filename.Replace("/", "\\");
                string str2 = "";
                bool flag = false;
                for (int index = bclasses.Length - 1; index >= 0; --index)
                {
                    Backup bclass = bclasses[index];
                    if (bclass.creation < this.creation && ((IEnumerable<string>)bclass.GetSourceArray()).Contains<string>(str1))
                    {
                        str2 = bclass.Locate() + str1;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    for (int index = bclasses.Length - 1; index >= 0; --index)
                    {
                        Backup bclass = bclasses[index];
                        if (bclass.creation > this.creation && ((IEnumerable<string>)bclass.GetSourceArray()).Contains<string>(str1))
                        {
                            str2 = bclass.Locate() + str1;
                            break;
                        }
                    }
                }
                return str2;
            }
            catch
            {
                return "";
            }
        }

        public void Populate(ListBox li) => li.Items.Add((object)(this.medianame + " - " + this.ToString()));

        public void Delete() => Directory.Delete(this.Locate(), true);

        public string GetMedia() => this.medianame;

        public void Rename(string newlabel)
        {
            string sourceDirName = this.Locate().ToString();
            this.medianame = newlabel;
            Directory.Move(sourceDirName, this.Locate());
        }
    }
}
