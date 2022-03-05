using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Markuse_mälupulk
{
    partial class AttribProperties
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
            this.filenameBox = new System.Windows.Forms.Label();
            this.filetypeBox = new System.Windows.Forms.Label();
            this.filesizeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filenameBox
            // 
            this.filenameBox.AutoSize = true;
            this.filenameBox.Location = new System.Drawing.Point(94, 25);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(33, 13);
            this.filenameBox.TabIndex = 2;
            this.filenameBox.Text = "Nimi: ";
            // 
            // filetypeBox
            // 
            this.filetypeBox.AutoSize = true;
            this.filetypeBox.Location = new System.Drawing.Point(94, 40);
            this.filetypeBox.Name = "filetypeBox";
            this.filetypeBox.Size = new System.Drawing.Size(38, 13);
            this.filetypeBox.TabIndex = 3;
            this.filetypeBox.Text = "Tüüp: ";
            // 
            // filesizeBox
            // 
            this.filesizeBox.AutoSize = true;
            this.filesizeBox.Location = new System.Drawing.Point(94, 56);
            this.filesizeBox.Name = "filesizeBox";
            this.filesizeBox.Size = new System.Drawing.Size(37, 13);
            this.filesizeBox.TabIndex = 4;
            this.filesizeBox.Text = "Maht: ";
            // 
            // AttribProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 103);
            this.Controls.Add(this.filesizeBox);
            this.Controls.Add(this.filetypeBox);
            this.Controls.Add(this.filenameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AttribProperties";
            this.ShowInTaskbar = false;
            this.Text = "Attribuudid";
            this.Load += new System.EventHandler(this.AttribProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label filenameBox;
        internal System.Windows.Forms.Label filetypeBox;
        internal System.Windows.Forms.Label filesizeBox;
    }
}