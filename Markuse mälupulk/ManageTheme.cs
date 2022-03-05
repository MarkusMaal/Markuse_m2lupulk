using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Markuse_mälupulk
{

    public partial class ManageTheme : Form
    {
        private string[] alused = new string[5]
        {
          "Mari",
          "Tõnu",
          "Pingviin",
          "Karu",
          "Koer"
        };
        private string[] öeldised = new string[5]
        {
          "vaatas",
          "murdis",
          "väsitas",
          "kardab",
          "kuulas"
        };
        private string[] sihitised = new string[5]
        {
          "akent",
          "pesa",
          "inimesi",
          "liblikaid",
          "võõraid"
        };
        public ManageTheme()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.BackColor;
            if (this.colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            this.BackColor = this.colorDialog1.Color;
            Program.f1.Applytheme(this.colorDialog1.Color, this.ForeColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.ForeColor;
            if (this.colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            this.ForeColor = this.colorDialog1.Color;
            Program.f1.Applytheme(this.BackColor, this.colorDialog1.Color);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Program.f1.pictureBox4.BackgroundImage.Dispose();
            Program.f1.pictureBox4.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.f1.LoadTheme();
            this.BackColor = Program.f1.BackColor;
            this.ForeColor = Program.f1.ForeColor;
        }

        private void ManageTheme_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + "\\mas\\scheme.cfg"))
                this.button4.Enabled = false;
            this.checkBox1.Checked = Program.f1.EnableGradient;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.f1.EnableGradient = this.checkBox1.Checked;
            Program.f1.Applytheme(this.BackColor, this.ForeColor);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            string str1 = "" + this.alused[new Random().Next(0, this.alused.Length - 1)] + " ";
            Thread.Sleep(20);
            string str2 = str1 + this.öeldised[new Random().Next(0, this.öeldised.Length - 1)] + " ";
            Thread.Sleep(20);
            this.label1.Text = str2 + this.sihitised[new Random().Next(0, this.sihitised.Length - 1)] + ".";
        }
    }
}
