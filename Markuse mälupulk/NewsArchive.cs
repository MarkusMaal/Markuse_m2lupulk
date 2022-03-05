using System;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    public partial class NewsArchive : Form
    {
        internal string drive = "A:";
        public NewsArchive()
        {
            InitializeComponent();
        }

        private void NewsArchive_Load(object sender, EventArgs e)
        {
            if (newsList.Items.Count > 0)
            {
                newsList.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Arhiveeritud uudiseid pole", "Arhiveeritud uudised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(drive + "\\E_INFO\\arhiiv\\" + newsList.Items[newsList.SelectedIndex].ToString());
        }
    }
}
