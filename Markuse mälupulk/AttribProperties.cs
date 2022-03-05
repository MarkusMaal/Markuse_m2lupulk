using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Markuse_mälupulk
{
    public partial class AttribProperties : Form
    {
        public AttribProperties()
        {
            InitializeComponent();
        }

        private void AttribProperties_Load(object sender, EventArgs e)
        {
            string keyName;
            try
            {
                keyName = Registry.ClassesRoot.OpenSubKey("." + filenameBox.Text.Split('.')[filenameBox.Text.Split('.').Length - 1]).GetValue(null).ToString();
            }
            catch
            {
                keyName = filenameBox.Text.Split('.')[filenameBox.Text.Split('.').Length - 1].ToUpper() + " fail";
            }
            filetypeBox.Text += keyName;
        }
    }
}
