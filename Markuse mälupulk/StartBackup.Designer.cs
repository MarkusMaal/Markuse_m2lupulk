using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    partial class StartBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartBackup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.waitasecond = new System.Windows.Forms.Timer(this.components);
            this.folderCreator = new System.Windows.Forms.Timer(this.components);
            this.eachCount = new System.Windows.Forms.Timer(this.components);
            this.copyFiles = new System.Windows.Forms.Timer(this.components);
            this.flashBuffer = new System.Windows.Forms.Label();
            this.flashWrite = new System.Windows.Forms.Label();
            this.flashRead = new System.Windows.Forms.Label();
            this.hardBuffer = new System.Windows.Forms.Label();
            this.hardWrite = new System.Windows.Forms.Label();
            this.hardRead = new System.Windows.Forms.Label();
            this.spaceUsage = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flashBufferCounter = new System.Diagnostics.PerformanceCounter();
            this.driveWriteCounter = new System.Diagnostics.PerformanceCounter();
            this.driveReadCounter = new System.Diagnostics.PerformanceCounter();
            this.flashWriteCounter = new System.Diagnostics.PerformanceCounter();
            this.flashReadCounter = new System.Diagnostics.PerformanceCounter();
            this.statFinder = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flashBufferCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveWriteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveReadCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashWriteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashReadCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varukoopia loomine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mälupulga asukoht: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varukoopia sihtkaust: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 106);
            this.progressBar1.MarqueeAnimationSpeed = 86;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 377);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 30);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Leia kõik failid ja kaustad mälupulgalt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.TabStop = false;
            this.checkBox2.Text = "Loo kaustad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 72);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(266, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.TabStop = false;
            this.checkBox4.Text = "Kopeeri failid, mis on erinevad või mida ei eksisteeri";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(260, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.TabStop = false;
            this.checkBox3.Text = "Leia failid, mis juba eksisteerivad, salvesta loetellu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 120);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 23);
            this.label4.TabIndex = 12;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // waitasecond
            // 
            this.waitasecond.Interval = 1000;
            this.waitasecond.Tick += new System.EventHandler(this.waitasecond_Tick);
            // 
            // folderCreator
            // 
            this.folderCreator.Interval = 15;
            this.folderCreator.Tick += new System.EventHandler(this.folderCreator_Tick);
            // 
            // eachCount
            // 
            this.eachCount.Tick += new System.EventHandler(this.eachCount_Tick);
            // 
            // copyFiles
            // 
            this.copyFiles.Interval = 10;
            this.copyFiles.Tick += new System.EventHandler(this.copyFiles_Tick);
            // 
            // flashBuffer
            // 
            this.flashBuffer.BackColor = System.Drawing.Color.Olive;
            this.flashBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashBuffer.ForeColor = System.Drawing.Color.White;
            this.flashBuffer.Location = new System.Drawing.Point(54, 74);
            this.flashBuffer.Name = "flashBuffer";
            this.flashBuffer.Size = new System.Drawing.Size(8, 8);
            this.flashBuffer.TabIndex = 25;
            this.flashBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashWrite
            // 
            this.flashWrite.BackColor = System.Drawing.Color.DarkRed;
            this.flashWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashWrite.ForeColor = System.Drawing.Color.White;
            this.flashWrite.Location = new System.Drawing.Point(36, 74);
            this.flashWrite.Name = "flashWrite";
            this.flashWrite.Size = new System.Drawing.Size(8, 8);
            this.flashWrite.TabIndex = 24;
            this.flashWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashRead
            // 
            this.flashRead.BackColor = System.Drawing.Color.DarkGreen;
            this.flashRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashRead.ForeColor = System.Drawing.Color.White;
            this.flashRead.Location = new System.Drawing.Point(18, 74);
            this.flashRead.Name = "flashRead";
            this.flashRead.Size = new System.Drawing.Size(8, 8);
            this.flashRead.TabIndex = 23;
            this.flashRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardBuffer
            // 
            this.hardBuffer.BackColor = System.Drawing.Color.Olive;
            this.hardBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardBuffer.ForeColor = System.Drawing.Color.White;
            this.hardBuffer.Location = new System.Drawing.Point(54, 56);
            this.hardBuffer.Name = "hardBuffer";
            this.hardBuffer.Size = new System.Drawing.Size(8, 8);
            this.hardBuffer.TabIndex = 22;
            this.hardBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardWrite
            // 
            this.hardWrite.BackColor = System.Drawing.Color.DarkRed;
            this.hardWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardWrite.ForeColor = System.Drawing.Color.White;
            this.hardWrite.Location = new System.Drawing.Point(36, 56);
            this.hardWrite.Name = "hardWrite";
            this.hardWrite.Size = new System.Drawing.Size(8, 8);
            this.hardWrite.TabIndex = 21;
            this.hardWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardRead
            // 
            this.hardRead.BackColor = System.Drawing.Color.DarkGreen;
            this.hardRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardRead.ForeColor = System.Drawing.Color.White;
            this.hardRead.Location = new System.Drawing.Point(18, 56);
            this.hardRead.Name = "hardRead";
            this.hardRead.Size = new System.Drawing.Size(8, 8);
            this.hardRead.TabIndex = 20;
            this.hardRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceUsage
            // 
            this.spaceUsage.Location = new System.Drawing.Point(16, 89);
            this.spaceUsage.Name = "spaceUsage";
            this.spaceUsage.Size = new System.Drawing.Size(46, 11);
            this.spaceUsage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.spaceUsage.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kõvaketta ruumikasutus: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(314, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "// Simulatsioon //";
            this.label5.Visible = false;
            // 
            // flashBufferCounter
            // 
            this.flashBufferCounter.CategoryName = "LogicalDisk";
            this.flashBufferCounter.CounterName = "Current Disk Queue Length";
            // 
            // driveWriteCounter
            // 
            this.driveWriteCounter.CategoryName = "LogicalDisk";
            this.driveWriteCounter.CounterName = "Disk Write Bytes/sec";
            // 
            // driveReadCounter
            // 
            this.driveReadCounter.CategoryName = "LogicalDisk";
            this.driveReadCounter.CounterName = "Disk Read Bytes/sec";
            // 
            // flashWriteCounter
            // 
            this.flashWriteCounter.CategoryName = "LogicalDisk";
            this.flashWriteCounter.CounterName = "Disk Write Bytes/sec";
            // 
            // flashReadCounter
            // 
            this.flashReadCounter.CategoryName = "LogicalDisk";
            this.flashReadCounter.CounterName = "Disk Read Bytes/sec";
            // 
            // statFinder
            // 
            this.statFinder.Enabled = true;
            this.statFinder.Interval = 500;
            this.statFinder.Tick += new System.EventHandler(this.statFinder_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Varukoopiat luuakse taustal";
            this.trayIcon.BalloonTipTitle = "Mälupulga sünkroonimistarkvara töötab taustal. Kui protsess lõpeb, saadetakse tei" +
    "le teavitus. Kui soovite näha kuidas protsess kulgeb, topeltklõpsake tegumiriba " +
    "ikoonil.";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Mälupulga failide sünkroonimise tööriist";
            this.trayIcon.Visible = true;
            this.trayIcon.BalloonTipClicked += new System.EventHandler(this.trayIcon_BalloonTipClicked);
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // StartBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flashBuffer);
            this.Controls.Add(this.flashWrite);
            this.Controls.Add(this.flashRead);
            this.Controls.Add(this.hardBuffer);
            this.Controls.Add(this.hardWrite);
            this.Controls.Add(this.hardRead);
            this.Controls.Add(this.spaceUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(461, 331);
            this.Name = "StartBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartBackup_FormClosing);
            this.Load += new System.EventHandler(this.StartBackup_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flashBufferCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveWriteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveReadCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashWriteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashReadCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private System.Windows.Forms.Timer waitasecond;
        private System.Windows.Forms.Timer folderCreator;
        private System.Windows.Forms.Timer eachCount;
        private System.Windows.Forms.Timer copyFiles;
        private Label flashBuffer;
        private Label flashWrite;
        private Label flashRead;
        private Label hardBuffer;
        private Label hardWrite;
        private Label hardRead;
        private ProgressBar spaceUsage;
        private Label label6;
        private Label label5;
        private PerformanceCounter flashBufferCounter;
        private PerformanceCounter driveWriteCounter;
        private PerformanceCounter driveReadCounter;
        private PerformanceCounter flashWriteCounter;
        private PerformanceCounter flashReadCounter;
        private System.Windows.Forms.Timer statFinder;
        private NotifyIcon trayIcon;
    }
}