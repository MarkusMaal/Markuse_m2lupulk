using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Markuse_mälupulk
{
    public partial class RichCreator : Form
    {
        public RichCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, FontStyle.Bold);

        private void button2_Click(object sender, EventArgs e) => this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, FontStyle.Italic);

        private void button3_Click(object sender, EventArgs e) => this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, FontStyle.Underline);

        private void button4_Click(object sender, EventArgs e) => this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, FontStyle.Strikeout);

        private void button14_Click(object sender, EventArgs e) => this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, FontStyle.Regular);

        private void button5_Click(object sender, EventArgs e) => this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        private void button6_Click(object sender, EventArgs e) => this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        private void button7_Click(object sender, EventArgs e) => this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionIndent > 50)
                return;
            this.richTextBox1.SelectionIndent += 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionIndent < 10)
                return;
            this.richTextBox1.SelectionIndent -= 10;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionBullet)
                this.richTextBox1.SelectionBullet = false;
            else
                this.richTextBox1.SelectionBullet = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.richTextBox1.SelectionColor;
            if (this.colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Clipboard.SetImage(Image.FromFile(this.openFileDialog1.FileName));
            this.richTextBox1.Paste();
            Clipboard.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.f1.rtb = this.richTextBox1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RichCreator_Load(object sender, EventArgs e)
        {
            this.BackColor = Program.f1.BackColor;
            this.ForeColor = Program.f1.ForeColor;
            foreach (Control control in (ArrangedElementCollection)this.flowLayoutPanel1.Controls)
            {
                control.BackColor = SystemColors.Control;
                control.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
