
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    partial class ManageTheme
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
            this.label1 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.colorDialog1 = new ColorDialog();
            this.button3 = new Button();
            this.button4 = new Button();
            this.openFileDialog1 = new OpenFileDialog();
            this.checkBox1 = new CheckBox();
            this.toolTip1 = new ToolTip(this.components);
            this.SuspendLayout();
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)186);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(270, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teema";
            this.label1.TextAlign = ContentAlignment.TopCenter;
            this.label1.DoubleClick += new EventHandler(this.label1_DoubleClick);
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(16, 45);
            this.button1.Name = "button1";
            this.button1.Size = new Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Muuda tagaplaani värvi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.ForeColor = SystemColors.ControlText;
            this.button2.Location = new Point(152, 45);
            this.button2.Name = "button2";
            this.button2.Size = new Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Muuda esiplaani värvi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button3.ForeColor = SystemColors.ControlText;
            this.button3.Location = new Point(16, 74);
            this.button3.Name = "button3";
            this.button3.Size = new Size(130, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Muuda taustapilti";
            this.toolTip1.SetToolTip((Control)this.button3, "Võimaldab muuta päises olevat pilti.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.ForeColor = SystemColors.ControlText;
            this.button4.Location = new Point(152, 74);
            this.button4.Name = "button4";
            this.button4.Size = new Size(130, 22);
            this.button4.TabIndex = 4;
            this.button4.Text = "Laadi teema";
            this.toolTip1.SetToolTip((Control)this.button4, "Laadib teema Markuse arvutis olevast skeemifailist");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.openFileDialog1.Filter = "Pildifailid|*.png;*.jpg;*.jpe;*.jpeg;*.bmp;*.gif;*.tif;*.tiff;*.wmf";
            this.checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox1.Location = new Point(16, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(140, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Kasuta üleminekuefekte";
            this.toolTip1.SetToolTip((Control)this.checkBox1, "Kuvab erilise efekti programmi päises ja kiirrakenduste eelvaadetes. Kui te ei soovi seda efekti või teie arvuti on aeglane saate selle funktsiooni välja lülitada.");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(298, 140);
            this.Controls.Add((Control)this.checkBox1);
            this.Controls.Add((Control)this.button4);
            this.Controls.Add((Control)this.button3);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "ManageTheme";
            this.ShowInTaskbar = false;
            this.Load += new EventHandler(this.ManageTheme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label label1;
        private Button button1;
        private Button button2;
        private ColorDialog colorDialog1;
        private Button button3;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        #endregion
    }
}