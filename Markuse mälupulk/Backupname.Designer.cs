using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Markuse_mälupulk
{
    partial class Backupname
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

            this.components = (IContainer)new Container();
            this.label1 = new Label();
            this.backuplabel = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.flashTimer = new Timer(this.components);
            this.toolTip1 = new ToolTip(this.components);
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(271, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Et varukoopiat lihtsamini ära tunda, saate sisestada sildi.\r\nSilt peab vastama failinimede reeglitele.";
            this.backuplabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.backuplabel.BorderStyle = BorderStyle.FixedSingle;
            this.backuplabel.Location = new Point(15, 49);
            this.backuplabel.Name = "backuplabel";
            this.backuplabel.Size = new Size(328, 20);
            this.backuplabel.TabIndex = 0;
            this.backuplabel.Text = "markuse mälupulk";
            this.backuplabel.TextChanged += new EventHandler(this.backuplabel_TextChanged);
            this.backuplabel.KeyDown += new KeyEventHandler(this.backuplabel_KeyDown);
            this.buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.buttonOK.ForeColor = SystemColors.ControlText;
            this.buttonOK.Location = new Point(268, 80);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(73, 24);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.button1_Click);
            this.buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.buttonCancel.ForeColor = SystemColors.ControlText;
            this.buttonCancel.Location = new Point(189, 80);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(73, 24);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Loobu";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            this.flashTimer.Tick += new EventHandler(this.flashTimer_Tick);
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(355, 118);
            this.Controls.Add((Control)this.backuplabel);
            this.Controls.Add((Control)this.buttonCancel);
            this.Controls.Add((Control)this.buttonOK);
            this.Controls.Add((Control)this.label1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new Size(307, 157);
            this.Name = "Backupname";
            this.ShowInTaskbar = false;
            this.Text = "Varukoopia silt";
            this.FormClosing += new FormClosingEventHandler(this.Backupname_FormClosing);
            this.Load += new EventHandler(this.Backupname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        internal System.Windows.Forms.TextBox backuplabel;
        private System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}