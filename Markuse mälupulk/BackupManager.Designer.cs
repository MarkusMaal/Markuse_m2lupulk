using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Markuse_mälupulk.Properties;

namespace Markuse_mälupulk
{
    partial class BackupManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupManager));
            this.backups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.otherLocation = new System.Windows.Forms.Button();
            this.fileObj = new System.Windows.Forms.Button();
            this.newBackup = new System.Windows.Forms.Button();
            this.restoreNow = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.waitForLoad = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.waitforpopulate = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backups
            // 
            this.backups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.backups.FormattingEnabled = true;
            this.backups.ItemHeight = 20;
            this.backups.Location = new System.Drawing.Point(15, 142);
            this.backups.Name = "backups";
            this.backups.Size = new System.Drawing.Size(546, 160);
            this.backups.TabIndex = 0;
            this.backups.SelectedIndexChanged += new System.EventHandler(this.backups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mälupulk: \r\nVarukoopiate asukoht: ";
            this.label1.Visible = false;
            // 
            // openFolder
            // 
            this.openFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openFolder.Location = new System.Drawing.Point(15, 307);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(95, 23);
            this.openFolder.TabIndex = 1;
            this.openFolder.Text = "Ava asukohas";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Visible = false;
            this.openFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // otherLocation
            // 
            this.otherLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otherLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.otherLocation.Location = new System.Drawing.Point(116, 307);
            this.otherLocation.Name = "otherLocation";
            this.otherLocation.Size = new System.Drawing.Size(90, 23);
            this.otherLocation.TabIndex = 2;
            this.otherLocation.Text = "Sõltuvused";
            this.otherLocation.UseVisualStyleBackColor = true;
            this.otherLocation.Visible = false;
            this.otherLocation.Click += new System.EventHandler(this.otherLocation_Click);
            // 
            // fileObj
            // 
            this.fileObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileObj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fileObj.Location = new System.Drawing.Point(212, 307);
            this.fileObj.Name = "fileObj";
            this.fileObj.Size = new System.Drawing.Size(90, 23);
            this.fileObj.TabIndex = 3;
            this.fileObj.Text = "Kõik failid";
            this.fileObj.UseVisualStyleBackColor = true;
            this.fileObj.Visible = false;
            this.fileObj.Click += new System.EventHandler(this.fileObj_Click);
            // 
            // newBackup
            // 
            this.newBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newBackup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newBackup.Location = new System.Drawing.Point(537, 307);
            this.newBackup.Name = "newBackup";
            this.newBackup.Size = new System.Drawing.Size(24, 23);
            this.newBackup.TabIndex = 7;
            this.newBackup.Text = "+";
            this.toolTip1.SetToolTip(this.newBackup, "Uus varundus");
            this.newBackup.UseVisualStyleBackColor = true;
            this.newBackup.Click += new System.EventHandler(this.newBackup_Click);
            // 
            // restoreNow
            // 
            this.restoreNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.restoreNow.Location = new System.Drawing.Point(447, 307);
            this.restoreNow.Name = "restoreNow";
            this.restoreNow.Size = new System.Drawing.Size(54, 23);
            this.restoreNow.TabIndex = 5;
            this.restoreNow.Text = "Taasta";
            this.restoreNow.UseVisualStyleBackColor = true;
            this.restoreNow.Visible = false;
            this.restoreNow.Click += new System.EventHandler(this.restoreNow_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Location = new System.Drawing.Point(507, 307);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(24, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "-";
            this.toolTip1.SetToolTip(this.deleteButton, "Kustuta valitud varukoopia");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // waitForLoad
            // 
            this.waitForLoad.Interval = 50;
            this.waitForLoad.Tick += new System.EventHandler(this.waitForLoad_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(466, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Laadi uuesti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.renameButton.Location = new System.Drawing.Point(308, 307);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(90, 23);
            this.renameButton.TabIndex = 4;
            this.renameButton.Text = "Muuda nime";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Visible = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(15, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Juuruta varukoopia teisele seadmele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Markuse_mälupulk.Properties.Resources.br;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(130, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Varukoopiate avastamine...";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(134, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            // 
            // waitforpopulate
            // 
            this.waitforpopulate.Tick += new System.EventHandler(this.waitforpopulate_Tick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(537, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 14;
            this.button3.TabStop = false;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.restoreNow);
            this.Controls.Add(this.newBackup);
            this.Controls.Add(this.fileObj);
            this.Controls.Add(this.otherLocation);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.backups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 374);
            this.Name = "BackupManager";
            this.Text = "Varukoopiate sünkroniseerimine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox backups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button otherLocation;
        private System.Windows.Forms.Button fileObj;
        private System.Windows.Forms.Button newBackup;
        private System.Windows.Forms.Button restoreNow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer waitForLoad;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer waitforpopulate;
        private System.Windows.Forms.Button button3;
    }
}