using System;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class Backupname : Form
    {
        public Backupname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backuplabel.Text == "")
            {
                flashTimer.Enabled = true;
                return;
            }
            string strRegex = "\\<>:\"|?*";
            foreach (char c in strRegex.ToCharArray())
            {
                if (backuplabel.Text.Contains(c.ToString()))
                {
                    flashTimer.Enabled = true;
                    return;
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void flashTimer_Tick(object sender, EventArgs e) => this.backuplabel.ForeColor = SystemColors.WindowText;

        private void backuplabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK.PerformClick();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void Backupname_Load(object sender, EventArgs e)
        {
            backuplabel.SelectAll();
        }

        private void Backupname_FormClosing(object sender, FormClosingEventArgs e)
        {
            //backuplabel.Text = "markuse mälupulk";
        }

        private void backuplabel_TextChanged(object sender, EventArgs e)
        {
            if ((backuplabel.Text.Contains("(")) ||
                (backuplabel.Text.Contains(")")) ||
                (backuplabel.Text.Contains("|")) ||
                (backuplabel.Text.Contains("\\")) ||
                (backuplabel.Text.Contains("/")) ||
                (backuplabel.Text.Contains(":")) ||
                (backuplabel.Text.Contains("*")) ||
                (backuplabel.Text.Contains("?")) ||
                (backuplabel.Text.Contains("\"")) ||
                (backuplabel.Text.Contains("<")) ||
                (backuplabel.Text.Contains(">")))
            {
                int bck = backuplabel.SelectionStart;
                backuplabel.Text = backuplabel.Text.Replace("(", "");
                backuplabel.Text = backuplabel.Text.Replace(")", "");
                backuplabel.Text = backuplabel.Text.Replace("|", "");
                backuplabel.Text = backuplabel.Text.Replace("\\", "");
                backuplabel.Text = backuplabel.Text.Replace("/", "");
                backuplabel.Text = backuplabel.Text.Replace(":", "");
                backuplabel.Text = backuplabel.Text.Replace("*", "");
                backuplabel.Text = backuplabel.Text.Replace("?", "");
                backuplabel.Text = backuplabel.Text.Replace("\"", "");
                backuplabel.Text = backuplabel.Text.Replace("<", "");
                backuplabel.Text = backuplabel.Text.Replace(">", "");
                toolTip1.Show("Varukoopia nimi ei saa olla ükski järgnevatest tähemärkidest:\n" +
                              "         \\ / : * ? \" < > | ( )", this);
                backuplabel.SelectionStart = bck - 1;
                backuplabel.SelectionLength = 0;
            }
            else
            {
                toolTip1.Hide(this);
            }
        }
    }
}
