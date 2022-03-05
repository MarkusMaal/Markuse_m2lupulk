using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Markuse_mälupulk
{
    public partial class AddApp : Form
    {
        public bool finished = false;
        string app = "";
        public AddApp()
        {
            InitializeComponent();
        }

        void CopyFolderFiles()
        {
            DirectoryCopy(folderBrowserDialog1.SelectedPath, Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + folderBrowserDialog1.SelectedPath.Split('\\')[folderBrowserDialog1.SelectedPath.Split('\\').Length - 1], true);
            finished = true;
            Thread.CurrentThread.Abort();
        }


        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                try
                {
                    file.CopyTo(tempPath, false);
                }
                catch { }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (finished)
            {
                timer1.Enabled = false;
                Page1.Visible = false;
                Page2.Visible = true;
                AllocateFolders();
            }
        }

        void AllocateFolders()
        {
            listBox1.Items.Clear();
            foreach (DirectoryInfo di in new DirectoryInfo(Program.f1.drive + "\\markuse asjad\\Kiirrakendused").GetDirectories())
            {
                listBox1.Items.Add(di.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (radioButton1.Checked)
            {
                Page1.Visible = false;
                Page2.Visible = true;
                AllocateFolders();
            }
            if (radioButton2.Checked && folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                progressBar1.Visible = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                label1.Text = "Failide kopeerimine, palun oota...";
                timer1.Enabled = true;
                Thread t = new Thread(new ThreadStart(CopyFolderFiles));
                t.Start();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = (listBox1.SelectedIndices.Count > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.app = this.listBox1.SelectedItem.ToString();
            this.label4.Text = "Rakenduse nimi: " + this.app;
            if (File.Exists(Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + this.app + "\\" + this.app + "Portable.exe"))
                this.label5.Text = "Käivitatav programm: " + this.app + "Portable.exe";
            else
                this.label5.Text = "Käivitatav programm pole määratud";
            try
            {
                this.textBox1.Text = File.ReadAllText(Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + this.app + "\\" + this.app + "Info.txt", Encoding.Unicode);
            }
            catch
            {
            }
            try
            {
                this.pictureBox1.Image = Image.FromFile(Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + this.app + "\\" + this.app + "ScreenShot.bmp");
            }
            catch
            {
            }
            this.Page2.Visible = false;
            this.Page3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                this.pictureBox1.Image.Dispose();
            }
            catch
            {
            }
            File.Copy(this.openFileDialog1.FileName, Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + this.app + "\\" + this.app + "ScreenShot.bmp", true);
            this.pictureBox1.Image = Image.FromFile(Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + this.app + "\\" + this.app + "ScreenShot.bmp");

        }

        private void Page3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    File.Copy(openFileDialog2.FileName, Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + app + "\\" + app + "Portable.exe", true);
                    label5.Text = "Käivitatav programm: " + app + "Portable.exe";
                }
                catch
                {

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Program.f1.drive + "\\markuse asjad\\Kiirrakendused\\" + app + "\\" + app + "Info.txt", textBox1.Text, Encoding.Unicode);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
