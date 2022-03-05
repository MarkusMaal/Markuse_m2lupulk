using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Management;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using Shell32;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Layout;
using Markuse_mälupulk.Properties;
using System.Linq;

namespace Markuse_mälupulk
{
    public partial class Form1 : Form
    {
        int incremental = 1;
        public string drive = "null";
        string current_dir = "";
        string current_file = "";
        int id = 0;
        string clipboard = "";
        bool copy = false;
        bool fqa = false;
        bool allvids = false;
        private Image loadedimage;
        ImageList aicon = new ImageList();
        List<Keys> keys = new List<Keys>();
        public RichTextBox rtb = new RichTextBox();
        TabSelect TabCollection = new TabSelect();
        List<double> stats = new List<double>();
        List<string> prg = new List<string>();
        string current_pin = "";
        List<int> huevectors = new List<int>() { 15, 15, 15 };

        private IDictionary<string, Image> shellIcons = (IDictionary<string, Image>)new Dictionary<string, Image>()
        {
          {
            "_UI_FOLDER",
            (Image) Resources.setting
          },
          {
            "dll",
            (Image) Resources.setting
          },
          {
            "sys",
            (Image) Resources.setting
          },
          {
            "cnf",
            (Image) Resources.setting
          },
          {
            "ini",
            (Image) Resources.setting
          },
          {
            "reg",
            (Image) Resources.setting
          },
          {
            "chm",
            (Image) Resources.help
          },
          {
            "nfo",
            (Image) Resources.help
          },
          {
            "hlp",
            (Image) Resources.help
          },
          {
            "com",
            (Image) Resources.apps
          },
          {
            "mp3",
            (Image) Resources.play
          },
          {
            "wav",
            (Image) Resources.play
          },
          {
            "ogg",
            (Image) Resources.play
          },
          {
            "wma",
            (Image) Resources.play
          },
          {
            "asf",
            (Image) Resources.play
          },
          {
            "wmv",
            (Image) Resources.play
          },
          {
            "mp4",
            (Image) Resources.play
          },
          {
            "mpg",
            (Image) Resources.play
          },
          {
            "aiff",
            (Image) Resources.play
          },
          {
            "flac",
            (Image) Resources.play
          },
          {
            "xm",
            (Image) Resources.play
          },
          {
            "mod",
            (Image) Resources.play
          },
          {
            "au",
            (Image) Resources.play
          },
          {
            "sf2",
            (Image) Resources.play
          },
          {
            "mid",
            (Image) Resources.play
          },
          {
            "alac",
            (Image) Resources.play
          },
          {
            "ogv",
            (Image) Resources.play
          },
          {
            "avi",
            (Image) Resources.play
          },
          {
            "vob",
            (Image) Resources.play
          },
          {
            "txt",
            (Image) Resources.noteicon
          },
          {
            "inf",
            (Image) Resources.noteicon
          },
          {
            "bat",
            (Image) Resources.noteicon
          },
          {
            "cmd",
            (Image) Resources.noteicon
          },
          {
            "nt",
            (Image) Resources.noteicon
          },
          {
            "cfg",
            (Image) Resources.noteicon
          },
          {
            "asm",
            (Image) Resources.noteicon
          },
          {
            "js",
            (Image) Resources.noteicon
          },
          {
            "css",
            (Image) Resources.noteicon
          },
          {
            "html",
            (Image) Resources.noteicon
          },
          {
            "log",
            (Image) Resources.noteicon
          },
          {
            "prf",
            (Image) Resources.noteicon
          },
          {
            "xml",
            (Image) Resources.noteicon
          },
          {
            "iso",
            (Image) Resources.disc
          },
          {
            "cue",
            (Image) Resources.disc
          },
          {
            "bup",
            (Image) Resources.disc
          },
          {
            "img",
            (Image) Resources.disk
          },
          {
            "ima",
            (Image) Resources.disk
          },
          {
            "vhd",
            (Image) Resources.hdd
          },
          {
            "vmdk",
            (Image) Resources.hdd
          },
          {
            "vdi",
            (Image) Resources.hdd
          }
        };
        string[] shellPreviews = { "ico", "cur", "ani", "exe"};

        public bool EnableGradient = true;


        string[] filenames;
        string outfile = "";
        int progress = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private Image HueShift(Image original)
        {
            Bitmap bitmap = new Bitmap(original, original.Size);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            for (int y = 0; y < original.Size.Height; ++y)
            {
                for (int x = 0; x < original.Size.Width; ++x)
                {
                    System.Drawing.Color pixel = bitmap.GetPixel(x, y);
                    int red = (int)pixel.R + this.huevectors[0];
                    int green = (int)pixel.G + this.huevectors[1];
                    int blue = (int)pixel.B + this.huevectors[2];
                    if (red > (int)byte.MaxValue)
                    {
                        red = (int)byte.MaxValue;
                        this.huevectors[0] = -15;
                    }
                    else if (red < 0)
                    {
                        red = 0;
                        this.huevectors[0] = 15;
                    }
                    if (green > (int)byte.MaxValue)
                    {
                        green = (int)byte.MaxValue;
                        this.huevectors[1] = -15;
                    }
                    else if (green < 0)
                    {
                        green = 0;
                        this.huevectors[1] = 15;
                    }
                    if (blue > (int)byte.MaxValue)
                    {
                        blue = (int)byte.MaxValue;
                        this.huevectors[2] = -15;
                    }
                    else if (blue < 0)
                    {
                        blue = 0;
                        this.huevectors[2] = 15;
                    }
                    Brush brush = (Brush)new SolidBrush(System.Drawing.Color.FromArgb((int)pixel.A, red, green, blue));
                    graphics.FillRectangle(brush, x, y, 1, 1);
                }
            }
            return (Image)bitmap;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        string DetectDrive()
        {
            string drv = "A:";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<string> letters = new List<string>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (Directory.Exists(alphabet.Substring(i, 1).ToString() + ":\\E_INFO"))
                {
                    drv = alphabet.Substring(i, 1) + ":";
                    letters.Add(drv);
                }
            }
            if (letters.Count > 1)
            {
                DataCollectTimer.Enabled = false;
                SelectDrive sd = new SelectDrive();

                foreach (DriveInfo d in DriveInfo.GetDrives())
                {
                    if (d.IsReady)
                    {
                        string s = d.RootDirectory.Name.ToString().Replace("\\", "");
                        if (letters.Contains(s))
                        {
                            string[] items = new string[4];

                            items[0] = s;
                            items[1] = Math.Round(Convert.ToDouble(d.TotalSize / 1000 / 1000 / 1000), 2).ToString() + " GB";
                            if (d.VolumeLabel.ToString() != "")
                            {
                                items[2] = d.VolumeLabel.ToString();
                            }
                            else
                            {
                                if (!File.Exists(d.RootDirectory + "autorun.inf"))
                                {
                                    items[2] = "Sildita irdseade";
                                }
                                else
                                {
                                    string[] autoruninf = File.ReadAllText(d.RootDirectory + "autorun.inf", Encoding.GetEncoding("windows-1252")).Replace("\r\n", "\n").Split('\n');
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
                }
                sd.parent = this;
                sd.firstlocation = new Point(this.Location.X + Convert.ToInt32(this.Size.Width / 2) - Convert.ToInt32(sd.Size.Width / 2), this.Location.Y + Convert.ToInt32(this.Size.Height / 2) - Convert.ToInt32(sd.Height / 2));
                sd.Location = sd.firstlocation;
                if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    drv = sd.FinalLetter;
                    DataCollectTimer.Enabled = true;
                }
                else
                {
                    DataCollectTimer.Enabled = false;
                    this.progressBar1.Visible = false;
                    this.Close();
                }
            }
            this.Text = "Markuse mälupulk (andmete kogumine)";
            return drv;
        }

        void DebugMessage(string msg)
        {
            DataCollectTimer.Enabled = false;
            MessageBox.Show(msg);
            DataCollectTimer.Enabled = true;
        }
        private void DataCollectTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label20.Text = "ühendatud";
                CheckIfConnected.Enabled = true;
                progressBar1.Visible = false;
                label3.Visible = false;
                button4.Visible = true;
                flp1.Enabled = true;
                DataCollectTimer.Enabled = false;
                TabButton_5.Enabled = true;
                TabButton_6.Enabled = true;
            }
            else
            {
                try
                {
                    if (progressBar1.Value == 0)
                    {
                        allvideosbutton.Enabled = false;
                    }
                    else if (progressBar1.Value == 2)
                    {
                    //2
                        if (checkBox3.Checked)
                        {
                            drive = "Z:";
                            drive = DetectDrive();
                        }
                        if (!Directory.Exists(drive + "\\E_INFO"))
                        {
                            label20.Text = "seadmete otsimine...";
                            progressBar1.Style = ProgressBarStyle.Marquee;
                            return;
                        }
                        progressBar1.Style = ProgressBarStyle.Continuous;
                        DataCollectTimer.Enabled = true;
                        label20.Text = "uudiste avastamine...";
                    }
                    if (progressBar1.Value == 20)
                    {
                        //6
                        if (File.Exists(drive + "\\E_INFO\\uudis1.rtf"))
                        {
                            string path = drive + "\\E_INFO\\uudis1.rtf";
                            using (File.OpenRead(path))
                                richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
                            Tab_0.Visible = true;
                        }
                        else
                        {
                            Tab_0.Visible = false;
                            Tab_1.Visible = true;
                            this.TabButton_0.Font = new Font(this.TabButton_1.Font, FontStyle.Regular);
                            this.TabButton_1.Font = new Font(this.TabButton_1.Font, FontStyle.Bold);
                        }
                        flp1.Enabled = true;
                        label20.Text = "uusimate videote avastamine...";
                    }
                    if (progressBar1.Value == 35)
                    {
                        //8
                        if (Directory.Exists(drive + "\\Markuse_videod"))
                        {
                            foreach (FileInfo fi in new DirectoryInfo(drive + "\\Markuse_videod").GetFiles())
                            {
                                if (fi.Name.Contains(". "))
                                {
                                    string filename = fi.Name.Split('.')[1].Substring(1) + "." + fi.Name.Split('.')[2];
                                    listBox1.Items.Add(filename);
                                }
                            }
                            TabButton_0.Enabled = true;
                        }
                        else
                        {
                            Tab_0.Visible = false;
                            Tab_1.Visible = true;
                            this.TabButton_0.Font = new Font(this.TabButton_1.Font, FontStyle.Regular);
                            this.TabButton_1.Font = new Font(this.TabButton_1.Font, FontStyle.Bold);
                        }
                        label20.Text = "kaustade avastamine...";
                    }
                    if (progressBar1.Value == 65)
                    {
                        if (Directory.Exists(drive + "\\markuse asjad\\markuse asjad"))
                        {
                            //11
                            foreach (string fi in Directory.GetDirectories(drive + "\\markuse asjad\\markuse asjad"))
                            {
                                if (fi.Replace(drive + "\\markuse asjad\\markuse asjad\\", "") == "Mine")
                                {
                                    continue;
                                }
                                else if (fi.Replace(drive + "\\markuse asjad\\markuse asjad\\", "") == "_Template")
                                {
                                    continue;
                                }
                                else
                                {
                                    allvideosbutton.Enabled = Directory.Exists(string.Format(@"{0}\\Minu videod", fi));
                                    listBox2.Items.Add(fi.Replace(drive + "\\markuse asjad\\markuse asjad\\", ""));
                                }
                            }
                            button7.Enabled = Directory.Exists(drive + "\\markuse asjad\\markuse asjad");
                            button13.Enabled = Directory.Exists(drive + "\\markuse asjad");
                            button8.Enabled = Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused");
                            button10.Enabled = Directory.Exists(drive + "\\markuse asjad\\Abi ja info");
                            button9.Enabled = Directory.Exists(drive + "\\Markuse_videod");
                            button11.Enabled = Directory.Exists(drive + "\\Pakkfailid");
                            button12.Enabled = Directory.Exists(drive + "\\multiboot");
                            button15.Enabled = Directory.Exists(drive + "\\markuse asjad\\markuse asjad\\Mine");
                            TabButton_1.Enabled = true;
                        }
                        else
                        {
                            Tab_1.Visible = false;
                            Tab_3.Visible = true;
                            this.TabButton_3.Font = new Font(this.TabButton_2.Font, FontStyle.Bold);
                            this.TabButton_1.Font = new Font(this.TabButton_2.Font, FontStyle.Regular);
                        }
                        label20.Text = "kiirrakenduste avastamine...";
                    }
                    if (progressBar1.Value == 87)
                    {
                        // 11
                        if (Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused"))
                        {
                            DataCollectTimer.Enabled = false;
                            ThreadStart ts = new ThreadStart(FQApps);
                            Thread t = new Thread(ts);
                            t.Start();
                            waitForQAppThread.Enabled = true;
                        }
                    }
                    if (progressBar1.Value == 98)
                    {
                        if (File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\setting2.sf"))
                        {
                            string[] vs = File.ReadAllText(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\setting2.sf", Encoding.ASCII).Split('=');
                            if (vs[1].ToString() == "true")
                            {
                                checkBox1.Checked = true;
                            }
                            else if (vs[1].ToString() == "true")
                            {
                                checkBox1.Checked = true;
                            }
                        }
                        label20.Text = "teabe tuvastamine...";
                    }
                    if (progressBar1.Value == 109)
                    {
                        DriveLabel.Text = "Draiv: " + drive;
                        EditionLabel.Text = "Väljaanne: " + File.ReadAllText(drive + "\\E_INFO\\edition.txt");
                        if (File.ReadAllText(drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("ultimate"))
                        {
                            this.EditionColor.BackColor = System.Drawing.Color.BlueViolet;
                            button21.Enabled = true;
                        }
                        else if (File.ReadAllText(drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("premium"))
                        {
                            this.EditionColor.BackColor = System.Drawing.Color.DarkRed;
                            button21.Enabled = true;
                        }
                        else if (File.ReadAllText(drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("basic"))
                        {
                            this.EditionColor.BackColor = System.Drawing.Color.LimeGreen;
                            button21.Enabled = false;
                        }
                        DriveInfo[] allDrives = DriveInfo.GetDrives();

                        foreach (DriveInfo d in allDrives)
                        {
                            if (d.Name == drive + "\\")
                            {
                                FsLabel.Text = "Failisüsteem: " + d.DriveFormat.ToString();
                                CapacityLabel.Text = "Maht: " + Math.Round(((d.TotalSize) / 1024.0 / 1024.0 / 1024.0), 1).ToString().Replace(",", ".") + " GiB (" + Math.Round(((d.TotalSize) / 1000.0 / 1000.0 / 1000.0), 1).ToString().Replace(",", ".") + " GB)";
                            }
                        }
                        label20.Text = "programmi info avastamine...";
                    }
                    if (progressBar1.Value == 120)
                    {
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                        VersionLabel.Text = "Versioon: " + fvi.FileVersion;
                        DateLabel.Text = "Kuupäev: " + File.GetLastWriteTime(Environment.CurrentDirectory + "\\Markuse mälupulk.exe").ToString().Split(' ')[0].ToString();
                        label20.Text = "statistika avastamine...";
                        TabButton_3.Enabled = true;

                    }
                    if (progressBar1.Value == 142)
                    {
                        new Thread(() => GetDirSize(new DirectoryInfo(drive + "\\markuse asjad\\markuse asjad"))).Start();
                        new Thread(() => GetDirSize(new DirectoryInfo(drive + "\\multiboot"))).Start();
                        new Thread(() => GetDirSize(new DirectoryInfo(drive + "\\sources"))).Start();
                        new Thread(() => GetDirSize(new DirectoryInfo(drive + "\\Pakkfailid"))).Start();
                        new Thread(() => GetDirSize(new DirectoryInfo(drive + "\\markuse asjad\\Kiirrakendused"))).Start();
                        new Thread(() => GetGameSize()).Start();
                        this.chart1.Titles["Title1"].ForeColor = this.ForeColor;
                        this.chart1.Legends["Legend1"].ForeColor = this.ForeColor;
                        this.chart1.Series["Series1"]["PieLabelStyle"] = "Disabled";
                        DataCollectTimer.Enabled = false;
                        waitForComplete.Enabled = true;
                    }
                    if (progressBar1.Value < 55)
                    {
                        incremental++;
                    }
                    else if (progressBar1.Value > 150)
                    {
                        incremental--;
                    }
                    if (progressBar1.Value + incremental > progressBar1.Maximum)
                    {
                        progressBar1.Value = progressBar1.Maximum;
                        DataCollectTimer.Interval = 10;
                        checkBox3.Enabled = true;
                        return;
                    }
                    progressBar1.Increment(incremental);
                }
                catch (Exception ex)
                {
                    progressBar1.Value = progressBar1.Maximum;
                    label20.Text = "pole ühendatud";
                    progressBar1.Visible = false;
                    CheckIfConnected.Enabled = true;
                    progressBar1.Visible = false;
                    label3.Visible = false;
                    button4.Visible = true;
                    flp1.Enabled = true;
                    DataCollectTimer.Enabled = false;
                    TabButton_5.Enabled = true;
                    TabButton_6.Enabled = true;
                    MessageBox.Show("Seadme initsialiseerimine nurjus\n" + 
                        "Vea kirjeldus: " + ex.Message +
                        "\nTäpsem info: \n" + ex.StackTrace.ToString(), "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            label1.Visible = true;

        }

        void FQApps()
        {
            //11

            prg = new List<string>();
            foreach (string fi in Directory.GetDirectories(drive + "\\markuse asjad\\Kiirrakendused"))
            {
                string fname = fi.Replace(drive + "\\markuse asjad\\Kiirrakendused\\", "").ToString();
                try
                {
                    this.aicon.Images.Add(Icon.ExtractAssociatedIcon(fi.ToString() + "\\" + fname + "Portable.exe"));
                }
                catch
                {
                    this.aicon.Images.Add((Image)Resources.uniprog);
                }
                prg.Add(fname);
            }
            if (Program.simulation) { Thread.Sleep(5000); }
            fqa = true;
            Thread.CurrentThread.Abort();
        }

        public void GetDirSize(DirectoryInfo d)
        {
            if (Program.simulation) { Thread.Sleep(5000); }
            Program.sts.Add(DirSize(d));
            Program.list.Add(d.Name);
            Thread.CurrentThread.Abort();
        }

        public void GetGameSize()
        {
            if (Program.simulation) { Thread.Sleep(5000); }
            long gamedirsize = (long)0;
            gamedirsize += DirSize(new DirectoryInfo(drive + "\\POPS"));
            gamedirsize += DirSize(new DirectoryInfo(drive + "\\CD"));
            gamedirsize += DirSize(new DirectoryInfo(drive + "\\DVD"));
            Program.sts.Add(gamedirsize);
            Program.list.Add("PlayStation mängud");
            Thread.CurrentThread.Abort();
        }

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            try
            {
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }
            }
            catch { }
            // Add subdirectory sizes.
            try
            {
                DirectoryInfo[] dis = d.GetDirectories();
                foreach (DirectoryInfo di in dis)
                {
                    size += DirSize(di);
                }
            }
            catch { }
            return size;
        }
        int GetPage()
        {
            string[] articles = ArticleLabel.Text.Replace("Artikkel ", "").Split('/');
            int PageNumber = Convert.ToInt32(articles[0].ToString());
            return PageNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = drive + "\\E_INFO\\uudis" + GetPage().ToString() + ".rtf";
            if (File.Exists(path))
            {
                using (File.OpenRead(path))
                    richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
            else
            {
                MessageBox.Show("Faili ei saa uuesti laadida. Kas seade on sisestatud arvutisse?", "Faili uuesti laadimine nurjus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int newpage = GetPage() + 1;
            if (newpage > 5)
            {
                newpage = 1;
            }
            string path = drive + "\\E_INFO\\uudis" + newpage.ToString() + ".rtf";
            if (File.Exists(path))
            {
                using (File.OpenRead(path))
                    richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.Text = "Faili laadimine nurjus.";
            }
            ArticleLabel.Text = "Artikkel " + newpage.ToString() + "/5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newpage = GetPage() - 1;
            if (newpage < 1)
            {
                newpage = 5;
            }
            string path = drive + "\\E_INFO\\uudis" + newpage.ToString() + ".rtf";
            if (File.Exists(path)) {
            using (File.OpenRead(path))
                richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            } else {
                richTextBox1.Text = "Faili laadimine nurjus.";
            }
            ArticleLabel.Text = "Artikkel " + newpage.ToString() + "/5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Visible)
            {
                MessageBox.Show("Andmeid ei saa praegu värskendada, kuna mälupulk on hõivatud. Proovige hiljem uuesti.", "Andmete värskendamine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                CheckIfConnected.Enabled = false;
                Program.sts.Clear();
                Program.list.Clear();
                chart1.Series.Clear();
                checkBox3.Enabled = false;
                chart1.Series.Add("Series1");
                chart1.Series["Series1"].ChartType = SeriesChartType.Doughnut;
                TabCollection.SelectedIndex = 0;
                TabCollection.SwitchTab();
                ArticleLabel.Text = "Artikkel 1/5";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listView1.Items.Clear();
                listView2.Items.Clear();
                progressBar1.Value = this.progressBar1.Minimum;
                incremental = 1;
                flp1.Enabled = false;
                button6.Enabled = false;
                listBox3.ClearSelected();
                listBox3.Enabled = false;
                progressBar1.Visible = true;
                label3.Visible = true;
                richTextBox1.Text = "";
            }
            catch
            {
            }
            this.Text = "Markuse mälupulk (andmete kogumine)";
            DataCollectTimer.Enabled = true;
            TabButton_5.Visible = false;
            Tab_0.Visible = false;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.StartsWith("TabButton_"))
                    {
                        c.Enabled = false;
                    }
                }
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           this.button6.Enabled = (listBox1.SelectedIndices.Count > 0) && File.Exists(String.Format(drive + @"\Markuse_videod\{0}. {1}", (listBox1.SelectedIndex + 1).ToString(), listBox1.SelectedItem.ToString()));
        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].LabelForeColor = this.ForeColor;
            if (this.chart1.Series["Series1"].ChartType == SeriesChartType.Doughnut)
                this.chart1.Series["Series1"].ChartType = SeriesChartType.StackedBar;
            else if (this.chart1.Series["Series1"].ChartType == SeriesChartType.StackedBar)
                this.chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            else if (this.chart1.Series["Series1"].ChartType == SeriesChartType.Pie)
                this.chart1.Series["Series1"].ChartType = SeriesChartType.Pyramid;
            else if (this.chart1.Series["Series1"].ChartType == SeriesChartType.Pyramid)
                this.chart1.Series["Series1"].ChartType = SeriesChartType.Bubble;
            else
                this.chart1.Series["Series1"].ChartType = SeriesChartType.Doughnut;
        }

        private void ThemeChecker_Tick(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\scheme.cfg"))
            {
                this.LoadTheme();
                if (this.drive != "null")
                {
                    if (File.ReadAllText(this.drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("ultimate"))
                        this.EditionColor.BackColor = System.Drawing.Color.BlueViolet;
                    else if (File.ReadAllText(this.drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("premium"))
                        this.EditionColor.BackColor = System.Drawing.Color.DarkRed;
                    else if (File.ReadAllText(this.drive + "\\E_INFO\\edition.txt").ToString().ToLower().Contains("basic"))
                        this.EditionColor.BackColor = System.Drawing.Color.LimeGreen;
                    else
                        this.EditionColor.BackColor = System.Drawing.Color.Gray;
                }
                this.closeButton.BackColor = System.Drawing.Color.DarkRed;
                this.closeButton.ForeColor = System.Drawing.Color.White;
            }
            this.richTextBox1.ForeColor = this.ForeColor;
        }

        public void LoadTheme()
        {
            try
            {
                string[] strArray1 = File.ReadAllText(Environment.GetEnvironmentVariable("HOMEDRIVE").ToString() + "\\mas\\scheme.cfg").Split(';');
                string[] strArray2 = strArray1[0].ToString().Split(':');
                string[] strArray3 = strArray1[1].ToString().Split(':');
                this.Applytheme(System.Drawing.Color.FromArgb(Convert.ToInt32(strArray2[0].ToString()), Convert.ToInt32(strArray2[1].ToString()), Convert.ToInt32(strArray2[2].ToString())), System.Drawing.Color.FromArgb(Convert.ToInt32(strArray3[0].ToString()), Convert.ToInt32(strArray3[1].ToString()), Convert.ToInt32(strArray3[2].ToString())));
                this.pictureBox4.BackgroundImage = Image.FromFile(Environment.GetEnvironmentVariable("HOMEDRIVE").ToString() + "\\mas\\bg_common.png");
            }
            catch
            {
            }
        }

        public void Applytheme(System.Drawing.Color bg, System.Drawing.Color fg)
        {
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control is Button && !control.Name.StartsWith("TabButton_"))
                {
                    control.BackColor = SystemColors.Control;
                    control.ForeColor = SystemColors.ControlText;
                }
                if (control is TextBox)
                {
                    control.BackColor = bg;
                    control.ForeColor = fg;
                }
                if (control is ComboBox)
                {
                    control.BackColor = bg;
                    control.ForeColor = fg;
                }
            }
            Control[] controlArray = new Control[12]
            {
        (Control) this.Tab_0,
        (Control) this.Tab_1,
        (Control) this.Tab_2,
        (Control) this.Tab_3,
        (Control) this.Tab_4,
        (Control) this.Tab_6,
        (Control) this.splitContainer1,
        (Control) this.splitContainer2,
        (Control) this.flp2,
        (Control) this.flp4,
        (Control) this.tableLayoutPanel1,
        (Control) this.tableLayoutPanel2
            };
            foreach (Control control1 in controlArray)
            {
                foreach (Control control2 in (ArrangedElementCollection)control1.Controls)
                {
                    if (!(control2 is Button) && !(control2.Name == "EditionColor"))
                    {
                        control2.BackColor = bg;
                        control2.ForeColor = fg;
                    }
                }
            }
            this.listBox1.BackColor = bg;
            this.listBox2.BackColor = bg;
            this.button6.BackColor = SystemColors.Control;
            this.button6.ForeColor = SystemColors.ControlText;
            this.listBox3.BorderStyle = BorderStyle.FixedSingle;
            this.listBox3.BackColor = bg;
            this.listView2.BackColor = bg;
            this.listBox1.ForeColor = fg;
            this.listBox2.ForeColor = fg;
            this.listBox3.ForeColor = fg;
            this.listView2.ForeColor = fg;
            this.statusStrip1.BackColor = bg;
            this.statusStrip1.ForeColor = fg;
            this.EditionLabel.ForeColor = fg;
            this.EditionLabel.LinkColor = fg;
            this.EditionLabel.ActiveLinkColor = fg;
            this.EditionLabel.VisitedLinkColor = fg;
            this.BackColor = bg;
            this.ForeColor = fg;
            this.DrawOverlay();
        }

        private void DrawOverlay()
        {
            Bitmap bitmap1 = new Bitmap(this.pictureBox4.Width, this.pictureBox4.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap1);
            Brush brush = (Brush)new SolidBrush(this.ForeColor);
            if (this.EnableGradient)
            {
                int alpha = 0;
                for (int y = 0; y < bitmap1.Height; ++y)
                {
                    Pen pen = new Pen(System.Drawing.Color.FromArgb(alpha, (int)this.BackColor.R, (int)this.BackColor.G, (int)this.BackColor.B), 1f);
                    graphics.DrawLine(pen, new Point(0, y), new Point(bitmap1.Width, y));
                    alpha += 4;
                    if (alpha > (int)byte.MaxValue)
                        alpha = (int)byte.MaxValue;
                }
            }
            Bitmap bitmap2 = new Bitmap((Image)Resources.mas_flash, new Size(28, 32));
            graphics.DrawImage((Image)bitmap2, new Point(this.pictureBox4.Width / 2 - bitmap2.Width / 2, this.pictureBox4.Height / 2 - bitmap2.Height + 9));
            graphics.DrawString("markuse mälupulk", new Font("Segoe UI", 14f, FontStyle.Regular), brush, (PointF)new Point(this.pictureBox4.Width / 2 - 80, this.pictureBox4.Height / 2 + 11));
            this.pictureBox4.Image = (Image)bitmap1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.DrawOverlay();
            if (this.TabCollection.SelectedIndex != 2 || this.loadedimage == null || this.splitContainer2.Panel2Collapsed)
                return;
            Bitmap bitmap = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            graphics.DrawImage(this.loadedimage, new Point(0, 0));
            if (this.EnableGradient)
            {
                for (int y = 0; y < this.loadedimage.Height; ++y)
                {
                    int alpha = 60;
                    for (int x = 0; x < 20; ++x)
                    {
                        Pen pen = new Pen(System.Drawing.Color.FromArgb(alpha, (int)this.BackColor.R, (int)this.BackColor.G, (int)this.BackColor.B), 1f);
                        graphics.DrawLine(pen, new Point(0, y), new Point(x, y));
                        graphics.DrawLine(pen, new Point(this.pictureBox2.Width, y), new Point(this.pictureBox2.Width - x, y));
                        alpha -= 3;
                        if (alpha < 0)
                            alpha = 0;
                    }
                }
                for (int x = 0; x < this.loadedimage.Width; ++x)
                {
                    int alpha = 60;
                    for (int y = 0; y < 20; ++y)
                    {
                        Pen pen = new Pen(System.Drawing.Color.FromArgb(alpha, (int)this.BackColor.R, (int)this.BackColor.G, (int)this.BackColor.B), 1f);
                        graphics.DrawLine(pen, new Point(x, 0), new Point(x, y));
                        graphics.DrawLine(pen, new Point(x, this.pictureBox2.Height), new Point(x, this.pictureBox2.Height - y));
                        alpha -= 3;
                        if (alpha < 0)
                            alpha = 0;
                    }
                }
            }
            this.pictureBox2.Image = (Image)bitmap;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(drive + "\\Markuse_videod\\" + (listBox1.SelectedIndex + 1).ToString() + ". " + listBox1.SelectedItem.ToString()))
            {
                Process.Start(drive + "\\Markuse_videod\\" + (listBox1.SelectedIndex + 1).ToString() + ". " + listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Videofaili ei saa esitada. Kas seade on sisestatud arvutisse?", "Ei saa faili avada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        struct TabSelect
        {
            public int SelectedIndex;

            public void SwitchTab()
            {
                int localindex = this.SelectedIndex;
                foreach (Control c in Program.f1.Controls)
                {
                    if (c is Panel)
                    {
                        c.Visible = false;
                        if (c.Name == "Tab_" + localindex.ToString())
                        {
                            c.Visible = false;
                            if (c.Name == "Tab_" + localindex.ToString())
                                c.Visible = true;
                        }
                    }
                    else if (c is Button && c.Name.StartsWith("TabButton_"))
                    {
                        if (c.Name.EndsWith(localindex.ToString()))
                        {
                            Font font = new Font(c.Font, FontStyle.Bold);
                            c.Font = font;
                        }
                        else
                        {
                            Font font = new Font(c.Font, FontStyle.Regular);
                            c.Font = font;
                        }
                    }
                }
            }
        }

        private void TabButton_0_Click(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 0;
            TabCollection.SwitchTab();
        }

        private void TabButton_1_Click(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 1;
            TabCollection.SwitchTab();
        }

        private void TabButton_2_Click(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 2;
            TabCollection.SwitchTab();
            listView2.SelectedItems.Clear();
            this.pictureBox2.Image = (Image)Resources.f22170384;
            label10.Text = "Kiirrakendused on nagu tavalised töölauarakendused, mida leiate enda arvutist, aga neil on eriline funktsioon: need töötavad kohe igas arvutis otse mälupulgalt.";
            label9.Text = "Kiirrakendused";
        }

        private void TabButton_3_Click(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 3;
            TabCollection.SwitchTab();
        }

        private void TabButton_4_Click(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 4;
            TabCollection.SwitchTab();
        }

        private void TabButton_5_Click(object sender, EventArgs e)
        {
            Parool p = new Parool();
            if (!File.Exists(drive + "\\NTFS\\config.sys"))
            {
                MessageBox.Show("Arendusvalikute muutmiseks ühendage seade", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(drive + "\\NTFS\\spin.sys"))
            {
                if (current_pin != File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString())
                {
                    string ostr = File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString();
                    p.Text = "Arendamise valikud nõuavad autentimist";
                    p.currentpin = "";
                    p.ShowDialog();
                    byte[] correct = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(p.currentpin));
                    string cstr = "";
                    foreach (byte b in correct)
                    {
                        cstr += b.ToString("X2");
                    }
                    string s = File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString();
                    current_pin = cstr;
                    if (cstr != ostr)
                    {
                        MessageBox.Show("Vale PIN kood", "Arendamise valikud nõuavad autentimist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        button31.Visible = true;
                    }
                }
            }
            else if (File.Exists(drive + "\\NTFS\\config.sys"))
            {
                if (current_pin != File.ReadAllLines(drive + "\\NTFS\\config.sys", Encoding.ASCII)[0].ToString())
                {
                    string ostr = File.ReadAllLines(drive + "\\NTFS\\config.sys", Encoding.ASCII)[0].ToString();
                    p.Text = "Arendamise valikud nõuavad autentimist";
                    p.currentpin = "";
                    p.ShowDialog();
                    current_pin = p.currentpin;
                    if (p.currentpin != ostr)
                    {
                        MessageBox.Show("Vale PIN kood", "Arendamise valikud nõuavad autentimist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            TabCollection.SelectedIndex = 6;
            TabCollection.SwitchTab();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            UndoSelected();
            current_dir = drive + "\\";
            SwitchDir();
        }

        void UndoSelected()
        {
            listBox3.ClearSelected();
            listBox3.Enabled = false;
            listBox2.ClearSelected();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\markuse asjad\\markuse asjad"))
            {
                UndoSelected();
                current_dir = drive + "\\markuse asjad\\markuse asjad";
                SwitchDir();
            }
            else
            {
                MessageBox.Show("Seda kausta pole olemas", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\markuse asjad"))
            {
                UndoSelected();
                current_dir = drive + "\\markuse asjad";
                SwitchDir();
            }
            else
            {
                button13.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused"))
            {
                UndoSelected();
                current_dir = drive + "\\markuse asjad\\Kiirrakendused";
                SwitchDir();
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\Markuse_videod"))
            {
                UndoSelected();
                current_dir = drive + "\\Markuse_videod";
                SwitchDir();
            }
            else
            {
                button9.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\markuse asjad\\Abi ja info"))
            {
                UndoSelected();
                current_dir = drive + "\\markuse asjad\\Abi ja info";
                SwitchDir();
            }
            else
            {
                button10.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\Pakkfailid"))
            {
                UndoSelected();
                current_dir = drive + "\\Pakkfailid";
                SwitchDir();
            }
            else
            {
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\multiboot"))
            {
                UndoSelected();
                current_dir = drive + "\\multiboot";
                SwitchDir();
            }
            else
            {
                button12.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(drive + "\\markuse asjad\\markuse asjad\\Mine"))
            {
                UndoSelected();
                current_dir = drive + "\\markuse asjad\\markuse asjad\\Mine";
                SwitchDir();
            }
            else
            {
                button15.Enabled = false;
            }
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox3.Enabled = (listBox2.SelectedIndices.Count > 0);
            button30.Enabled = (listBox2.SelectedIndices.Count > 0);
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndices.Count > 0)
            {
                current_dir = drive + "\\markuse asjad\\markuse asjad\\" + listBox2.SelectedItem.ToString() + "\\" + listBox3.SelectedItem.ToString();
                SwitchDir();
            }
            
        }

        void SwitchDir()
        {
            listView1.Items.Clear();
            icons.Images.Clear();
            icons.Images.Add(Resources.folder);
            ListViewItem currentbtn = new ListViewItem();
            currentbtn.ImageIndex = 0;
            currentbtn.SubItems[0].Text = ".";
            ListViewItem backbtn = new ListViewItem();
            backbtn.ImageIndex = 0;
            backbtn.SubItems[0].Text = "..";
            listView1.Items.Add(currentbtn);
            listView1.Items.Add(backbtn);
            foreach (DirectoryInfo dir in new DirectoryInfo(current_dir).GetDirectories())
            {
                ListViewItem li = new ListViewItem();
                li.ImageIndex = 0;
                li.SubItems[0].Text = dir.Name;
                listView1.Items.Add(li);
            }

            foreach (FileInfo fileInfo in (IEnumerable<FileInfo>)((IEnumerable<FileInfo>)new DirectoryInfo(this.current_dir).GetFiles()).OrderBy<FileInfo, string>((Func<FileInfo, string>)(file => file.Name)))
            {
                bool flag = false;
                Image image = (Image)null;
                foreach (KeyValuePair<string, Image> shellIcon in (IEnumerable<KeyValuePair<string, Image>>)this.shellIcons)
                {
                    string[] strArray = fileInfo.Name.Split('.');
                    if (((IEnumerable<string>)this.shellPreviews).Contains<string>(strArray[strArray.Length - 1].ToLower()))
                    {
                        try
                        {
                            image = (Image)Icon.ExtractAssociatedIcon(fileInfo.FullName).ToBitmap();
                            flag = true;
                            break;
                        }
                        catch
                        {
                            image = !(strArray[strArray.Length - 1].ToLower() != "exe") ? (Image)Resources.apps : (Image)Resources.GeneralFile;
                            break;
                        }
                    }
                    else if (shellIcon.Key.ToUpper() == strArray[strArray.Length - 1].ToUpper())
                    {
                        flag = true;
                        image = shellIcon.Value;
                    }
                    else if (shellIcon.Key.Length > 3 && shellIcon.Key.Substring(0, 3).ToUpper() == strArray[strArray.Length - 1].ToUpper())
                    {
                        flag = true;
                        image = shellIcon.Value;
                    }
                }
                if (!flag)
                    this.icons.Images.Add((Image)Resources.GeneralFile);
                else
                    this.icons.Images.Add(image);
                this.listView1.Items.Add(new ListViewItem()
                {
                    ImageIndex = this.icons.Images.Count - 1,
                    SubItems = {
                        [0] = {
                            Text = fileInfo.Name
                        }
                    }
                });
            }
            listView1.Visible = true;
            label26.Text = "Failisirvija (" + current_dir + ")";
        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenApp();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DeleteApp();
        }

        void OpenApp()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = drive + "\\markuse asjad\\Kiirrakendused\\" + listView2.SelectedItems[0].Text.ToString() + "\\" + listView2.SelectedItems[0].Text.ToString() + "Portable.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.WorkingDirectory = drive + "\\markuse asjad\\Kiirrakendused\\" + listView2.SelectedItems[0].Text.ToString();
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tundub, et rakenduse käivitumine ebaõnnestus. Põhjus on järgmine:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DeleteApp()
        {
            try
            {
                Directory.Delete(drive + "\\markuse asjad\\Kiirrakendused\\" + listView2.SelectedItems[0].Text.ToString(), true);
                listView2.Items.Clear();
                if (Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused"))
                {
                    foreach (string fi in Directory.GetDirectories(drive + "\\markuse asjad\\Kiirrakendused"))
                    {
                        listView2.Items.Add(fi.Replace(drive + "\\markuse asjad\\Kiirrakendused\\", "").ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tundub, et rakenduse kustutamine ebaõnnestus. Põhjus on järgmine:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.closeButton.BackColor = Color.DarkRed;
                this.closeButton.ForeColor = Color.White;
                closeButton.Visible = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                closeButton.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\settings2.sf", "AutoRun=" + checkBox1.Checked.ToString().ToLower(), Encoding.ASCII);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //muuda mälupulga nime
            InputBox ib = new InputBox();
            ib.InputMsg.Text = "Sisestage uus mälupulga nimi";
            ib.Text = "Mälupulga nime muutmine";
            if (ib.ShowDialog() == DialogResult.OK)
            {
                try
                { 
                    string content = "[Autorun]\r\nlabel=" + ib.InputTxt.Text + "\r\nicon=autorun.exe,0\r\n";
                    File.WriteAllText(drive + "\\autorun.inf", content, Encoding.GetEncoding("windows-1252"));
                    MessageBox.Show("Mälupulga nimi muudeti edukalt. Väljutage mälupulk ja sisestage see uuesti, et muudatusi näha", "Toiming õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Midagi läks valesti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Kasutaja katkestas toimingu", "Mälupulga nime ei muudetud", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //muuda pin koodi
            try
            {
                if (!Directory.Exists(drive + "\\NTFS")) { Directory.CreateDirectory(drive + "\\NTFS"); }
            }
            catch
            {
                MessageBox.Show("Juurdepääs asukohale \"" + drive + "\\NTFS\" puudub. Kas seade on ühendatud?", "Ei saa PIN koodi muuta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Parool p = new Parool();
            if (MessageBox.Show("Kas soovite sisse lülitada ebaturvalise PIN-koodi? See on vajalik, kui soovite mälupulka hallata vanemate programmidega. Pange tähele, et ebaturvaline PIN kood ei ole krüptitud ning lihtsasti kättesaadav ükskõik millisele kasutajale.", "Ebaturvalise PIN-koodi seadistamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (File.Exists(drive + "\\NTFS\\spin.sys"))
                {
                    if (current_pin != File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString())
                    {
                        p.Text = "Kinnitamiseks sisestage vana PIN kood";
                        p.currentpin = "";
                        p.ShowDialog();
                        string s = File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString();

                        byte[] correct = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(p.currentpin));
                        string cstr = "";
                        foreach (byte b in correct)
                        {
                            cstr += b.ToString("X2");
                        }
                        if (cstr != s)
                        {
                            MessageBox.Show("Vale PIN kood", "Toiming katkestati", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            button31.Visible = true;
                        }
                    }
                }
                p.Text = "Sisestage uus PIN kood";
                p.currentpin = "";
                p.ShowDialog();
                try
                {
                    File.WriteAllText(drive + "\\NTFS\\config.sys", p.currentpin + "\n", Encoding.ASCII);
                    MessageBox.Show("Uus PIN kood salvestati edukalt", "Toiming õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PIN koodi salvestamine nurjus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                File.WriteAllText(drive + "\\NTFS\\config.sys", "Ebaturvaline PIN kood keelatud\nInsecure authentication code disabled\n", Encoding.ASCII);
                MessageBox.Show("Ebaturvaline PIN kood lülitati edukalt välja", "Toiming õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //teisenda väljaandeks
            if (File.Exists(drive + "\\NTFS\\config.sys"))
            {
                Parool p = new Parool();
                if (p.currentpin != File.ReadAllLines(drive + "\\NTFS\\config.sys", Encoding.ASCII)[0].ToString())
                {
                    p.Text = "Kinnitamiseks sisestage PIN kood";
                    p.currentpin = "";
                    p.ShowDialog();
                    string s = File.ReadAllLines(drive + "\\NTFS\\config.sys", Encoding.ASCII)[0].ToString();
                    if (p.currentpin != s)
                    {
                        MessageBox.Show("Vale PIN kood", "Toiming katkestati", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (MessageBox.Show("See funktsioon võimaldab Markuse mälupulga väljaande teisendada. Kui te teisendate Premium -> Ultimate, siis lisanduvad järgnevad funktsioonid/kui teisendate Ultimate -> Premium kaovad järgmised funktsioonid:\n\nKaustad\nKiirrakendused\n\nKas olete kindel, et soovite jätkata?", "Väljaande teisendamine", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                if (File.Exists(drive + "\\E_INFO\\convert.bat"))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = drive + "\\E_INFO\\convert.bat";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.WorkingDirectory = drive + "\\E_INFO";
                    p.Start();
                }
                else
                {
                    MessageBox.Show("Teisendusprogrammi ei eksisteeri. Kui teie seade kasutab Basic väljaannet, ei ole seda võimalik teisendada.", "Ei saa teisendada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Toiming katkestati", "Muudatusi ei tehtud", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Directory.Exists(drive + "\\NTFS")) { Directory.CreateDirectory(drive + "\\NTFS"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kausta loomine nurjus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists(drive + "\\NTFS\\spin.sys"))
            {
                Parool p = new Parool();
                if (current_pin != File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString())
                {
                    p.Text = "Kinnitamiseks sisestage vana PIN kood";
                    p.currentpin = "";
                    p.BackColor = this.BackColor;
                    p.ForeColor = this.ForeColor;
                    p.ShowDialog();
                    string s = File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString();

                    byte[] correct = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(p.currentpin));
                    string cstr = "";
                    foreach (byte b in correct)
                    {
                        cstr += b.ToString("X2");
                    }
                    if (cstr != s)
                    {
                        MessageBox.Show("Vale PIN kood", "Toiming katkestati", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        button31.Visible = true;
                    }
                }
            }
            else
            {
                if (File.Exists(drive + "\\NTFS\\config.sys"))
                {
                    MessageBox.Show("Varukoopiate haldamiseks tuleb välja lülitada ebaturvaline PIN-kood. Haldamise vahekaardis, valige \"Ebaturvaline PIN kood\", et seda teha..", "Varukoopiate haldamine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (Directory.Exists(drive + "\\"))
            {
                this.Hide();
                Program.theme = new Color[2]
                {
                  BackColor,
                  ForeColor
                };
                //varundamine/taaste
                BackupManager br = new BackupManager();
                br.BackColor = this.BackColor;
                br.ForeColor = this.ForeColor;
                if (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
                {
                    br.WindowState = FormWindowState.Maximized;
                    br.FormBorderStyle = FormBorderStyle.None;
                }
                br.dest_drive = drive + "\\";
                br.parent = this;
                // ajutine lahendus, asenda nii pea kui võimalik
                foreach (DriveInfo di in DriveInfo.GetDrives())
                {
                    if (Directory.Exists(di.RootDirectory.ToString() + "Varukoopiad"))
                    {
                        br.broot = di.RootDirectory.ToString() + "Varukoopiad";
                    }
                }
                br.Show();
            }
            else
            {
                MessageBox.Show("Viga: Seadet pole ühendatud", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.aicon.ImageSize = new Size(48, 48);
            if (File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\irunning.log"))
                this.checkBox2.Checked = true;
            if (Directory.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE").ToString() + "\\mas"))
            {
            }
            if (Directory.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE").ToString() + "\\mas")) { 
                Control[] flows = { flp1, flp2, flp4, Tab_0, Tab_1, Tab_6};
                if (File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\scheme.cfg"))
                    this.LoadTheme();
                else
                    this.DrawOverlay();
                foreach (Control control in (ArrangedElementCollection)this.Controls)
                {
                    if (control is Button && !control.Name.StartsWith("TabButton_"))
                    {
                        control.BackColor = SystemColors.Control;
                        control.ForeColor = SystemColors.ControlText;
                    }
                }
                foreach (Control control1 in flows)
                {
                    foreach (Control control2 in (ArrangedElementCollection)control1.Controls)
                    {
                        if (control2 is Button)
                        {
                            control2.BackColor = SystemColors.Control;
                            control2.ForeColor = SystemColors.ControlText;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tegu pole Markuse arvutiga. Pange tähele, et mõned funktsioonid ei pruugi õigesti töötada.", "Tõenäoliselt ei ole tegu Markuse arvutiga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("See toiming käivitab vanema programmi Markuse mälupulga haldamiseks. Toimingu käigus suletakse mälupulga juhtpaneel. Kas soovite jätkata?", "Käivita universaalprogramm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Process.Start(drive + "\\launcher\\Mälupulk\\bin\\Debug\\Mälupulk.exe");
                this.Close();
            }
            else
            {
                MessageBox.Show("Toiming katkestati", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void listBox5_Click(object sender, EventArgs e)
        {
            button25.Enabled = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (rtfDialog1.ShowDialog() == DialogResult.OK)
            {
                try { 
                    MessageBox.Show("Fail laaditi edukalt mällu", "Uudisefaili laadimine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtb.LoadFile(rtfDialog1.FileName);
                } catch (Exception ex)
                {
                    MessageBox.Show("Faili laadimine ebaõnnestus\nViga: " + ex.Message, "Uudisefaili laadimine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Faili ei laaditud, kuna kasutaja katkestas toimingu", "Uudisefaili laadimine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            addVideoDialog.InitialDirectory = drive + "\\";
            bool done = false;
            while (!done)
            {
                if (addVideoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!addVideoDialog.FileName.StartsWith(drive + "\\"))
                    {
                        if (MessageBox.Show("Videofail peab asuma mälupulgal", "Ei saa uut videot lisada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                        {
                            done = false;
                        }
                        else
                        {
                            done = true;
                        }
                        continue;
                    }
                    try
                    {
                        moveLegacy.Description = "Valige kaust kuhu teisaldada \"" + listBox5.Items[2].ToString() +  "\"";
                        moveLegacy.SelectedPath = drive + "\\";
                        if (moveLegacy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            File.Move(addVideoDialog.FileName, drive + "\\Markuse_videod\\1. " + addVideoDialog.SafeFileName);
                            File.Move(drive + "\\Markuse_videod\\1. " + listBox5.Items[0].ToString(), drive + "\\Markuse_videod\\2. " + listBox5.Items[0].ToString());
                            File.Move(drive + "\\Markuse_videod\\2. " + listBox5.Items[1].ToString(), drive + "\\Markuse_videod\\3. " + listBox5.Items[1].ToString());
                            File.Move(drive + "\\Markuse_videod\\3. " + listBox5.Items[2].ToString(), moveLegacy.SelectedPath + "\\" + listBox5.Items[2].ToString());
                            string second = listBox5.Items[0].ToString();
                            string third = listBox5.Items[1].ToString();
                            listBox5.Items.Clear();
                            listBox5.Items.Add(addVideoDialog.SafeFileName);
                            listBox5.Items.Add(second);
                            listBox5.Items.Add(third);
                            MessageBox.Show("Uus video lisati edukalt. Kui soovite, et uued videod toimiksid vanemates programmides, klõpsake \"Rakenda muudatused\" nuppu.", "Uue video lisamine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            done = true;
                        }
                        else
                        {
                            MessageBox.Show("Ei saanud videot lisada. Põhjus: Te ei määranud kausta, kuhu kolmas video teisaldada.\r\n\r\nMuudatusi ei tehtud.", "Uue video lisamine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            done = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show(ex.Message + "\r\n\r\nVajutage \"Loobu\", et toiming katkestada\r\nVajutage \"Proovi uuesti\", et valida muu fail", "Ei saa uut videot lisada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                        {
                            done = false;
                        }
                        else
                        {
                            done = true;
                        }
                        continue;
                    }
                    done = true;
                }
                else
                {
                    done = true;
                }
            }
            return;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            addVideoDialog.InitialDirectory = drive + "\\";
            bool done = false;
            while (!done)
            {
                if (addVideoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!addVideoDialog.FileName.StartsWith(drive + "\\"))
                    {
                        if (MessageBox.Show("Videofail peab asuma mälupulgal", "Ei saa uut videot lisada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                        {
                            done = false;
                        }
                        else
                        {
                            done = true;
                        }
                        continue;
                    }
                    try
                    {
                        moveLegacy.Description = "Valige kaust kuhu teisalda video \"" + listBox5.SelectedItem.ToString() + "\"";
                        moveLegacy.SelectedPath = drive + "\\";
                        if (moveLegacy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            File.Move(addVideoDialog.FileName, drive + "\\Markuse_videod\\" + (listBox5.SelectedIndex + 1).ToString() + ". " + addVideoDialog.SafeFileName);
                            File.Move(drive + "\\Markuse_videod\\" + (listBox5.SelectedIndex + 1).ToString() + ". " + listBox5.SelectedItem.ToString(), moveLegacy.SelectedPath + "\\" + listBox5.SelectedItem.ToString());
                            listBox5.Items[listBox5.SelectedIndex] = addVideoDialog.SafeFileName;
                            MessageBox.Show("Video asendati edukalt. Kui soovite, et vanemad mälupulga tarkvara versioonid muudatusi näeksid, vajutage nupule \"Rakenda muudatused\".", "Video asendamine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            done = true;
                        }
                        else
                        {
                            MessageBox.Show("Ei saanud videot asendada. Põhjus: Te ei määranud kausta, kuhu eelmine video teisaldada.\r\n\r\nMuudatusi ei tehtud.", "Video asendamine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            done = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show(ex.Message + "\r\n\r\nVajutage \"Loobu\", et toiming katkestada\r\nVajutage \"Proovi uuesti\", et valida muu fail", "Ei saa uut videot asendada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                        {
                            done = false;
                        }
                        else
                        {
                            done = true;
                        }
                        continue;
                    }
                    done = true;
                }
                else
                {
                    done = true;
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.rc = new RichCreator();
            Program.rc.ShowDialog();
            this.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (File.Exists(drive + "\\E_INFO\\uudis6.rtf"))
            {
                if (MessageBox.Show("Enne uudise lisamist tuleb üks uudis arhiveerida. Kas soovite seda kohe teha?", "Uudise lisamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    string s = drive + "\\E_INFO\\arhiiv\\uudis" + DateTime.Now.DayOfYear + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".rtf";
                    File.Move(drive + "\\E_INFO\\uudis6.rtf", s);
                }
                else
                {
                    MessageBox.Show("Ei saanud uudist lisada.", "Uudise lisamine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            File.Move(drive + "\\E_INFO\\uudis5.rtf", drive + "\\E_INFO\\uudis6.rtf");
            File.Move(drive + "\\E_INFO\\uudis4.rtf", drive + "\\E_INFO\\uudis5.rtf");
            File.Move(drive + "\\E_INFO\\uudis3.rtf", drive + "\\E_INFO\\uudis4.rtf");
            File.Move(drive + "\\E_INFO\\uudis2.rtf", drive + "\\E_INFO\\uudis3.rtf");
            File.Move(drive + "\\E_INFO\\uudis1.rtf", drive + "\\E_INFO\\uudis2.rtf");

            //salvestab uue uudise
            //teisendab teksti baitideks, et vältida probleeme kasutuseloleva failiga
            string path = drive + "\\E_INFO\\uudis9.rtf";
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(rtb.Rtf);
                fs.Write(info, 0, info.Length);
             }
            rtb.Dispose();
            File.Move(drive + "\\E_INFO\\uudis9.rtf", drive + "\\E_INFO\\uudis1.rtf");

            //eemaldab ebavajaliku uudise mälust
            rtb = new RichTextBox();
            
            //annab kasutajale teada, et kõik õnnestus
            MessageBox.Show("Andmed salvestati edukalt. Programm värskendab nüüd andmeid...", "Arendamine", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //vajutab värskenda andmed nuppu
            button4.PerformClick();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //videofaili salvestamine
            File.WriteAllText(drive + "\\E_INFO\\videod.txt", listBox5.Items[0].ToString() + ";" + listBox5.Items[1].ToString() + ";" + listBox5.Items[2].ToString());

            //annab kasutajale teada, et kõik õnnestus
            MessageBox.Show("Andmed salvestati edukalt. Muudatused on nüüd nähtavad vanemates versioonides", "Arendamine", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TabButton_5_Click_1(object sender, EventArgs e)
        {
            TabCollection.SelectedIndex = 5;
            TabCollection.SwitchTab();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckIfConnected_Tick(object sender, EventArgs e)
        {
            label1.Visible = DataCollectTimer.Enabled;
            if (!Directory.Exists(drive + "\\"))
            {
                if (label20.Text == "pole ühendatud")
                {
                    CheckIfConnected.Enabled = false;
                    if (MessageBox.Show("Seade pole enam ühendatud. Kas soovite muu seadme valida?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        checkBox3.Checked = true;
                        button4.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Sisestage seade ja vajutage OK, et jätkata", "Mälupulka pole ühendatud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CheckIfConnected.Enabled = true;
                    }
                }
                label20.Text = "pole ühendatud";
            }
            else
            {
                if (clipboard == "")
                {
                    label20.Text = "ühendatud";
                }
                else
                {
                    label20.Text = "fail lõikelaual: " + clipboard;
                }
                this.Text = "Markuse mälupulk (" + drive + ")";
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Window2 w2 = new Window2();
            try
            {
                w2.pictureBox1.Image = Image.FromFile(this.drive + "\\markuse asjad\\Kiirrakendused\\" + this.listView2.SelectedItems[0].Text.ToString() + "\\" + this.listView2.SelectedItems[0].Text.ToString() + "ScreenShot.bmp");
            }
            catch
            {
                w2.pictureBox1.Image = this.pictureBox2.Image;
            }
            w2.Size = new Size(Convert.ToInt32(w2.pictureBox1.Image.PhysicalDimension.Width), Convert.ToInt32(w2.pictureBox1.Image.PhysicalDimension.Height));
            w2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            w2.ShowDialog();
            w2.Dispose();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Huer.Enabled = !Huer.Enabled;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
        }

        private void EditionColor_DoubleClick(object sender, EventArgs e)
        {
            Random r = new Random();
            EditionColor.BackColor = Color.FromArgb(r.Next(0, (int)byte.MaxValue), r.Next(0, (int)byte.MaxValue), r.Next(0, (int)byte.MaxValue));
        }

        private void addVideoDialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Vali videofail, mis eksisteerib mälupulgal, mida saaks kasutada uusima videona.", "Miks ma näen seda dialoogi?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Extras ex = new Extras();
            ex.BackColor = this.BackColor;
            ex.ForeColor = this.ForeColor;
            ex.Show();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            AddRemove();
        }

        void AddRemove()
        {
            AddApp aa = new AddApp();
            aa.BackColor = this.BackColor;
            aa.ForeColor = this.ForeColor;
            if (aa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listView2.Items.Clear();
                if (Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused"))
                {
                    appicons.Images.Clear();
                    foreach (string fi in Directory.GetDirectories(drive + "\\markuse asjad\\Kiirrakendused"))
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = fi.Replace(drive + "\\markuse asjad\\Kiirrakendused\\", "").ToString();
                        if (File.Exists(fi + "\\" + li.Text + "Portable.exe"))
                        {
                            try
                            {
                                this.appicons.Images.Add(Icon.ExtractAssociatedIcon(fi + "\\" + li.Text + "Portable.exe"));
                                li.ImageIndex = appicons.Images.Count - 1;
                            }
                            catch { }
                        }
                        listView2.Items.Add(li);
                    }
                }
            }
        }

        private void waitForComplete_Tick(object sender, EventArgs e)
        {
            if (Program.sts.Count == 6)
            {
                stats.Clear();
                for (int i = 0; i < Program.list.Count; i++)
                {
                    if (Program.list[i] == "markuse asjad")
                    {
                        stats.Add(Program.sts[i]);
                    }
                }
                for (int i = 0; i < Program.list.Count; i++)
                {
                    if (Program.list[i] == "multiboot")
                    {
                        stats.Add(Program.sts[i]);
                    }
                    else if (Program.list[i] == "sources")
                    {
                        stats.Add(Program.sts[i]);
                    }
                }
                for (int i = 0; i < Program.list.Count; i++)
                {
                    if (Program.list[i] == "Pakkfailid")
                    {
                        stats.Add(Program.sts[i]);
                    }
                }
                for (int i = 0; i < Program.list.Count; i++)
                {
                    if (Program.list[i] == "Kiirrakendused")
                    {
                        stats.Add(Program.sts[i]);
                    }
                }
                for (int i = 0; i < Program.list.Count; i++)
                {
                    if (Program.list[i] == "PlayStation mängud")
                    {
                        stats.Add(Program.sts[i]);
                    }
                }
                if (progressBar1.Value == 186)
                {
                    this.chart1.Series["Series1"].Points.AddXY((object)("Markuse asjad (" + Math.Round(this.stats[0] / 1024.0 / 1024.0 / 1024.0, 2).ToString().Replace(",", ".") + " GiB)"), (object)Convert.ToInt32(this.stats[0] / 1024.0 / 1024.0));
                    double num1 = this.stats[1] / 1024.0 / 1024.0 / 1024.0 + this.stats[2] / 1024.0 / 1024.0 / 1024.0;
                    this.chart1.Series["Series1"].Points.AddXY((object)("Operatsioonsüsteemid (" + Math.Round(num1, 2).ToString().Replace(",", ".") + " GiB)"), (object)Convert.ToInt32(num1 * 1024.0));
                    this.chart1.Series["Series1"].Points.AddXY((object)("Pakkfailid (" + Math.Round(this.stats[3] / 1024.0 / 1024.0 / 1024.0, 2).ToString().Replace(",", ".") + " GiB)"), (object)Convert.ToInt32(this.stats[3] / 1024.0 / 1024.0));
                    this.chart1.Series["Series1"].Points.AddXY((object)("Kiirrakendused (" + Math.Round(this.stats[4] / 1024.0 / 1024.0 / 1024.0, 2).ToString().Replace(",", ".") + " GiB)"), (object)Convert.ToInt32(this.stats[4] / 1024.0 / 1024.0));
                    this.chart1.Series["Series1"].Points.AddXY((object)("PS2 mängud (" + Math.Round(this.stats[5] / 1024.0 / 1024.0 / 1024.0, 2).ToString().Replace(",", ".") + " GiB)"), (object)Convert.ToInt32(this.stats[5] / 1024.0 / 1024.0));
                    this.label20.Text = "sektordiagrammi loomine...";
                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        if (drive.Name == this.drive + "\\")
                        {
                            double num2 = (double)((drive.TotalSize - drive.TotalFreeSpace) / 1024L / 1024L) - Convert.ToDouble(this.chart1.Series["Series1"].Points[0].YValues[0].ToString()) - Convert.ToDouble(this.chart1.Series["Series1"].Points[1].YValues[0].ToString()) - Convert.ToDouble(this.chart1.Series["Series1"].Points[2].YValues[0].ToString()) - Convert.ToDouble(this.chart1.Series["Series1"].Points[3].YValues[0].ToString()) - Math.Round(this.stats[5] / 1024.0 / 1024.0, 2);
                            this.chart1.Series["Series1"].Points.AddXY((object)("Muud failid (" + Math.Round(num2 / 1024.0, 2).ToString() + " GiB)"), (object)Convert.ToInt32(num2));
                            this.chart1.Series["Series1"].Points.AddXY((object)("Vaba ruum (" + Math.Round((double)drive.TotalFreeSpace / 1024.0 / 1024.0 / 1024.0, 2).ToString() + " GiB)"), (object)Convert.ToInt32((double)drive.TotalFreeSpace / 1024.0 / 1024.0));
                        }
                    }
                    label20.Text = "viimistlemine...";
                    TabButton_4.Enabled = true;

                }
                if (progressBar1.Value == 197)
                {
                    if (listBox5.Items.Count > 0) { listBox5.Items.Clear(); }
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        listBox5.Items.Add(listBox1.Items[i].ToString());
                    }
                }
                if (progressBar1.Value == 208)
                {
                    button25.Enabled = false;
                    button28.Enabled = true;
                }
                if (progressBar1.Value < 55)
                {
                    incremental++;
                }
                else if (progressBar1.Value > 245)
                {
                    incremental--;
                }
                if (progressBar1.Value + incremental > progressBar1.Maximum)
                {
                    progressBar1.Value = progressBar1.Maximum;
                    label1.Visible = false;
                    label20.Text = "ühendatud";
                    CheckIfConnected.Enabled = true;
                    checkBox3.Enabled = true;
                    waitForComplete.Enabled = false;
                    button4.Visible = true;
                    TabButton_6.Enabled = true;
                    progressBar1.Visible = false;
                    return;
                }
                progressBar1.Increment(incremental);
            }
        }


        public static string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = System.IO.Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = System.IO.Path.GetFileName(shortcutFilename);

            Shell shell = new Shell();
            Folder folder = shell.NameSpace(pathOnly);
            FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            OpenFile();
        }

        void OpenFile()
        {
            ListViewItem li = listView1.SelectedItems[0];
            if (li.Text == "..")
            {
                string newdir = "";
                for (int i = 0; i < current_dir.Split('\\').Length - 1; i++)
                {
                    if (i != current_dir.Split('\\').Length - 2)
                    {
                        newdir += current_dir.Split('\\')[i] + "\\";
                    }
                    else
                    {
                        newdir += current_dir.Split('\\')[i];
                    }
                }
                if (newdir != "")
                {
                    if (newdir.Contains("\\"))
                    {
                        current_dir = newdir;
                    }
                    else
                    {
                        current_dir = newdir + "\\";
                    }
                }
                SwitchDir();
                return;
            }
            else if (li.Text == ".")
            {
                Process.Start(current_dir);
                return;
            }
            if (li.ImageIndex == 0)
            {
                // uses folder icon, therefore it's a folder
                current_dir += "\\" + li.Text;
                SwitchDir();
            }
            else
            {
                // doesn't use folder icon, not a folder
                if (!li.Text.EndsWith(".lnk"))
                {
                    if (MessageBox.Show("Fail: " + li.Text + "\r\n"
                                    + "Asukoht: " + current_dir + "\r\n\r\n" +
                                    "Kas soovite seda faili avada?", "Faili avamine", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = current_dir + "\\" + li.Text;
                        p.StartInfo.WorkingDirectory = current_dir;
                        p.Start();
                    }
                }
                else
                {
                    string destination = drive + GetShortcutTargetFile(current_dir + "\\" + li.Text).Substring(2);
                    if (Directory.Exists(destination))
                    {
                        current_dir = destination;
                        SwitchDir();
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Otsetee asukoht: " + li.Text + "\r\n"
                                            + "Sihtfail: " + destination + "\r\n"
                                            + "Asukoht: " + current_dir + "\r\n\r\n" +
                                            "Kas soovite seda faili avada?", "Faili avamine", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Process p = new Process();
                                p.StartInfo.FileName = destination;
                                p.StartInfo.WorkingDirectory = current_dir;
                                p.Start();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Faili ei saanud avada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void button4_VisibleChanged(object sender, EventArgs e)
        {
            button19.Visible = button4.Visible;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listView2.SelectedItems.Count > 0))
            {
                label9.Text = "Kiirrakendused";
                label10.Text = "Kiirrakendused on nagu tavalised töölauarakendused, " +
                               "mida leiate enda arvutist, aga neil on eriline " + 
                               "funktsioon: need töötavad kohe igas arvutis otse mälupulgalt.";
                this.pictureBox2.Image = (Image)Resources.f22170384;
                this.loadedimage = (Image)null;
                return;
            }
            label9.Text = "See tekst ei peaks mitte kunagi nähtav olema";
            label10.Text = "(rakendusel puudub kirjeldus)";
            this.pictureBox2.Image = (Image)Resources.f22170384;
            if (!splitContainer2.Panel2Collapsed)
            {
                try
                {
                    this.loadedimage = Image.FromFile(this.drive + "\\markuse asjad\\Kiirrakendused\\" + this.listView2.SelectedItems[0].Text.ToString() + "\\" + this.listView2.SelectedItems[0].Text.ToString() + "ScreenShot.bmp");
                    Bitmap bitmap = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
                    Graphics graphics = Graphics.FromImage((Image)bitmap);
                    graphics.DrawImage(this.loadedimage, new Point(0, 0));
                    if (this.EnableGradient)
                    {
                        for (int y = 0; y < this.loadedimage.Height; ++y)
                        {
                            int alpha = 60;
                            for (int x = 0; x < 20; ++x)
                            {
                                Pen pen = new Pen(System.Drawing.Color.FromArgb(alpha, (int)this.BackColor.R, (int)this.BackColor.G, (int)this.BackColor.B), 1f);
                                graphics.DrawLine(pen, new Point(0, y), new Point(x, y));
                                graphics.DrawLine(pen, new Point(this.pictureBox2.Width, y), new Point(this.pictureBox2.Width - x, y));
                                alpha -= 3;
                                if (alpha < 0)
                                    alpha = 0;
                            }
                        }
                        for (int x = 0; x < this.loadedimage.Width; ++x)
                        {
                            int alpha = 60;
                            for (int y = 0; y < 20; ++y)
                            {
                                Pen pen = new Pen(System.Drawing.Color.FromArgb(alpha, (int)this.BackColor.R, (int)this.BackColor.G, (int)this.BackColor.B), 1f);
                                graphics.DrawLine(pen, new Point(x, 0), new Point(x, y));
                                graphics.DrawLine(pen, new Point(x, this.pictureBox2.Height), new Point(x, this.pictureBox2.Height - y));
                                alpha -= 3;
                                if (alpha < 0)
                                    alpha = 0;
                            }
                        }
                    }
                    this.pictureBox2.Image = (Image)bitmap;
                    label9.Text = listView2.SelectedItems[0].Text.ToString();
                    label10.Text = File.ReadAllText(drive + "\\markuse asjad\\Kiirrakendused\\" + listView2.SelectedItems[0].Text.ToString() + "\\" + listView2.SelectedItems[0].Text.ToString() + "Info.txt", Encoding.Unicode);
                }
                catch
                {
                }
            }
        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            OpenApp();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (e.Shift)
                {
                    TabCollection.SelectedIndex--;
                    if (TabCollection.SelectedIndex < 0)
                    {
                        TabCollection.SelectedIndex = 4;
                    }
                }
                else
                {
                    TabCollection.SelectedIndex++;
                    if (TabCollection.SelectedIndex > 4)
                    {
                        TabCollection.SelectedIndex = 0;
                    }
                }
                TabCollection.SwitchTab();
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            keys.Add(e.KeyCode);
            string sequence = "";
            foreach (Keys key in keys)
            {
                switch (key)
                {
                    case Keys.Up:
                        sequence += "u";
                        break;
                    case Keys.Left:
                        sequence += "l";
                        break;
                    case Keys.Down:
                        sequence += "d";
                        break;
                    case Keys.Right:
                        sequence += "r";
                        break;
                    case Keys.A:
                        sequence += "a";
                        break;
                    case Keys.B:
                        sequence += "b";
                        break;
                    case Keys.C:
                        sequence += "c";
                        break;
                }
            }
            if (sequence.Length > 12)
            {
                sequence = sequence.Substring(sequence.Length - 12);
                if (sequence.Contains("123abc"))
                {
                    this.Close();
                }
                if (sequence.Contains("uuddlrlrba"))
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel)
                        {
                            foreach (Control b in c.Controls)
                            {
                                if (b is FlowLayoutPanel || b is Panel || b is SplitContainer)
                                {
                                    b.Dispose();
                                }
                                if (b is ListBox || b is ListView)
                                {
                                    b.Dispose();
                                }
                            }
                        }
                    }
                    foreach (Control control1 in (ArrangedElementCollection)this.Controls)
                    {
                        if (control1 is Panel)
                        {
                            foreach (Control control2 in (ArrangedElementCollection)control1.Controls)
                            {
                                if (control2 is FlowLayoutPanel || control2 is Panel || control2 is SplitContainer)
                                    control2.Dispose();
                                if (control2 is Button || control2 is Label)
                                {
                                    control2.Text = "";
                                    control2.BackColor = System.Drawing.Color.Red;
                                }
                                else if (control2 is PictureBox)
                                    control2.BackgroundImage = (Image)null;
                                else if (control2 is ListBox || control2 is ListView)
                                    control2.Dispose();
                            }
                        }
                    }
                    keys.Clear();
                    DataCollectTimer.Enabled = true;
                }
            }
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            int i = new Random().Next(0, 9999);
            if (i == 777)
            {
                MessageBox.Show("Palju õnne, te võitsite pettumuse!");
            }
        }

        private void Huer_Tick(object sender, EventArgs e)
        {
            if (!progressBar1.Visible)
            {
                this.pictureBox3.Image = this.HueShift(this.pictureBox3.Image);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                id++;
            }
            ++this.id;
            switch (this.id)
            {
                case 1:
                    this.pictureBox3.Image = (Image)Resources.apps;
                    break;
                case 2:
                    this.pictureBox3.Image = (Image)Resources.batchpanel;
                    break;
                case 3:
                    this.pictureBox3.Image = (Image)Resources.br;
                    break;
                case 4:
                    this.pictureBox3.Image = (Image)Resources.cool_pattern;
                    break;
                case 5:
                    this.pictureBox3.Image = (Image)Resources.disc;
                    break;
                case 6:
                    this.pictureBox3.Image = (Image)Resources.disk;
                    break;
                case 7:
                    this.pictureBox3.Image = (Image)Resources.f22170384;
                    break;
                case 8:
                    this.pictureBox3.Image = (Image)Resources.folder;
                    break;
                case 9:
                    this.pictureBox3.Image = (Image)Resources.GeneralFile;
                    break;
                case 10:
                    this.pictureBox3.Image = (Image)Resources.hdd;
                    break;
                case 11:
                    this.pictureBox3.Image = (Image)Resources.help;
                    break;
                case 13:
                    this.pictureBox3.Image = (Image)Resources.mas_flash;
                    break;
                case 14:
                    this.pictureBox3.Image = (Image)Resources.noteicon;
                    break;
                case 16:
                    this.pictureBox3.Image = (Image)Resources.play;
                    break;
                case 18:
                    this.pictureBox3.Image = (Image)Resources.safemode;
                    break;
                case 19:
                    this.pictureBox3.Image = (Image)Resources.setting;
                    break;
                case 20:
                    this.id = 0;
                    this.pictureBox3.Image = (Image)Resources.uniprog;
                    break;
            }
        }




        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                try
                {
                    cryptoStream.FlushFinalBlock();
                    return ms.ToArray();
                }
                catch
                {
                    return data;
                }

            }
        }
        private void uusKaustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBox ib = new InputBox();
            ib.InputMsg.Text = "Andke kaustale nimi";
            if (ib.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Directory.CreateDirectory(current_dir + "\\" + ib.InputTxt.Text);
            }
            SwitchDir();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip1.BackColor = this.BackColor;
            this.contextMenuStrip1.ForeColor = this.ForeColor;
            tühjendaLõikelaudToolStripMenuItem.Visible = clipboard != "";
            kleebiToolStripMenuItem.Enabled = clipboard != "";
            avaToolStripMenuItem1.Enabled = (listView1.SelectedIndices.Count > 0);
        }

        private void attribuudidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1)
            {
                if (File.Exists(current_dir + "\\" + listView1.SelectedItems[0].Text))
                {
                    AttribProperties ap = new AttribProperties();
                    FileAttributes fa = File.GetAttributes(current_dir + "\\" + listView1.SelectedItems[0].Text);
                    ap.filenameBox.Text += listView1.SelectedItems[0].Text;
                    ap.BackColor = this.BackColor;
                    ap.ForeColor = this.ForeColor;
                    ap.filesizeBox.Text += GetSizeString(new FileInfo(current_dir + "\\" + listView1.SelectedItems[0].Text).Length);
                    ap.ShowDialog();
                }
            }
        }

        private string GetSizeString(long filesize)
        {
            if (filesize <= 1000L)
                return filesize.ToString() + " B";
            if (filesize <= 1000000L)
                return Math.Round((double)filesize / 1000.0, 2).ToString() + " kB";
            if (filesize <= 1000000000L)
                return Math.Round((double)filesize / 1000000.0, 2).ToString() + " MB";
            if (filesize <= 1000000000000L)
                return Math.Round((double)filesize / 1000000000.0, 2).ToString() + " GB";
            if (filesize <= 1000000000000000L)
                return Math.Round((double)filesize / 1000000000000.0, 2).ToString() + " TB";
            return filesize > 1000000000000000000L ? Math.Round((double)filesize / 1E+15, 2).ToString() + " EB" : Math.Round((double)filesize / 1E+15, 2).ToString() + " PB";
        }

        private void lõikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                clipboard = current_dir + "\\" + listView1.SelectedItems[0].Text;
                copy = false;
            }
            else
            {
                clipboard = current_dir;
                copy = false;
            }
        }

        private void kopeeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                clipboard = current_dir + "\\" + listView1.SelectedItems[0].Text;
                copy = true;
            }
            else
            {
                clipboard = current_dir;
                copy = true;
            }
        }

        private void tühjendaLõikelaudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboard = "";
        }

        private void kleebiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(clipboard))
            {
                filenames = Directory.GetFiles(clipboard, "*.*", SearchOption.AllDirectories);
                // copied item is a folder
                if (listView1.SelectedIndices.Count == 0)
                {
                    outfile = current_dir;
                }
                else
                {
                    if (Directory.Exists(current_dir + "\\" + listView1.SelectedItems[0].Text))
                    {
                        outfile = current_dir + "\\" + listView1.SelectedItems[0].Text;
                    }
                    else
                    {
                        outfile = current_dir;
                    }
                }
                Thread t = new Thread(new ThreadStart(CopyFiles));
                t.Start();
                CopyProgress.Enabled = true;
                CheckIfConnected.Enabled = false;
                progressBar1.Visible = true;
                progressBar1.Maximum = filenames.Length;
                progressBar1.Value = 0;
                Tab_1.Enabled = false;
                if (!Program.simulation)
                {
                    label1.Text = "Ärge eemaldage mälupulka arvutist!";
                }
                else
                {
                    label1.Text = "// Simulatsioon //";
                }
                label1.Visible = true;
            }
            else if (File.Exists(clipboard))
            {
                // copied item is a file
                if (copy)
                {
                    File.Copy(clipboard, current_dir + "\\" + new FileInfo(clipboard).Name);
                }
                else
                {
                    File.Move(clipboard, current_dir + "\\" + new FileInfo(clipboard).Name);
                }
                SwitchDir();
            }
        }

        void CopyFiles()
        {
            foreach (string file in filenames)
            {
                progress++;
                current_file = file;
                FileInfo fi = new FileInfo(current_file);
                string required_dir = "";
                try
                {
                    required_dir = fi.DirectoryName.Replace(clipboard, outfile);
                    if (!Program.simulation)
                    {
                        if (!Directory.Exists(required_dir))
                        {
                            Directory.CreateDirectory(required_dir);
                        }
                        if (copy)
                        {
                            File.Copy(file, required_dir + "\\" + fi.Name, true);
                        }
                        else
                        {
                            File.Move(file, required_dir + "\\" + fi.Name);
                        }
                    }
                    else
                    {
                        Thread.Sleep(10);
                    }
                }
                catch { }
            }
        }

        private void CopyProgress_Tick(object sender, EventArgs e)
        {
            button4.Enabled = (progress < progressBar1.Maximum);
            if (progress < progressBar1.Maximum)
            {
                progressBar1.Value = progress;
                string task = "";
                if (copy)
                {
                    task = "kopeerimine";
                }
                else
                {
                    task = "teisaldamine";
                }
                label20.Text = "Faili \"" + new FileInfo(current_file).Name + "\" " + task + "...";
            }
            else
            {
                CopyProgress.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                Tab_1.Enabled = true;
                clipboard = "";
                label20.Text = "valmis";
                filenames = null;
                CheckIfConnected.Enabled = true;
                if (!Program.simulation)
                {
                    SwitchDir();
                }
                label1.Text = "Andmete kogumise ajal saate juba laaditud funktsioone kasutada";
                label1.Visible = false;
            }
        }

        private void laadiUuestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchDir();
        }


        void DelFile(string FileName)
        {
            if (!Program.simulation)
            {
                File.Delete(FileName);
            }
            else
            {
                Thread.Sleep(5000);
            }
            fqa = true;
            Thread.CurrentThread.Abort();
        }

        void DelTree(string FolderName)
        {
            if (!Program.simulation)
            {
                Directory.Delete(FolderName, true);
            }
            else
            {
                Thread.Sleep(10000);
            }
            fqa = true;
            Thread.CurrentThread.Abort();
        }

        private void kustutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("See toiming kustutab valitud üksuse jäädavalt. Kas olete kindel, et soovite jätkata?", "Failisüsteemi üksuse kustutamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (listView1.SelectedIndices.Count > 0)
                {
                    if (File.Exists(current_dir + "\\" + listView1.SelectedItems[0].Text))
                    {
                        Tab_1.Enabled = false;
                        fqa = false;
                        CheckIfConnected.Enabled = false;
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.Visible = true;
                        label20.Text = "faili kustutamine... (\"" + listView1.SelectedItems[0].Text + "\")";
                        checkfqa.Enabled = true;
                        string s = current_dir + "\\" + listView1.SelectedItems[0].Text;
                        new Thread(() => DelFile(s)).Start();
                    }
                    else if (Directory.Exists(current_dir + "\\" + listView1.SelectedItems[0].Text))
                    {
                        Tab_1.Enabled = false;
                        fqa = false;
                        CheckIfConnected.Enabled = false;
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.Visible = true;
                        label20.Text = "kausta kustutamine... (\"" + listView1.SelectedItems[0].Text + "\")";
                        checkfqa.Enabled = true;
                        string s = current_dir + "\\" + listView1.SelectedItems[0].Text;
                        new Thread(() => DelTree(s)).Start();
                    }
                }
                else
                {
                    Tab_1.Enabled = false;
                    fqa = false;
                    CheckIfConnected.Enabled = false;
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    progressBar1.Visible = true;
                    label20.Text = "kausta kustutamine... (\"" + current_dir+ "\")";
                    checkfqa.Enabled = true;
                    new Thread(() => DelTree(current_dir)).Start();
                }
                if (!Program.simulation)
                {
                    label1.Text = "Ärge eemaldage mälupulka arvutist!";
                }
                else
                {
                    label1.Text = "// Simulatsioon //";
                }
                label1.Visible = true;
            }
        }

        void MakeShortcut(string location, string target, string workingdirectory, string description = "", string iconpath = "", string args = "")
        {
            IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(location) as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = args;
            shortcut.TargetPath = target;
            // not sure about what this is for
            shortcut.WindowStyle = 1;
            shortcut.Description = description;
            shortcut.WorkingDirectory = workingdirectory;
            shortcut.IconLocation = iconpath;
            shortcut.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputBox ib = new InputBox();
            ib.InputMsg.Text = "Sisestage uue kasutaja nimi";
            if (ib.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                new Thread(() => MakeUsers(ib.InputTxt.Text)).Start();
                progressBar1.Visible = true;
                button5.Enabled = false;
                CheckIfConnected.Enabled = false;
                label1.Text = ib.InputTxt.Text;
                label20.Text = "kasutaja loomine";
                progressBar1.Style = ProgressBarStyle.Marquee;
                checkfqa.Enabled = true;
            }
        }

        void MakeUsers(string usrname)
        {
            string usr_root = drive + "\\markuse asjad\\markuse asjad\\" + usrname + "\\";
            Directory.CreateDirectory(drive + "\\markuse asjad\\markuse asjad\\" + usrname + "\\");
            SetFolderIcon(usr_root, @"%SystemRoot%\system32\SHELL32.dll,160");
            MakeShortcut(usr_root + "Tagasi.lnk", drive + "\\markuse asjad\\markuse asjad\\", usr_root, "Tagasi eelmisesse kausta", @"%SystemRoot%\System32\Shell32.dll, 146");
            MakeShortcut(usr_root + "Mine.lnk", drive + "\\markuse asjad\\markuse asjad\\Mine", usr_root, "Mine muusse kausta", @"%SystemRoot%\System32\imageres.dll, 95");
            IDictionary<string, string> folders = new Dictionary<string, string>()
                {
                    {"Abi", @"%SystemRoot%\System32\SHELL32.dll,23"},
                    {"Minu videod", @"%SystemRoot%\system32\imageres.dll,-189"},
                    {"Muud asjad", @"%SystemRoot%\system32\SHELL32.dll,28"}, 
                    {"Muusika", @"%SystemRoot%\system32\SHELL32.dll,168"},
                    {"Paigaldatavad failid", @"%SystemRoot%\system32\SHELL32.dll,212"},
                    {"Pildid", @"%SystemRoot%\system32\SHELL32.dll,195"},
                    {"PowerPoint", @"%ProgramFiles%\Microsoft Office\Office14\POWERPNT.EXE,1"},
                    {"Tekst", @"%SystemRoot%\system32\SHELL32.dll,20"},
                    {"Word", @"%ProgramFiles%\Microsoft Office\Office14\WINWORD.EXE,1"}
                };
            foreach (KeyValuePair<string, string> folder in folders)
            {
                Directory.CreateDirectory(usr_root + folder.Key);
                SetFolderIcon(usr_root + folder.Key, folder.Value);
                MakeShortcut(usr_root + folder.Key + "\\Tagasi.lnk", usr_root, usr_root + folder.Key, "Tagasi eelmisesse kausta", @"%SystemRoot%\System32\Shell32.dll, 146");
                MakeShortcut(usr_root + folder.Key + "\\Mine.lnk", drive + "\\markuse asjad\\markuse asjad\\Mine", usr_root + folder.Key, "Mine muusse kausta", @"%SystemRoot%\System32\imageres.dll, 95");
            }
            MakeShortcut(drive + "\\markuse asjad\\markuse asjad\\Mine\\" + usrname + ".lnk", usr_root, drive + "\\markuse asjad\\markuse asjad\\Mine", "Kasutaja kaust", @"%SystemRoot%\system32\SHELL32.dll,160");
            fqa = true;
        }

        void WriteLegacyUsers()
        {
            string s = "";
            foreach (string i in listBox2.Items)
            {
                s += i + ";";
            }
            s = s.Substring(0, s.Length - 1);
            listView1.Items.Clear();
            listView1.Visible = false;
            File.WriteAllText(drive + "\\markuse asjad\\markuse asjad\\kasutajad.txt", s, Encoding.UTF8);
        }

        void SetFolderIcon(string path, string icon)
        {

            FileInfo fileInfo = new FileInfo(path + "\\desktop.ini");
            FileAttributes fa = fileInfo.Attributes;
            FileStream fs = fileInfo.OpenWrite();
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[.ShellClassInfo]");
            sw.WriteLine("IconResource=" + icon);
            sw.Flush();
            sw.Close();
            fs.Close();
            fileInfo.Attributes = FileAttributes.Hidden | FileAttributes.Archive | FileAttributes.System;
            RefreshIconCache();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas olete kindel, et soovite kasutaja \"" + listBox2.SelectedItem.ToString() + "\" kausta ja kõik muud andmed?", "Kasutaja kustutamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Directory.Delete(drive + "\\markuse asjad\\markuse asjad\\" + listBox2.SelectedItem.ToString(), true);
                string golnk = drive + "\\markuse asjad\\markuse asjad\\Mine\\" + listBox2.SelectedItem.ToString() + ".lnk";
                if (File.Exists(golnk)) { File.Delete(golnk); }
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                WriteLegacyUsers();
                MessageBox.Show("Kasutaja ja kõik andmed on kustutatud", "Kasutaja kustutaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr SendMessageTimeout(
            int windowHandle,
            int Msg,
            int wParam,
            String lParam,
            SendMessageTimeoutFlags flags,
            int timeout,
            out int result);
        [Flags]
        enum SendMessageTimeoutFlags : uint
        {
            SMTO_NORMAL = 0x0,
            SMTO_BLOCK = 0x1,
            SMTO_ABORTIFHUNG = 0x2,
            SMTO_NOTIMEOUTIFNOTHUNG = 0x8
        }

        static void RefreshIconCache()
        {
            // get the the original Shell Icon Size registry string value
            RegistryKey k = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("WindowMetrics", true);
            Object OriginalIconSize = k.GetValue("Shell Icon Size");
            // set the Shell Icon Size registry string value
            k.SetValue("Shell Icon Size", (Convert.ToInt32(OriginalIconSize) + 1).ToString());

            k.Flush(); k.Close();

            // broadcast WM_SETTINGCHANGE to all window handles

            int res = 0;
            SendMessageTimeout(0xffff, 0x001A, 0, "", SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5000, out res);

            //SendMessageTimeout(HWD_BROADCAST,WM_SETTINGCHANGE,0,"",SMTO_ABORTIFHUNG,5 seconds, return result to res)
            // set the Shell Icon Size registry string value to original value
            k = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Desktop").OpenSubKey("WindowMetrics", true);
            k.SetValue("Shell Icon Size", OriginalIconSize);
            k.Flush(); k.Close();
            SendMessageTimeout(0xffff, 0x001A, 0, "", SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5000, out res);
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip2.BackColor = this.BackColor;
            this.contextMenuStrip2.ForeColor = this.ForeColor;
            avaToolStripMenuItem.Enabled = (listView2.SelectedIndices.Count > 0);
            eemaldaToolStripMenuItem.Enabled = (listView2.SelectedIndices.Count > 0);
        }

        private void kuvaÜksikasjadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !kuvaÜksikasjadToolStripMenuItem.Checked;
        }

        private void lisaEemaldaKiirrakendusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRemove();
        }

        private void eemaldaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteApp();
        }

        private void avaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenApp();
        }

        private void avaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(drive + "\\NTFS")) { Directory.CreateDirectory(drive + "\\NTFS"); }
            }
            catch
            {
                MessageBox.Show("Juurdepääs asukohale \"" + drive + "\\NTFS\" puudub. Kas seade on ühendatud?", "Ei saa PIN koodi muuta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Parool p = new Parool();
            if (File.Exists(drive + "\\NTFS\\spin.sys"))
            {
                if (current_pin != File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString())
                {
                    p.Text = "Kinnitamiseks sisestage vana PIN kood";
                    p.currentpin = "";
                    p.ShowDialog();
                    string s = File.ReadAllLines(drive + "\\NTFS\\spin.sys", Encoding.ASCII)[0].ToString();

                    byte[] correct = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(p.currentpin));
                    string cstr = "";
                    foreach (byte b in correct)
                    {
                        cstr += b.ToString("X2");
                    }
                    if (cstr != s)
                    {
                        MessageBox.Show("Vale PIN kood", "Toiming katkestati", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        button31.Visible = true;
                    }
                }
            }
            p.Text = "Sisestage uus PIN kood";
            p.currentpin = "";
            p.ShowDialog();
            try
            {
                byte[] correct = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(p.currentpin));
                string cstr = "";
                foreach (byte b in correct)
                {
                    cstr += b.ToString("X2");
                }
                File.WriteAllText(drive + "\\NTFS\\spin.sys", cstr + "\n", Encoding.ASCII);
                MessageBox.Show("Uus PIN kood salvestati edukalt", "Toiming õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PIN koodi salvestamine nurjus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void waitForQAppThread_Tick(object sender, EventArgs e)
        {
            if (fqa)
            {
                label20.Text = "kohalike seadistuste lugemine...";
                waitForQAppThread.Enabled = false;
                TabButton_2.Enabled = true;
                this.appicons.Images.AddRange(this.aicon.Images.Cast<Image>().ToArray<Image>());
                int n = 0;
                foreach (string lvi in prg)
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems[0].Text = lvi;
                    li.ImageIndex = n;
                    listView2.Items.Add(li);
                    n++;
                }
                aicon.Images.Clear();
                DataCollectTimer.Enabled = true;
                fqa = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void EditionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<string> features = new List<string>();
            if (File.Exists(drive + "\\E_INFO\\edition.txt")) { features.Add("Integratsioon Markuse arvutiga"); };
            if (File.Exists(drive + "\\E_INFO\\uudis1.rtf")) { features.Add("Uudised ja lisainfo mälupulga kohta"); };
            if (File.Exists(drive + "\\E_INFO\\videod.txt") && Directory.Exists(drive + "\\Markuse_videod")) { features.Add("Uusimad videod"); };
            if (File.Exists(drive + "\\NTFS\\spin.sys")) { features.Add("Turvalise PIN koodi tugi"); };
            if (File.Exists(drive + "\\NTFS\\config.sys")) { features.Add("Ebaturvalise PIN koodi tugi"); };
            if (Directory.Exists(drive + "\\Batch") || Directory.Exists(drive + "\\Pakkfailid")) { features.Add("Pakkfailid"); };
            if (Directory.Exists(drive + "\\markuse asjad\\markuse asjad")) { features.Add("Markuse kaustad"); };
            if (Directory.Exists(drive + "\\markuse asjad\\Kiirrakendused")) { features.Add("Kiirrakendused"); };
            if (Directory.Exists(drive + "\\multiboot")) { features.Add("Operatsioonsüsteemide käivitamine mälupulgalt"); };
            if (File.Exists(drive + "\\CD\\games.bin") || File.Exists(drive + "\\DVD\\games.bin")) { features.Add("PS2 mängude laadimine mälupulgalt"); };
            if (File.Exists(drive + "\\POPS\\POPSTARTER.ELF") && File.Exists(drive + "\\POPS\\POPS_IOX.PAK")) { features.Add("PS1 mängude laadimine mälupulgalt"); };
            if (File.Exists(drive + "\\autorun.inf") && File.Exists(drive + "\\mas_flash.ico")) { features.Add("Kohandatud ikoon ja pikk draivi nimi"); };
            if (File.Exists(drive + "\\autorun.inf") && !File.Exists(drive + "\\mas_flash.ico")) { features.Add("Pikk draivi nimi"); };
            if (File.Exists(drive + "\\markuse asjad\\markuse asjad\\kasutajad.txt") && File.Exists(drive + "\\E_INFO\\videod.txt")) { features.Add("Ühilduvus varasemate mälupulga programmidega"); };
            if (File.Exists(drive + "\\NTFS\\config.sys") && (new DriveInfo(drive).DriveType == DriveType.Removable)) { features.Add("Mälupulga lahtilukustuse tugi"); };
            if ((EditionLabel.Text.Contains("Ultimate") || EditionLabel.Text.Contains("Premium")) && (File.Exists(drive + "\\E_INFO\\convert.bat"))) { features.Add("Väljaande muutmine"); }
            string featurestr = "";
            foreach (string feature in features)
            {
                featurestr += " - " + feature + "\n";
            }
            MessageBox.Show(EditionLabel.Text + "\n" + "See väljanne sisaldab järgmisi funktsioone:" + "\n" + featurestr, "Täpsem info väljaande kohta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("See funktsioon võimaldab lisada viimase uudise arhiveeritud uudiste kausta. Kas soovite jätkata?", "Uudise arhiveerimine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (File.Exists(drive + "\\E_INFO\\uudis6.rtf"))
                {
                    File.Move(drive + "\\E_INFO\\uudis6.rtf", drive + "\\E_INFO\\arhiiv\\uudis" + DateTime.Now.DayOfYear + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".rtf");
                }
                else
                {
                    MessageBox.Show("Ei leitud uudiseid, mida oleks vaja arhiveerida.", "Uudise arhiveerimine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button29_Click_2(object sender, EventArgs e)
        {
            NewsArchive na = new NewsArchive();
            na.drive = this.drive;
            na.newsList.Items.AddRange(new DirectoryInfo(drive + "\\E_INFO\\arhiiv").GetFiles());
            na.ShowDialog();
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if ((!Program.simulation) && (MessageBox.Show("See funktsioon on loodud peamiselt testimiseks. Simulatsioonirežiim mõjutab ainult järgmisi situatsioone:\n - Andmete kogumine\n - Varukoopiate varundamine ja taaste\nKas soovite jätkata?", "Simulatsioonirežiimist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes))
            {
                checkBox4.Checked = Program.simulation;
                return;
            }
            Program.simulation = checkBox4.Checked;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            current_pin = "";
            button31.Visible = false;
        }

        private void checkfqa_Tick(object sender, EventArgs e)
        {
            if (fqa)
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Visible = false;
                checkfqa.Enabled = false;
                label1.Visible = false;
                CheckIfConnected.Enabled = true;
                Tab_1.Enabled = true;
                if (label20.Text == "kasutaja loomine")
                {
                    MessageBox.Show("Kasutaja loodi edukalt", "Uue kasutaja lisamine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox2.Items.Add(label1.Text);
                    WriteLegacyUsers();
                    button5.Enabled = true;
                }
                else
                {
                    SwitchDir();
                }
                label20.Text = "valmis";
                label1.Text = "Andmete kogumise ajal saate juba laaditud funktsioone kasutada";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar1.Visible)
            {
                e.Cancel = true;
                MessageBox.Show("Mälupulk on hõivatud. Palun oodake kuni praegune toiming viiakse lõpule.", "Markuse mälupulk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/k taskkill /f /im \"Markuse mälupulk.exe\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();
                p.StartInfo.Arguments = "/k taskkill /f /im \"Markuse mälupulk.vshost.exe\"";
                p.Start();
                e.Cancel = false;
            }
        }

        private void listView1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.Action == DragAction.Drop)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData("FileNameW");
            foreach (string d in data)
            {
                if (Directory.Exists(d))
                {
                    current_dir += "\\" + new DirectoryInfo(d).Name;
                    outfile = current_dir;
                    if (!Program.simulation)
                    {
                        if (!Directory.Exists(outfile)) { Directory.CreateDirectory(outfile); }
                    }
                    filenames = Directory.GetFiles(d, "*.*", SearchOption.AllDirectories);
                    clipboard = d;
                    Thread t = new Thread(new ThreadStart(CopyFiles));
                    t.Start();
                    CopyProgress.Enabled = true;
                    CheckIfConnected.Enabled = false;
                    progressBar1.Visible = true;
                    progressBar1.Maximum = filenames.Length;
                    progressBar1.Value = 0;
                    copy = true;
                    Tab_1.Enabled = false;
                    if (!Program.simulation)
                    {
                        label1.Text = "Ärge eemaldage mälupulka arvutist!";
                    }
                    else
                    {
                        label1.Text = "// Simulatsioon //";
                    }
                    label1.Visible = true;
                }
                else if (File.Exists(d))
                {
                    File.Copy(d, current_dir + "\\" + new FileInfo(d).Name);
                }
            }
            SwitchDir();
        }

        private void allvideosbutton_Click(object sender, EventArgs e)
        {
            allvids = true;
            TabButton_1.PerformClick();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            EditDoc(1);
        }

        void EditDoc(int id)
        {
            RichCreator rc = new RichCreator();
            if (File.Exists(string.Format(@"{0}\E_INFO\uudis{1}.rtf", drive, id)))
            {
                try
                {
                    rc.richTextBox1.LoadFile(string.Format(@"{0}\E_INFO\uudis{1}.rtf", drive, id), RichTextBoxStreamType.RichText);
                }
                catch { }
            }
            rc.ShowDialog();
            rc.Show();
            rc.richTextBox1.SaveFile(string.Format(@"{0}\E_INFO\uudis{1}.rtf", drive, id), RichTextBoxStreamType.RichText);
            rc.Hide();
            rc.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            EditDoc(2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            EditDoc(3);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            EditDoc(4);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            EditDoc(5);
        }

        private void Tab_1_VisibleChanged(object sender, EventArgs e)
        {
            if (allvids)
            {
                allvids = false;
                if (listBox2.Items.Count > 0)
                {
                    listBox2.SelectedIndex = 0;
                    listBox3.SelectedIndex = 1;
                }
            }
        }
    }
}
