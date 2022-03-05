using System;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.BackColor = Program.f1.BackColor;
            this.ForeColor = Program.f1.ForeColor;
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            InputTxt.Text = "";
        }
    }
}
