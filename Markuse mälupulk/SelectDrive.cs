using System;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class SelectDrive : Form
    {
        internal string FinalLetter = "C:";
        internal Point firstlocation;
        internal Form parent;
        public SelectDrive()
        {
            InitializeComponent();
        }

        private void SelectDrive_Load(object sender, EventArgs e)
        {
            button2.Visible = Program.f1.Visible;
            listView1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = listView1.SelectedIndices.Count > 0;
        }

        private void SelectDrive_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                FinalLetter = listView1.SelectedItems[0].SubItems[0].Text;
            }
            e.Cancel = false;
        }

        private void SelectDrive_LocationChanged(object sender, EventArgs e) => this.parent.Location = new Point(this.Location.X - this.parent.Width / 5, this.Location.Y - this.parent.Height / 3);

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
