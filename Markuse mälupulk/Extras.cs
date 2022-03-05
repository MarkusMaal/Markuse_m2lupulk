using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using Markuse_mälupulk.Properties;

namespace Markuse_mälupulk
{
    public partial class Extras : Form
    {
        internal Color edition = Color.Gray;
        public Extras()
        {
            InitializeComponent();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Lisainfo funktsiooni kohta";
            label3.Text = "Lisanduv info teatud funktsiooni kohta ilmub siia," +
                          "kui viite kursori kindla nupu peale.";
            this.pictureBox1.Image = (Image)Resources.f22170384;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.BackgroundImage = (Image)null;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Mälupulga pakkfail";
            label3.Text = "Väga vana mälupulga haldamise programm, mille põhifunktsiooniks on " +
                          "uudiste lugemine ja uute videote vaatamine.";
            this.pictureBox1.Image = (Image)Resources.batchpanel;
            this.pictureBox1.BackColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Turvarežiim";
            label3.Text = "Käivitab mälupulga haldamise programmi minimaalses režiimis ainult " +
                          "uudiste lugemiseks. Programmi käivitamiseks turvarežiimis ilma tavarežiimita" +
                          "kasutage käivitamisel argumenti --safemode";
            this.pictureBox1.Image = (Image)Resources.safemode;
            this.pictureBox1.BackColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Mälupulga universaalprogramm";
            label3.Text = "Vanem programm mälupulga haldamiseks, mis oli ühtlasi ka mälupulga " +
                          "juhtpaneeli eelkäijaks. Mõned inimesed võivad eelisata selle programmi " +
                          "liidest rohkem. Seetõttu lisasin ta siia lisafunktsioonide alla.";
            this.pictureBox1.Image = (Image)Resources.uniprog;
            this.pictureBox1.BackColor = this.edition;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageTheme manageTheme = new ManageTheme();
            manageTheme.BackColor = this.BackColor;
            manageTheme.ForeColor = this.ForeColor;
            this.Hide();
            int num = (int)manageTheme.ShowDialog();
            this.Close();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox1.BackgroundImage = (Image)Resources.cool_pattern;
            this.pictureBox1.Image = (Image)null;
            this.pictureBox1.BackColor = edition;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Tile;
            label2.Text = "Teemade haldamine";
            label3.Text = "Juhul kui käivitasite selle programmi Markuse arvutis, saate teemat käsitsi kohandada " + 
                          "Markuse arvuti juhtpaneelis. See valik on mõeldud olukordadeks, kus seda programmi ei " +
                          "kasutata Markuse arvutis.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Hide();
            SafeMode sm = new SafeMode();
            sm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas soovite sünkroonida juhtpaneeli andmed Markuse asjade pakkfailiga?", "Markuse asjade pakkfail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string Password = new Random().Next(0, 21482572).ToString();
                MessageBox.Show("Parool haldamiseks: " + Password + "\n\nPidage meeles, et selle parooliga mõjutate ainult seda, mis toimub pakkfailis ja mitte teistes mälupulga programmides.", "Markuse asjad pakkfail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RichTextBox rtb = new RichTextBox();
                List<string> pealkirjad = new List<string>();
                List<string> uudised = new List<string>();
                List<string> videod = new List<string>();
                for (int i = 1; i <= 5; i++)
                {
                    rtb.LoadFile(Program.f1.drive + "\\E_INFO\\uudis" + i.ToString() + ".rtf");
                    string lines = rtb.Text;
                    pealkirjad.Add(ToSuitableBatchString(lines.Split('\n')[0].Replace("\r", "")));
                    uudised.Add(ToSuitableBatchString(lines.Replace(lines.Split('\n')[0], "").Replace("\r\n", "").Replace("\n", "")));
                }
                try
                {
                    foreach (FileInfo fi in new DirectoryInfo(Program.f1.drive + "\\Markuse_videod").GetFiles())
                    {
                        string file = fi.Name;
                        videod.Add(ToSuitableBatchString(file.Split('.')[1].Substring(1) + "." + file.Split('.')[2]));
                    }
                } catch { }
                string settings = "";
                settings += "SET rightpass=" + Password + "\r\n";
                int j = 0;
                foreach (string pealkiri in pealkirjad)
                {
                    j++;
                    settings += "SET uudis" + j.ToString() + "=" + pealkiri + "\r\n";
                }
                j = 0;
                foreach (string uudis in uudised)
                {
                    j++;
                    settings += "SET u" + j.ToString() + "=" + uudis + "\r\n";
                }
                j = 0;
                foreach (string video in videod)
                {
                    j++;
                    settings += "SET video" + j.ToString() + "=" + video + "\r\n";
                }
                settings += "SET selectedcol=07\r\n";
                settings += "SET adapp=\r\n";
                settings += "SET adpp=\r\n";
                settings += "SET ads=n\r\n";
                settings += "SET adtext=\r\n";
                if (File.Exists(Program.f1.drive + "\\E_INFO\\Markuse asjad.bat"))
                {
                    File.Delete(Program.f1.drive + "\\E_INFO\\Markuse asjad.bat");
                }
                if (File.Exists(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd"))
                {
                    File.Delete(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd");
                }
                File.WriteAllText(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd", settings, Encoding.GetEncoding("windows-1252"));
                File.SetAttributes(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd", FileAttributes.Hidden);
                MessageBox.Show("Andmed sünkroniseeriti. Vajutage OK, et pakkfail käivitada\r\n\r\nSalafunktsioonide klahvid (vajuta enne käivitusanimatsiooni):\r\n" +
                                "M - arendaja režiim\r\n" +
                                "a - vanema pakkfaili liidese režiim\r\n" +
                                "r - pakkfaili seadete nullimine\r\n" +
                                "k - kiirlaadimine\r\n" +
                                "u - käsurida, kirjutage \"exit\", et jätkata pakkfaili käivitamist\r\n" +
                                "s - pakkfaili turvarežiim (ära laadi uusimaid videosid\r\n" +
                                "e - katkesta pakkfaili käivitamine\r\n" +
                                "n - käivita tavarežiimis, valitakse 1 sek jooksul automaatselt", "Markuse asjade pakkfail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (File.Exists(Program.f1.drive + "\\E_INFO\\Markuse asjad.bat"))
                {
                    File.Delete(Program.f1.drive + "\\E_INFO\\Markuse asjad.bat");
                }
                if (File.Exists(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd"))
                {
                    File.Delete(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd");
                }
                try
                {
                    File.SetAttributes(Program.f1.drive + "\\E_INFO\\markuse_asjade_seaded.cmd", FileAttributes.Hidden);
                } catch { }
            }
            Process p = new Process();
            p.StartInfo.FileName = Program.f1.drive + "\\E_INFO\\Markuse asjad.bat";
            p.StartInfo.Arguments = Program.f1.drive;
            try
            {
                p.Start();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ToSuitableBatchString(string s)
        {
            return s.Replace("ä", "„").Replace("õ", "ä").Replace("ö", "”").Replace("ü", "").Replace("ž", "Ų").Replace("\"", "'").Replace("%", "%%").Replace("|", "^|").Replace("<", "^<").Replace(">", "^>");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("See toiming sulgeb mälupulga juhtpaneeli. Kas olete kindel, et soovite jätkata?", "Mälupulga universaalprogramm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\running.log"))
                {
                    if (MessageBox.Show("Markuse mälupulga universaalprogramm on juba avatud. Vajutage \"Proovi uuesti\", et universaalprogramm sunniviisiliselt käivitada või \"Loobu\", et toiming katkestada", "Mälupulga universaalprogramm", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Retry)
                    {
                        File.Delete(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\running.log");
                    }
                    else
                    {
                        return;
                    }
                }
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = Program.f1.drive + "\\E_INFO\\universaalprogramm.exe";
                    p.Start();
                    Program.f1.Close();
                }
                catch
                {
                    MessageBox.Show("Faili kirjutamine nurjus. Mälupulga univesaalprogrammi ei saanud käivitada", "Mälupulga universaalprogramm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Extras_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Program.f1.drive + "\\multiboot") && Directory.Exists(Program.f1.drive + "\\markuse asjad"))
                this.edition = Color.BlueViolet;
            else if (Directory.Exists(Program.f1.drive + "\\multiboot"))
                this.edition = Color.DarkRed;
            else
                this.edition = Color.Green;
        }
    }

}
