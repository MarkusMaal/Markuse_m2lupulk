using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    partial class StartRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartRestore));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.waitasec = new System.Windows.Forms.Timer(this.components);
            this.checkDelete = new System.Windows.Forms.Timer(this.components);
            this.createFolders = new System.Windows.Forms.Timer(this.components);
            this.copyFiles = new System.Windows.Forms.Timer(this.components);
            this.fileSearcher = new System.Windows.Forms.Timer(this.components);
            this.copyMissing = new System.Windows.Forms.Timer(this.components);
            this.checkT = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.spaceUsage = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.flashBufferCounter = new System.Diagnostics.PerformanceCounter();
            this.statFinder = new System.Windows.Forms.Timer(this.components);
            this.hardBuffer = new System.Windows.Forms.Label();
            this.flashBuffer = new System.Windows.Forms.Label();
            this.flashReadCounter = new System.Diagnostics.PerformanceCounter();
            this.flashWriteCounter = new System.Diagnostics.PerformanceCounter();
            this.driveReadCounter = new System.Diagnostics.PerformanceCounter();
            this.driveWriteCounter = new System.Diagnostics.PerformanceCounter();
            this.hardRead = new System.Windows.Forms.Label();
            this.flashRead = new System.Windows.Forms.Label();
            this.flashWrite = new System.Windows.Forms.Label();
            this.hardWrite = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flashBufferCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashReadCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashWriteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveReadCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveWriteCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varukoopia taastamine...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varukoopia asukoht: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taaste sihtkaust: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 106);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Failide kustutamine";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 120);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Eksisteerivate failide kustutamine";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.TabStop = false;
            this.checkBox2.Text = "Kaustade loomine";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(274, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.TabStop = false;
            this.checkBox3.Text = "Failide kopeerimine mälupulgale varukoopia kaustast";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 72);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(247, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.TabStop = false;
            this.checkBox4.Text = "Failide, mida pole varukoopia kaustas, leidmine";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 95);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(207, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.TabStop = false;
            this.checkBox5.Text = "Nende failide kopeerimine mälupulgale";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // waitasec
            // 
            this.waitasec.Interval = 1000;
            this.waitasec.Tick += new System.EventHandler(this.waitasec_Tick);
            // 
            // checkDelete
            // 
            this.checkDelete.Tick += new System.EventHandler(this.checkDelete_Tick);
            // 
            // createFolders
            // 
            this.createFolders.Tick += new System.EventHandler(this.createFolders_Tick);
            // 
            // copyFiles
            // 
            this.copyFiles.Interval = 10;
            this.copyFiles.Tick += new System.EventHandler(this.copyFiles_Tick);
            // 
            // fileSearcher
            // 
            this.fileSearcher.Interval = 10;
            this.fileSearcher.Tick += new System.EventHandler(this.fileSearcher_Tick);
            // 
            // copyMissing
            // 
            this.copyMissing.Interval = 10;
            this.copyMissing.Tick += new System.EventHandler(this.copyMissing_Tick);
            // 
            // checkT
            // 
            this.checkT.Interval = 10;
            this.checkT.Tick += new System.EventHandler(this.checkT_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(314, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "// Simulatsioon //";
            this.label5.Visible = false;
            // 
            // spaceUsage
            // 
            this.spaceUsage.Location = new System.Drawing.Point(16, 89);
            this.spaceUsage.Name = "spaceUsage";
            this.spaceUsage.Size = new System.Drawing.Size(46, 11);
            this.spaceUsage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.spaceUsage.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mälupulga ruumikasutus: ";
            // 
            // flashBufferCounter
            // 
            this.flashBufferCounter.CategoryName = "LogicalDisk";
            this.flashBufferCounter.CounterName = "Current Disk Queue Length";
            // 
            // statFinder
            // 
            this.statFinder.Interval = 500;
            this.statFinder.Tick += new System.EventHandler(this.statFinder_Tick);
            // 
            // hardBuffer
            // 
            this.hardBuffer.BackColor = System.Drawing.Color.Olive;
            this.hardBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardBuffer.ForeColor = System.Drawing.Color.White;
            this.hardBuffer.Location = new System.Drawing.Point(54, 56);
            this.hardBuffer.Name = "hardBuffer";
            this.hardBuffer.Size = new System.Drawing.Size(8, 8);
            this.hardBuffer.TabIndex = 15;
            this.hardBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashBuffer
            // 
            this.flashBuffer.BackColor = System.Drawing.Color.Olive;
            this.flashBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashBuffer.ForeColor = System.Drawing.Color.White;
            this.flashBuffer.Location = new System.Drawing.Point(54, 74);
            this.flashBuffer.Name = "flashBuffer";
            this.flashBuffer.Size = new System.Drawing.Size(8, 8);
            this.flashBuffer.TabIndex = 18;
            this.flashBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashReadCounter
            // 
            this.flashReadCounter.CategoryName = "LogicalDisk";
            this.flashReadCounter.CounterName = "Disk Read Bytes/sec";
            // 
            // flashWriteCounter
            // 
            this.flashWriteCounter.CategoryName = "LogicalDisk";
            this.flashWriteCounter.CounterName = "Disk Write Bytes/sec";
            // 
            // driveReadCounter
            // 
            this.driveReadCounter.CategoryName = "LogicalDisk";
            this.driveReadCounter.CounterName = "Disk Read Bytes/sec";
            // 
            // driveWriteCounter
            // 
            this.driveWriteCounter.CategoryName = "LogicalDisk";
            this.driveWriteCounter.CounterName = "Disk Write Bytes/sec";
            // 
            // hardRead
            // 
            this.hardRead.BackColor = System.Drawing.Color.DarkGreen;
            this.hardRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardRead.ForeColor = System.Drawing.Color.White;
            this.hardRead.Location = new System.Drawing.Point(18, 56);
            this.hardRead.Name = "hardRead";
            this.hardRead.Size = new System.Drawing.Size(8, 8);
            this.hardRead.TabIndex = 13;
            this.hardRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashRead
            // 
            this.flashRead.BackColor = System.Drawing.Color.DarkGreen;
            this.flashRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashRead.ForeColor = System.Drawing.Color.White;
            this.flashRead.Location = new System.Drawing.Point(18, 74);
            this.flashRead.Name = "flashRead";
            this.flashRead.Size = new System.Drawing.Size(8, 8);
            this.flashRead.TabIndex = 16;
            this.flashRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashWrite
            // 
            this.flashWrite.BackColor = System.Drawing.Color.DarkRed;
            this.flashWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.flashWrite.ForeColor = System.Drawing.Color.White;
            this.flashWrite.Location = new System.Drawing.Point(36, 74);
            this.flashWrite.Name = "flashWrite";
            this.flashWrite.Size = new System.Drawing.Size(8, 8);
            this.flashWrite.TabIndex = 17;
            this.flashWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardWrite
            // 
            this.hardWrite.BackColor = System.Drawing.Color.DarkRed;
            this.hardWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.75F);
            this.hardWrite.ForeColor = System.Drawing.Color.White;
            this.hardWrite.Location = new System.Drawing.Point(36, 56);
            this.hardWrite.Name = "hardWrite";
            this.hardWrite.Size = new System.Drawing.Size(8, 8);
            this.hardWrite.TabIndex = 14;
            this.hardWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Mälupulga sünkroonimistarkvara töötab taustal. Kui protsess lõpeb, saadetakse tei" +
    "le teavitus. Kui soovite näha kuidas protsess kulgeb, topeltklõpsake tegumiriba " +
    "ikoonil.";
            this.trayIcon.BalloonTipTitle = "Taaste toimub taustal";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Mälupulga failide sünkroonimise tööriist";
            this.trayIcon.Visible = true;
            this.trayIcon.BalloonTipClicked += new System.EventHandler(this.trayIcon_BalloonTipClicked);
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // StartRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 292);
            this.Controls.Add(this.flashBuffer);
            this.Controls.Add(this.flashWrite);
            this.Controls.Add(this.flashRead);
            this.Controls.Add(this.hardBuffer);
            this.Controls.Add(this.hardWrite);
            this.Controls.Add(this.hardRead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spaceUsage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(461, 331);
            this.Name = "StartRestore";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartRestore_FormClosing);
            this.Load += new System.EventHandler(this.StartRestore_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flashBufferCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashReadCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashWriteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveReadCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveWriteCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private System.Windows.Forms.Timer waitasec;
        private System.Windows.Forms.Timer checkDelete;
        private System.Windows.Forms.Timer createFolders;
        private System.Windows.Forms.Timer copyFiles;
        private System.Windows.Forms.Timer fileSearcher;
        private System.Windows.Forms.Timer copyMissing;
        private System.Windows.Forms.Timer checkT;
        private Label label5;
        private ProgressBar spaceUsage;
        private Label label6;
        private PerformanceCounter flashBufferCounter;
        private System.Windows.Forms.Timer statFinder;
        private Label hardBuffer;
        private Label flashBuffer;
        private PerformanceCounter flashReadCounter;
        private PerformanceCounter flashWriteCounter;
        private PerformanceCounter driveReadCounter;
        private PerformanceCounter driveWriteCounter;
        private Label hardRead;
        private Label flashRead;
        private Label flashWrite;
        private Label hardWrite;
        private NotifyIcon trayIcon;
    }
}