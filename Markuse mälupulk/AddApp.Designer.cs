using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    partial class AddApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApp));
            this.label1 = new Label();
            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.Page1 = new Panel();
            this.button2 = new Button();
            this.progressBar1 = new ProgressBar();
            this.Page2 = new Panel();
            this.button1 = new Button();
            this.listBox1 = new ListBox();
            this.label2 = new Label();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Page3 = new Panel();
            this.label7 = new Label();
            this.pictureBox1 = new PictureBox();
            this.textBox1 = new TextBox();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.button3 = new Button();
            this.openFileDialog1 = new OpenFileDialog();
            this.button4 = new Button();
            this.openFileDialog2 = new OpenFileDialog();
            this.button5 = new Button();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            this.Page3.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new Size((int)sbyte.MaxValue, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rakenduse paigaldamine";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new Point(6, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(165, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rakendus on juba mälupulgal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(6, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(210, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Rakendus tuleb mälupulgale teisaldada";
            this.Page1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Page1.Controls.Add((Control)this.button2);
            this.Page1.Controls.Add((Control)this.progressBar1);
            this.Page1.Controls.Add((Control)this.label1);
            this.Page1.Controls.Add((Control)this.radioButton2);
            this.Page1.Controls.Add((Control)this.radioButton1);
            this.Page1.Location = new Point(2, 4);
            this.Page1.Name = "Page1";
            this.Page1.Size = new Size(433, 286);
            this.Page1.TabIndex = 3;
            this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button2.ForeColor = SystemColors.ControlText;
            this.button2.Location = new Point(344, 239);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edasi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.progressBar1.Location = new Point(6, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(424, 13);
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            this.Page2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Page2.Controls.Add((Control)this.button1);
            this.Page2.Controls.Add((Control)this.listBox1);
            this.Page2.Controls.Add((Control)this.label2);
            this.Page2.Location = new Point(5, 1);
            this.Page2.Name = "Page2";
            this.Page2.Size = new Size(430, 286);
            this.Page2.TabIndex = 4;
            this.Page2.Visible = false;
            this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button1.Enabled = false;
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(341, 244);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jätka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new Point(10, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(406, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valige kiirrakendus:";
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.Page3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Page3.Controls.Add((Control)this.button5);
            this.Page3.Controls.Add((Control)this.button4);
            this.Page3.Controls.Add((Control)this.button3);
            this.Page3.Controls.Add((Control)this.label7);
            this.Page3.Controls.Add((Control)this.pictureBox1);
            this.Page3.Controls.Add((Control)this.textBox1);
            this.Page3.Controls.Add((Control)this.label6);
            this.Page3.Controls.Add((Control)this.label5);
            this.Page3.Controls.Add((Control)this.label4);
            this.Page3.Controls.Add((Control)this.label3);
            this.Page3.Location = new Point(2, 4);
            this.Page3.Name = "Page3";
            this.Page3.Size = new Size(433, 286);
            this.Page3.TabIndex = 5;
            this.Page3.Visible = false;
            this.Page3.Paint += new PaintEventHandler(this.Page3_Paint);
            this.label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.Transparent;
            this.label7.Location = new Point(252, 99);
            this.label7.Name = "label7";
            this.label7.Size = new Size(64, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kuvatõmmis";
            this.pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pictureBox1.Location = new Point((int)byte.MaxValue, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(175, 156);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.textBox1.Location = new Point(14, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(235, 156);
            this.textBox1.TabIndex = 5;
            this.label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.Transparent;
            this.label6.Location = new Point(11, 99);
            this.label6.Name = "label6";
            this.label6.Size = new Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kirjeldus";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new Size(159, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Käivitatav programm: <asukoht>";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new Size(119, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rakenduse nimi: <nimi>";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metaandmete muutmine";
            this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.button3.ForeColor = SystemColors.ControlText;
            this.button3.Location = new Point(322, 94);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Muuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.openFileDialog1.Filter = "Bitirasteri formaadis kujutised|*.bmp";
            this.button4.ForeColor = SystemColors.ControlText;
            this.button4.Location = new Point(13, 73);
            this.button4.Name = "button4";
            this.button4.Size = new Size(58, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "Määra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.openFileDialog2.Filter = "Käivitatav Windowsi programm|*.exe;*.EXE";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.ForeColor = SystemColors.ControlText;
            this.button5.Location = new Point(355, 6);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Valmis";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(433, 291);
            this.Controls.Add((Control)this.Page1);
            this.Controls.Add((Control)this.Page2);
            this.Controls.Add((Control)this.Page3);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new Size(416, 330);
            this.Name = "AddApp";
            this.ShowIcon = false;
            this.Text = "Kiirrakenduse lisamine";
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            this.Page3.ResumeLayout(false);
            this.Page3.PerformLayout();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel Page1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Page2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Page3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button5;
    }
}