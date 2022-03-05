using System;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            delay1.Enabled = true;
        }

        private void delay1_Tick(object sender, EventArgs e)
        {
            waitForInteraction.Enabled = this.Visible;
            if (Program.f1 == null)
            {
                Program.f1 = new Form1();
                Program.f1.WindowState = FormWindowState.Minimized;
                Program.f1.Show();
            }
            else if (!Program.f1.progressBar1.Visible)
            {
                delay1.Enabled = false;
                Program.f1.WindowState = FormWindowState.Normal;
                this.Hide();
            }
            else
            {
                progressBar1.Visible = true;
                label2.Visible = false;
                ptext.Text = Program.f1.label20.Text;
                ptext.Visible = true;
                progressBar1.Style = ProgressBarStyle.Continuous;
                int p = Program.f1.progressBar1.Value + 40;
                if (p > 300) {p = 300;}
                progressBar1.Value = p;
                if (System.IO.File.Exists(Program.f1.drive + "\\E_INFO\\edition.txt"))
                {
                    string edition = System.IO.File.ReadAllLines(Program.f1.drive + "\\E_INFO\\edition.txt")[0];
                }
            }
        }

        private void waitForInteraction_Tick(object sender, EventArgs e)
        {
            Program.f1.WindowState = FormWindowState.Normal;
            waitForInteraction.Enabled = false;
            delay1.Enabled = false;
            this.Hide();
        }
    }
}
