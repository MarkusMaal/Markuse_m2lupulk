using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Markuse_mälupulk
{
    public partial class Dependencies : Form
    {
        public string[] depends;
        public Backup backupname;
        public Backup[] bclasses;
        public Dependencies()
        {
            InitializeComponent();
        }

        private void Dependencies_Load(object sender, EventArgs e)
        {
            foreach (string l in depends)
            {
                if (l != null)
                {
                    listBox1.Items.Add(l);
                }
            }
            this.listBox1.BackColor = this.BackColor;
            this.listBox1.ForeColor = this.ForeColor;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 0)
            {
                if (File.Exists(backupname.Locate() + listBox1.SelectedItem.ToString().Replace("/", "\\")))
                {
                    Process.Start("explorer", "/select," + backupname.Locate() + listBox1.SelectedItem.ToString().Replace("/", "\\"));
                }
                else if (Directory.Exists(backupname.Locate() + listBox1.SelectedItem.ToString().Replace("/", "\\")))
                {
                    Process.Start("explorer", backupname.Locate() + listBox1.SelectedItem.ToString().Replace("/", "\\"));
                }
            }
        }
    }
}
