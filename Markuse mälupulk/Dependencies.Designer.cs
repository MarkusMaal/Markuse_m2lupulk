using System.Drawing;
using System.Windows.Forms;
using System;

namespace Markuse_mälupulk
{
    partial class Dependencies
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
            this.listBox1 = new ListBox();
            this.SuspendLayout();
            this.listBox1.BorderStyle = BorderStyle.None;
            this.listBox1.Dock = DockStyle.Fill;
            this.listBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)186);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(580, 370);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new EventHandler(this.listBox1_DoubleClick);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(580, 370);
            this.Controls.Add((Control)this.listBox1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new Size(107, 60);
            this.Name = "Dependencies";
            this.ShowInTaskbar = false;
            this.Text = "Sõltuvused";
            this.Load += new EventHandler(this.Dependencies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}