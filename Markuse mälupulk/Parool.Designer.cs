using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Markuse_mälupulk
{
    partial class Parool
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Parool));
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button10 = new Button();
            this.button11 = new Button();
            this.button12 = new Button();
            this.SuspendLayout();
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.label1.Font = new Font("Segoe UI", 16f);
            this.label1.Location = new Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(350, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palun sisestage PIN kood";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.label2.BorderStyle = BorderStyle.FixedSingle;
            this.label2.Font = new Font("Segoe UI", 10f);
            this.label2.Location = new Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new Size(321, 23);
            this.label2.TabIndex = 1;
            this.button1.Anchor = AnchorStyles.Top;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Font = new Font("Microsoft Sans Serif", 15f);
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(86, 113);
            this.button1.Name = "button1";
            this.button1.Size = new Size(51, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "&7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button1.KeyDown += new KeyEventHandler(this.button1_KeyDown);
            this.button2.Anchor = AnchorStyles.Top;
            this.button2.BackColor = SystemColors.Control;
            this.button2.Font = new Font("Microsoft Sans Serif", 15f);
            this.button2.ForeColor = SystemColors.ControlText;
            this.button2.Location = new Point(143, 113);
            this.button2.Name = "button2";
            this.button2.Size = new Size(51, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "&8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button2.KeyDown += new KeyEventHandler(this.button2_KeyDown);
            this.button3.Anchor = AnchorStyles.Top;
            this.button3.BackColor = SystemColors.Control;
            this.button3.Font = new Font("Microsoft Sans Serif", 15f);
            this.button3.ForeColor = SystemColors.ControlText;
            this.button3.Location = new Point(200, 113);
            this.button3.Name = "button3";
            this.button3.Size = new Size(51, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "&9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button3.KeyDown += new KeyEventHandler(this.button3_KeyDown);
            this.button4.Anchor = AnchorStyles.Top;
            this.button4.BackColor = SystemColors.Control;
            this.button4.Font = new Font("Microsoft Sans Serif", 15f);
            this.button4.ForeColor = SystemColors.ControlText;
            this.button4.Location = new Point(86, 163);
            this.button4.Name = "button4";
            this.button4.Size = new Size(51, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "&4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button4.KeyDown += new KeyEventHandler(this.button4_KeyDown);
            this.button5.Anchor = AnchorStyles.Top;
            this.button5.BackColor = SystemColors.Control;
            this.button5.Font = new Font("Microsoft Sans Serif", 15f);
            this.button5.ForeColor = SystemColors.ControlText;
            this.button5.Location = new Point(143, 163);
            this.button5.Name = "button5";
            this.button5.Size = new Size(51, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "&5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.button5.KeyDown += new KeyEventHandler(this.button5_KeyDown);
            this.button6.Anchor = AnchorStyles.Top;
            this.button6.BackColor = SystemColors.Control;
            this.button6.Font = new Font("Microsoft Sans Serif", 15f);
            this.button6.ForeColor = SystemColors.ControlText;
            this.button6.Location = new Point(200, 163);
            this.button6.Name = "button6";
            this.button6.Size = new Size(51, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "&6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.button6.KeyDown += new KeyEventHandler(this.button6_KeyDown);
            this.button7.Anchor = AnchorStyles.Top;
            this.button7.BackColor = SystemColors.Control;
            this.button7.Font = new Font("Microsoft Sans Serif", 15f);
            this.button7.ForeColor = SystemColors.ControlText;
            this.button7.Location = new Point(86, 213);
            this.button7.Name = "button7";
            this.button7.Size = new Size(51, 44);
            this.button7.TabIndex = 1;
            this.button7.Text = "&1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.button7.KeyDown += new KeyEventHandler(this.button7_KeyDown);
            this.button8.Anchor = AnchorStyles.Top;
            this.button8.BackColor = SystemColors.Control;
            this.button8.Font = new Font("Microsoft Sans Serif", 15f);
            this.button8.ForeColor = SystemColors.ControlText;
            this.button8.Location = new Point(143, 213);
            this.button8.Name = "button8";
            this.button8.Size = new Size(51, 44);
            this.button8.TabIndex = 2;
            this.button8.Text = "&2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new EventHandler(this.button8_Click);
            this.button8.KeyDown += new KeyEventHandler(this.button8_KeyDown);
            this.button9.Anchor = AnchorStyles.Top;
            this.button9.BackColor = SystemColors.Control;
            this.button9.Font = new Font("Microsoft Sans Serif", 15f);
            this.button9.ForeColor = SystemColors.ControlText;
            this.button9.Location = new Point(200, 213);
            this.button9.Name = "button9";
            this.button9.Size = new Size(51, 44);
            this.button9.TabIndex = 3;
            this.button9.Text = "&3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new EventHandler(this.button9_Click);
            this.button9.KeyDown += new KeyEventHandler(this.button9_KeyDown);
            this.button10.Anchor = AnchorStyles.Top;
            this.button10.BackColor = SystemColors.Control;
            this.button10.Font = new Font("Microsoft Sans Serif", 15f);
            this.button10.ForeColor = SystemColors.ControlText;
            this.button10.Location = new Point(143, 263);
            this.button10.Name = "button10";
            this.button10.Size = new Size(51, 44);
            this.button10.TabIndex = 10;
            this.button10.Text = "&0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new EventHandler(this.button10_Click);
            this.button10.KeyDown += new KeyEventHandler(this.button10_KeyDown);
            this.button11.Anchor = AnchorStyles.Top;
            this.button11.BackColor = SystemColors.Control;
            this.button11.Font = new Font("Microsoft Sans Serif", 10f);
            this.button11.ForeColor = SystemColors.ControlText;
            this.button11.Location = new Point(200, 263);
            this.button11.Name = "button11";
            this.button11.Size = new Size(51, 44);
            this.button11.TabIndex = 0;
            this.button11.Text = "&Lõpp";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new EventHandler(this.button11_Click);
            this.button11.KeyDown += new KeyEventHandler(this.button11_KeyDown);
            this.button12.Anchor = AnchorStyles.Top;
            this.button12.BackColor = SystemColors.Control;
            this.button12.Font = new Font("Microsoft Sans Serif", 15f);
            this.button12.ForeColor = SystemColors.ControlText;
            this.button12.Location = new Point(86, 263);
            this.button12.Name = "button12";
            this.button12.Size = new Size(51, 44);
            this.button12.TabIndex = 11;
            this.button12.Text = "&<--";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new EventHandler(this.button12_Click);
            this.button12.KeyDown += new KeyEventHandler(this.button12_KeyDown);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(345, 321);
            this.Controls.Add((Control)this.button12);
            this.Controls.Add((Control)this.button11);
            this.Controls.Add((Control)this.button10);
            this.Controls.Add((Control)this.button9);
            this.Controls.Add((Control)this.button8);
            this.Controls.Add((Control)this.button7);
            this.Controls.Add((Control)this.button6);
            this.Controls.Add((Control)this.button5);
            this.Controls.Add((Control)this.button4);
            this.Controls.Add((Control)this.button3);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.Name = "Parool";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Parool";
            this.Load += new EventHandler(this.Parool_Load);
            this.Shown += new EventHandler(this.Parool_Shown);
            this.KeyDown += new KeyEventHandler(this.Parool_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}