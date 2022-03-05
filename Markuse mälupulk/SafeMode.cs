using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Markuse_mälupulk
{
    public partial class SafeMode : Form
    {
        List<DriveInfo> drives = new List<DriveInfo>();
        DriveInfo currentDevice;
        int selectedIdx = 0;
        int selectedArticle = 1;
        string drive = "";
        public SafeMode()
        {
            InitializeComponent();
        }

        private void SafeMode_Load(object sender, EventArgs e)
        {
            try
            {
                bool test = Program.f1.Visible;
            }
            catch
            {
                MessageBox.Show("Te käivitasite mälupulgaprogrammi turvarežiimis. Kiirrakendused, Kaustad, Haldamine ja Arendamisvalikud on välja lülitatud.", "Turvarežiim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.IsReady && di.DriveType == DriveType.Removable)
                {
                    if (Directory.Exists(di.RootDirectory + "E_INFO"))
                    {
                        drives.Add(di);
                    }
                }
            }
            selectedIdx = 0;
            currentDevice = drives[selectedIdx];
            drive = currentDevice.RootDirectory.Name.Substring(0, 2);
            if (currentDevice.VolumeLabel.ToString() != "")
            {
                label1.Text = currentDevice.VolumeLabel.ToString();
            }
            else
            {
                if (!File.Exists(currentDevice.RootDirectory + "autorun.inf"))
                {
                    label1.Text = "Sildita irdseade";
                }
                else
                {
                    string[] autoruninf = File.ReadAllText(currentDevice.RootDirectory + "\\autorun.inf", Encoding.GetEncoding("windows-1252")).Replace("\r\n", "\n").Split('\n');
                    foreach (string str in autoruninf)
                    {
                        if (str.ToLower().Contains("label="))
                        {
                            string label = str.Split('=')[1];
                            label1.Text = label;
                        }
                    }
                }
            }
            button5.Visible = (drives.Count > 1);
            label1.Text += " (" + drive + ")";
            ReloadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            selectedIdx++;
            if (selectedIdx >= drives.Count)
            {
                selectedIdx = 0;
            }
            currentDevice = drives[selectedIdx];
            drive = currentDevice.RootDirectory.Name.Substring(0, 2);
            try
            {
                if (currentDevice.VolumeLabel.ToString() != "")
                {
                    label1.Text = currentDevice.VolumeLabel.ToString();
                }
                else
                {
                    if (!File.Exists(currentDevice.RootDirectory + "autorun.inf"))
                    {
                        label1.Text = "Sildita irdseade";
                    }
                    else
                    {
                        string[] autoruninf = File.ReadAllText(currentDevice.RootDirectory + "autorun.inf", Encoding.GetEncoding("windows-1252")).Replace("\r\n", "\n").Split('\n');
                        foreach (string str in autoruninf)
                        {
                            if (str.ToLower().Contains("label="))
                            {
                                string label = str.Split('=')[1];
                                label1.Text = label;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ei saa seadet muuta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Nimetu irdseade";
            }
            label1.Text += " (" + drive + ")";
            ReloadData();
        }

        void ReloadData()
        {
            ReloadArticle();
            listBox1.Items.Clear();
            if (Directory.Exists(drive + "\\Markuse_videod"))
            {
                foreach (FileInfo fi in new DirectoryInfo(drive + "\\Markuse_videod").GetFiles())
                {
                    string file = fi.Name;
                    listBox1.Items.Add(file.Split('.')[1].Substring(1) + "." + file.Split('.')[2]);
                }
                button6.Enabled = false;
                listBox1.Enabled = true;
            }
            else
            {
                listBox1.Items.Add("Pole saadaval");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                Program.f1.Show();
                this.Close();
            }
            catch
            {
                Process p = new Process();
                p.StartInfo.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
                p.Start();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedArticle += 1;
            if (selectedArticle > 5)
            {
                selectedArticle = 1;
            }
            ReloadArticle();
        }

        void ReloadArticle()
        {
            try
            {
                richTextBox1.LoadFile(drive + "\\E_INFO\\uudis" + selectedArticle.ToString() + ".rtf");
            }
            catch
            {
                richTextBox1.Text = "Viga artikli laadimisel";
            }
            ArticleLabel.Text = "Artikkel " + selectedArticle.ToString() + "/5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedArticle -= 1;
            if (selectedArticle < 1)
            {
                selectedArticle = 5;
            }
            ReloadArticle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReloadArticle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 0)
            {
                button6.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = drive + "\\Markuse_videod\\" + (listBox1.SelectedIndex + 1).ToString() + ". " + listBox1.SelectedItem.ToString();
                p.Start();
            }
            catch
            {

            }
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void SafeMode_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Program.f1.Show();
            }
            catch
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            button6.Enabled = false;
            drives.Clear();
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.IsReady && di.DriveType == DriveType.Removable && Directory.Exists(di.RootDirectory + "E_INFO"))
                {
                    drives.Add(di);
                }
            }
            selectedIdx = 0;
            currentDevice = drives[selectedIdx];
            drive = currentDevice.RootDirectory.Name.Substring(0, 2);
            label1.Text = "Nimetu irdseade";
            if (currentDevice.VolumeLabel.ToString() != "")
            {
                label1.Text = currentDevice.VolumeLabel.ToString();
            }
            button5.Visible = (drives.Count > 1);
            label1.Text += " (" + drive + ")";
            ReloadData();
        }
    }
}
