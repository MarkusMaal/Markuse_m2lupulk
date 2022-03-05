using System.Drawing;
using System.Windows.Forms;
using System;

namespace Markuse_mälupulk
{
    partial class NewsArchive
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
            this.newsList = new ListBox();
            this.richTextBox1 = new RichTextBox();
            this.splitContainer1 = new SplitContainer();
            this.splitContainer1.BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            this.newsList.Dock = DockStyle.Fill;
            this.newsList.FormattingEnabled = true;
            this.newsList.Location = new Point(0, 0);
            this.newsList.Name = "newsList";
            this.newsList.Size = new Size(114, 323);
            this.newsList.TabIndex = 0;
            this.newsList.SelectedIndexChanged += new EventHandler(this.newsList_SelectedIndexChanged);
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.Location = new Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(395, 323);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add((Control)this.newsList);
            this.splitContainer1.Panel2.Controls.Add((Control)this.richTextBox1);
            this.splitContainer1.Size = new Size(513, 323);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 2;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(513, 323);
            this.Controls.Add((Control)this.splitContainer1);
            this.Name = "NewsArchive";
            this.ShowIcon = false;
            this.Text = "Uudiste arhiiv";
            this.Load += new EventHandler(this.NewsArchive_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ListBox newsList;
    }
}