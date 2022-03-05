using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Markuse_mälupulk
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.InputMsg = new Label();
            this.InputTxt = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();
            this.InputMsg.Font = new Font("Segoe UI", 14f);
            this.InputMsg.Location = new Point(7, 9);
            this.InputMsg.Name = "InputMsg";
            this.InputMsg.Size = new Size(522, 48);
            this.InputMsg.TabIndex = 2;
            this.InputMsg.Text = "InputMsg";
            this.InputMsg.TextAlign = ContentAlignment.MiddleLeft;
            this.InputTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.InputTxt.Location = new Point(12, 66);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new Size(517, 20);
            this.InputTxt.TabIndex = 0;
            this.InputTxt.KeyDown += new KeyEventHandler(this.InputTxt_KeyDown);
            this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button1.BackColor = SystemColors.Control;
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(454, 105);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(541, 140);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.InputTxt);
            this.Controls.Add((Control)this.InputMsg);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.Name = "InputBox";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.InputBox_Load);
            this.Shown += new EventHandler(this.InputBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label InputMsg;
        public System.Windows.Forms.TextBox InputTxt;
    }
}