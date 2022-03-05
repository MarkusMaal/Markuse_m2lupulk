using System;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class Parool : Form
    {
        public string currentpin = "";
        public Parool()
        {
            InitializeComponent();
        }


        private void Parool_Load(object sender, EventArgs e)
        {
            this.BackColor = Program.f1.BackColor;
            this.ForeColor = Program.f1.ForeColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.f1.TabButton_6.Visible = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        void LabelUpdate()
        {
            label2.Text = "";
            for (int i = 0; i < currentpin.Length; i++)
            {
                label2.Text += "*";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            currentpin += "1";
            LabelUpdate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentpin += "2";
            LabelUpdate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentpin += "3";
            LabelUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentpin += "4";
            LabelUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentpin += "5";
            LabelUpdate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentpin += "6";
            LabelUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentpin += "7";
            LabelUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentpin += "8";
            LabelUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentpin += "9";
            LabelUpdate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentpin += "0";
            LabelUpdate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (currentpin.Length > 0)
            { 
                currentpin = currentpin.Substring(0, currentpin.Length - 1);
            }
            LabelUpdate();
        }

        void KeyCheck(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                button12.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button11.PerformClick();
            }
        }

        private void Parool_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button11_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button10_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button12_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            KeyCheck(e);
        }

        private void Parool_Shown(object sender, EventArgs e)
        {
            LabelUpdate();
        }
    }
}
