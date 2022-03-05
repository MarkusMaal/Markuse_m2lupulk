using Markuse_mälupulk.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System;

namespace Markuse_mälupulk
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabButton_0 = new System.Windows.Forms.Button();
            this.TabButton_1 = new System.Windows.Forms.Button();
            this.TabButton_2 = new System.Windows.Forms.Button();
            this.TabButton_3 = new System.Windows.Forms.Button();
            this.TabButton_4 = new System.Windows.Forms.Button();
            this.TabButton_6 = new System.Windows.Forms.Button();
            this.Tab_0 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataCollectTimer = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.Tab_1 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.avaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lõikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopeeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleebiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kustutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tühjendaLõikelaudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uusKaustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laadiUuestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.attribuudidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tab_2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.avaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eemaldaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lisaEemaldaKiirrakendusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.kuvaÜksikasjadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appicons = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Tab_3 = new System.Windows.Forms.Panel();
            this.EditionLabel = new System.Windows.Forms.LinkLabel();
            this.flp4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DriveLabel = new System.Windows.Forms.Label();
            this.FsLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditionColor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tab_4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tab_6 = new System.Windows.Forms.Panel();
            this.button29 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rtfDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabButton_5 = new System.Windows.Forms.Button();
            this.ThemeChecker = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.CheckIfConnected = new System.Windows.Forms.Timer(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.addVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.moveLegacy = new System.Windows.Forms.FolderBrowserDialog();
            this.waitForComplete = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label20 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Huer = new System.Windows.Forms.Timer(this.components);
            this.CopyProgress = new System.Windows.Forms.Timer(this.components);
            this.waitForQAppThread = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkfqa = new System.Windows.Forms.Timer(this.components);
            this.allvideosbutton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.Tab_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flp1.SuspendLayout();
            this.Tab_1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.flp2.SuspendLayout();
            this.Tab_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Tab_3.SuspendLayout();
            this.flp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Tab_4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Tab_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabButton_0
            // 
            this.TabButton_0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_0.Enabled = false;
            this.TabButton_0.FlatAppearance.BorderSize = 0;
            this.TabButton_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TabButton_0.Location = new System.Drawing.Point(146, 75);
            this.TabButton_0.Name = "TabButton_0";
            this.TabButton_0.Size = new System.Drawing.Size(75, 21);
            this.TabButton_0.TabIndex = 2;
            this.TabButton_0.Text = "Uudised";
            this.TabButton_0.UseVisualStyleBackColor = true;
            this.TabButton_0.Click += new System.EventHandler(this.TabButton_0_Click);
            this.TabButton_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TabButton_1
            // 
            this.TabButton_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_1.Enabled = false;
            this.TabButton_1.FlatAppearance.BorderSize = 0;
            this.TabButton_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_1.Location = new System.Drawing.Point(231, 75);
            this.TabButton_1.Name = "TabButton_1";
            this.TabButton_1.Size = new System.Drawing.Size(75, 21);
            this.TabButton_1.TabIndex = 3;
            this.TabButton_1.Text = "Kaustad";
            this.TabButton_1.UseVisualStyleBackColor = true;
            this.TabButton_1.Click += new System.EventHandler(this.TabButton_1_Click);
            this.TabButton_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TabButton_2
            // 
            this.TabButton_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_2.Enabled = false;
            this.TabButton_2.FlatAppearance.BorderSize = 0;
            this.TabButton_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_2.Location = new System.Drawing.Point(308, 75);
            this.TabButton_2.Name = "TabButton_2";
            this.TabButton_2.Size = new System.Drawing.Size(103, 21);
            this.TabButton_2.TabIndex = 4;
            this.TabButton_2.Text = "Kiirrakendused";
            this.TabButton_2.UseVisualStyleBackColor = true;
            this.TabButton_2.Click += new System.EventHandler(this.TabButton_2_Click);
            this.TabButton_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TabButton_3
            // 
            this.TabButton_3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_3.Enabled = false;
            this.TabButton_3.FlatAppearance.BorderSize = 0;
            this.TabButton_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_3.Location = new System.Drawing.Point(417, 75);
            this.TabButton_3.Name = "TabButton_3";
            this.TabButton_3.Size = new System.Drawing.Size(81, 21);
            this.TabButton_3.TabIndex = 5;
            this.TabButton_3.Text = "Haldamine";
            this.TabButton_3.UseVisualStyleBackColor = true;
            this.TabButton_3.Click += new System.EventHandler(this.TabButton_3_Click);
            this.TabButton_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TabButton_4
            // 
            this.TabButton_4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_4.Enabled = false;
            this.TabButton_4.FlatAppearance.BorderSize = 0;
            this.TabButton_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_4.Location = new System.Drawing.Point(504, 75);
            this.TabButton_4.Name = "TabButton_4";
            this.TabButton_4.Size = new System.Drawing.Size(71, 23);
            this.TabButton_4.TabIndex = 6;
            this.TabButton_4.Text = "Statistika";
            this.TabButton_4.UseVisualStyleBackColor = true;
            this.TabButton_4.Click += new System.EventHandler(this.TabButton_4_Click);
            this.TabButton_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TabButton_6
            // 
            this.TabButton_6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabButton_6.Enabled = false;
            this.TabButton_6.FlatAppearance.BorderSize = 0;
            this.TabButton_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_6.Location = new System.Drawing.Point(581, 75);
            this.TabButton_6.Name = "TabButton_6";
            this.TabButton_6.Size = new System.Drawing.Size(80, 23);
            this.TabButton_6.TabIndex = 7;
            this.TabButton_6.Text = "Arendamine";
            this.TabButton_6.UseVisualStyleBackColor = true;
            this.TabButton_6.Click += new System.EventHandler(this.TabButton_5_Click);
            this.TabButton_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Tab_0
            // 
            this.Tab_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_0.Controls.Add(this.splitContainer1);
            this.Tab_0.Location = new System.Drawing.Point(12, 107);
            this.Tab_0.Name = "Tab_0";
            this.Tab_0.Size = new System.Drawing.Size(790, 386);
            this.Tab_0.TabIndex = 8;
            this.Tab_0.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.allvideosbutton);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.flp1);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.ArticleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(790, 386);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(478, 384);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.DoubleClick += new System.EventHandler(this.richTextBox1_DoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(2, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Topeltklõpsake vasakut paneeli, et see paneel peita";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flp1
            // 
            this.flp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp1.Controls.Add(this.button1);
            this.flp1.Controls.Add(this.button2);
            this.flp1.Controls.Add(this.button3);
            this.flp1.Enabled = false;
            this.flp1.Location = new System.Drawing.Point(7, 54);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(292, 81);
            this.flp1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<< Eelmine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Järgmine >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Laadi uuesti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(9, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Esita";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navigatsioon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(9, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 56);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(4, 38);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(62, 13);
            this.ArticleLabel.TabIndex = 2;
            this.ArticleLabel.Text = "Artikkel 1/5";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.Location = new System.Drawing.Point(2, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esiletõstetud videod";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // DataCollectTimer
            // 
            this.DataCollectTimer.Enabled = true;
            this.DataCollectTimer.Interval = 10;
            this.DataCollectTimer.Tick += new System.EventHandler(this.DataCollectTimer_Tick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(347, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Värkenda andmed";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.VisibleChanged += new System.EventHandler(this.button4_VisibleChanged);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tab_1
            // 
            this.Tab_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_1.Controls.Add(this.button30);
            this.Tab_1.Controls.Add(this.button5);
            this.Tab_1.Controls.Add(this.listView1);
            this.Tab_1.Controls.Add(this.label26);
            this.Tab_1.Controls.Add(this.label8);
            this.Tab_1.Controls.Add(this.flp2);
            this.Tab_1.Controls.Add(this.listBox3);
            this.Tab_1.Controls.Add(this.label7);
            this.Tab_1.Controls.Add(this.listBox2);
            this.Tab_1.Controls.Add(this.label6);
            this.Tab_1.Location = new System.Drawing.Point(12, 107);
            this.Tab_1.Name = "Tab_1";
            this.Tab_1.Size = new System.Drawing.Size(790, 386);
            this.Tab_1.TabIndex = 12;
            this.Tab_1.Visible = false;
            this.Tab_1.VisibleChanged += new System.EventHandler(this.Tab_1_VisibleChanged);
            // 
            // button30
            // 
            this.button30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button30.Enabled = false;
            this.button30.Location = new System.Drawing.Point(126, 218);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(33, 29);
            this.button30.TabIndex = 17;
            this.button30.Text = "-";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click_1);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(160, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.icons;
            this.listView1.Location = new System.Drawing.Point(199, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 217);
            this.listView1.SmallImageList = this.icons;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Visible = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.listView1_QueryContinueDrag);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // FileName
            // 
            this.FileName.Text = "Nimi";
            this.FileName.Width = 250;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaToolStripMenuItem1,
            this.toolStripSeparator6,
            this.lõikaToolStripMenuItem,
            this.kopeeriToolStripMenuItem,
            this.kleebiToolStripMenuItem,
            this.kustutaToolStripMenuItem,
            this.tühjendaLõikelaudToolStripMenuItem,
            this.toolStripSeparator1,
            this.uusKaustToolStripMenuItem,
            this.laadiUuestiToolStripMenuItem,
            this.toolStripSeparator3,
            this.attribuudidToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 220);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // avaToolStripMenuItem1
            // 
            this.avaToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.avaToolStripMenuItem1.Name = "avaToolStripMenuItem1";
            this.avaToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.avaToolStripMenuItem1.Text = "Ava";
            this.avaToolStripMenuItem1.Click += new System.EventHandler(this.avaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
            // 
            // lõikaToolStripMenuItem
            // 
            this.lõikaToolStripMenuItem.Name = "lõikaToolStripMenuItem";
            this.lõikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.lõikaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.lõikaToolStripMenuItem.Text = "Lõika";
            this.lõikaToolStripMenuItem.Click += new System.EventHandler(this.lõikaToolStripMenuItem_Click);
            // 
            // kopeeriToolStripMenuItem
            // 
            this.kopeeriToolStripMenuItem.Name = "kopeeriToolStripMenuItem";
            this.kopeeriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopeeriToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kopeeriToolStripMenuItem.Text = "Kopeeri";
            this.kopeeriToolStripMenuItem.Click += new System.EventHandler(this.kopeeriToolStripMenuItem_Click);
            // 
            // kleebiToolStripMenuItem
            // 
            this.kleebiToolStripMenuItem.Name = "kleebiToolStripMenuItem";
            this.kleebiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.kleebiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kleebiToolStripMenuItem.Text = "Kleebi";
            this.kleebiToolStripMenuItem.Click += new System.EventHandler(this.kleebiToolStripMenuItem_Click);
            // 
            // kustutaToolStripMenuItem
            // 
            this.kustutaToolStripMenuItem.Name = "kustutaToolStripMenuItem";
            this.kustutaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.kustutaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kustutaToolStripMenuItem.Text = "Kustuta";
            this.kustutaToolStripMenuItem.Click += new System.EventHandler(this.kustutaToolStripMenuItem_Click);
            // 
            // tühjendaLõikelaudToolStripMenuItem
            // 
            this.tühjendaLõikelaudToolStripMenuItem.Name = "tühjendaLõikelaudToolStripMenuItem";
            this.tühjendaLõikelaudToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tühjendaLõikelaudToolStripMenuItem.Text = "Tühjenda lõikelaud";
            this.tühjendaLõikelaudToolStripMenuItem.Click += new System.EventHandler(this.tühjendaLõikelaudToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // uusKaustToolStripMenuItem
            // 
            this.uusKaustToolStripMenuItem.Name = "uusKaustToolStripMenuItem";
            this.uusKaustToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.uusKaustToolStripMenuItem.Text = "Uus kaust";
            this.uusKaustToolStripMenuItem.Click += new System.EventHandler(this.uusKaustToolStripMenuItem_Click);
            // 
            // laadiUuestiToolStripMenuItem
            // 
            this.laadiUuestiToolStripMenuItem.Name = "laadiUuestiToolStripMenuItem";
            this.laadiUuestiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.laadiUuestiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.laadiUuestiToolStripMenuItem.Text = "Laadi uuesti";
            this.laadiUuestiToolStripMenuItem.Click += new System.EventHandler(this.laadiUuestiToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // attribuudidToolStripMenuItem
            // 
            this.attribuudidToolStripMenuItem.Name = "attribuudidToolStripMenuItem";
            this.attribuudidToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.attribuudidToolStripMenuItem.Text = "Attribuudid";
            this.attribuudidToolStripMenuItem.Click += new System.EventHandler(this.attribuudidToolStripMenuItem_Click);
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons.ImageSize = new System.Drawing.Size(16, 16);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label26.Location = new System.Drawing.Point(197, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(586, 21);
            this.label26.TabIndex = 15;
            this.label26.Text = "Failisirvija";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(198, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Muud kaustad";
            // 
            // flp2
            // 
            this.flp2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp2.Controls.Add(this.button7);
            this.flp2.Controls.Add(this.button13);
            this.flp2.Controls.Add(this.button8);
            this.flp2.Controls.Add(this.button9);
            this.flp2.Controls.Add(this.button10);
            this.flp2.Controls.Add(this.button11);
            this.flp2.Controls.Add(this.button12);
            this.flp2.Controls.Add(this.button14);
            this.flp2.Controls.Add(this.button15);
            this.flp2.Location = new System.Drawing.Point(199, 272);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(579, 108);
            this.flp2.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "markuse asjad";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(117, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(128, 23);
            this.button13.TabIndex = 11;
            this.button13.Text = "markuse asjad (juur)";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Kiirrakendused";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(365, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Uusimad videod";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(479, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "Abi ja info";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 32);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "Pakkfailid";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(97, 32);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "YUMI multiboot kaust";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(221, 32);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 23);
            this.button14.TabIndex = 12;
            this.button14.Text = "Ketta juurkaust";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(325, 32);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 23);
            this.button15.TabIndex = 13;
            this.button15.Text = "Mine";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Items.AddRange(new object[] {
            "Abi",
            "Minu videod",
            "Muud asjad",
            "Muusika",
            "Paigaldatavad failid",
            "Pildid",
            "PowerPoint",
            "Tekst",
            "Word"});
            this.listBox3.Location = new System.Drawing.Point(12, 272);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(182, 112);
            this.listBox3.TabIndex = 3;
            this.listBox3.SelectedValueChanged += new System.EventHandler(this.listBox3_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(8, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kasutaja kaustad";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(10, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 182);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kasutajad";
            // 
            // Tab_2
            // 
            this.Tab_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_2.Controls.Add(this.splitContainer2);
            this.Tab_2.Location = new System.Drawing.Point(12, 107);
            this.Tab_2.Name = "Tab_2";
            this.Tab_2.Size = new System.Drawing.Size(790, 386);
            this.Tab_2.TabIndex = 13;
            this.Tab_2.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel2MinSize = 30;
            this.splitContainer2.Size = new System.Drawing.Size(790, 386);
            this.splitContainer2.SplitterDistance = 209;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.appicons;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(790, 209);
            this.listView2.SmallImageList = this.appicons;
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ItemActivate += new System.EventHandler(this.listView2_ItemActivate);
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nimi";
            this.columnHeader1.Width = 9000;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaToolStripMenuItem,
            this.eemaldaToolStripMenuItem,
            this.toolStripSeparator4,
            this.lisaEemaldaKiirrakendusiToolStripMenuItem,
            this.toolStripSeparator5,
            this.kuvaÜksikasjadToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(264, 104);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // avaToolStripMenuItem
            // 
            this.avaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.avaToolStripMenuItem.Name = "avaToolStripMenuItem";
            this.avaToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.avaToolStripMenuItem.Text = "Ava";
            this.avaToolStripMenuItem.Click += new System.EventHandler(this.avaToolStripMenuItem_Click);
            // 
            // eemaldaToolStripMenuItem
            // 
            this.eemaldaToolStripMenuItem.Name = "eemaldaToolStripMenuItem";
            this.eemaldaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eemaldaToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.eemaldaToolStripMenuItem.Text = "Eemalda";
            this.eemaldaToolStripMenuItem.Click += new System.EventHandler(this.eemaldaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(260, 6);
            // 
            // lisaEemaldaKiirrakendusiToolStripMenuItem
            // 
            this.lisaEemaldaKiirrakendusiToolStripMenuItem.Name = "lisaEemaldaKiirrakendusiToolStripMenuItem";
            this.lisaEemaldaKiirrakendusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.lisaEemaldaKiirrakendusiToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.lisaEemaldaKiirrakendusiToolStripMenuItem.Text = "Lisa/Eemalda kiirrakendusi";
            this.lisaEemaldaKiirrakendusiToolStripMenuItem.Click += new System.EventHandler(this.lisaEemaldaKiirrakendusiToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(260, 6);
            // 
            // kuvaÜksikasjadToolStripMenuItem
            // 
            this.kuvaÜksikasjadToolStripMenuItem.Checked = true;
            this.kuvaÜksikasjadToolStripMenuItem.CheckOnClick = true;
            this.kuvaÜksikasjadToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kuvaÜksikasjadToolStripMenuItem.Name = "kuvaÜksikasjadToolStripMenuItem";
            this.kuvaÜksikasjadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.kuvaÜksikasjadToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.kuvaÜksikasjadToolStripMenuItem.Text = "Kuva üksikasjad";
            this.kuvaÜksikasjadToolStripMenuItem.Click += new System.EventHandler(this.kuvaÜksikasjadToolStripMenuItem_Click);
            // 
            // appicons
            // 
            this.appicons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.appicons.ImageSize = new System.Drawing.Size(48, 48);
            this.appicons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.32748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.67252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 173);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(313, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.41509F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.58491F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 167);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(468, 44);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kiirrakendused";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(468, 123);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kiirrakendused on nagu tavalised töölauarakendused, mida leiate enda arvutist, ag" +
    "a neil on eriline funktsioon: need töötavad kohe igas arvutis otse mälupulgalt.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Markuse_mälupulk.Properties.Resources.f22170384;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // Tab_3
            // 
            this.Tab_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_3.Controls.Add(this.EditionLabel);
            this.Tab_3.Controls.Add(this.flp4);
            this.Tab_3.Controls.Add(this.label15);
            this.Tab_3.Controls.Add(this.checkBox2);
            this.Tab_3.Controls.Add(this.checkBox3);
            this.Tab_3.Controls.Add(this.checkBox1);
            this.Tab_3.Controls.Add(this.label14);
            this.Tab_3.Controls.Add(this.DateLabel);
            this.Tab_3.Controls.Add(this.VersionLabel);
            this.Tab_3.Controls.Add(this.label13);
            this.Tab_3.Controls.Add(this.pictureBox3);
            this.Tab_3.Controls.Add(this.DriveLabel);
            this.Tab_3.Controls.Add(this.FsLabel);
            this.Tab_3.Controls.Add(this.CapacityLabel);
            this.Tab_3.Controls.Add(this.label12);
            this.Tab_3.Controls.Add(this.EditionColor);
            this.Tab_3.Controls.Add(this.label11);
            this.Tab_3.Location = new System.Drawing.Point(12, 107);
            this.Tab_3.Name = "Tab_3";
            this.Tab_3.Size = new System.Drawing.Size(790, 386);
            this.Tab_3.TabIndex = 14;
            this.Tab_3.Visible = false;
            // 
            // EditionLabel
            // 
            this.EditionLabel.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.EditionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditionLabel.AutoSize = true;
            this.EditionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.EditionLabel.LinkColor = System.Drawing.SystemColors.ControlText;
            this.EditionLabel.Location = new System.Drawing.Point(196, 62);
            this.EditionLabel.Name = "EditionLabel";
            this.EditionLabel.Size = new System.Drawing.Size(104, 13);
            this.EditionLabel.TabIndex = 22;
            this.EditionLabel.TabStop = true;
            this.EditionLabel.Text = "Tundmatu väljaanne";
            this.EditionLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.EditionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditionLabel_LinkClicked);
            // 
            // flp4
            // 
            this.flp4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flp4.Controls.Add(this.button22);
            this.flp4.Controls.Add(this.button20);
            this.flp4.Controls.Add(this.button16);
            this.flp4.Controls.Add(this.button21);
            this.flp4.Controls.Add(this.button18);
            this.flp4.Controls.Add(this.button19);
            this.flp4.Controls.Add(this.button4);
            this.flp4.Controls.Add(this.button31);
            this.flp4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp4.Location = new System.Drawing.Point(80, 269);
            this.flp4.Name = "flp4";
            this.flp4.Size = new System.Drawing.Size(635, 88);
            this.flp4.TabIndex = 19;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(3, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(166, 23);
            this.button22.TabIndex = 19;
            this.button22.Text = "Muuda mälupulga nime";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(3, 32);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(166, 23);
            this.button20.TabIndex = 17;
            this.button20.Text = "Ebaturvaline PIN kood";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(3, 61);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(166, 23);
            this.button16.TabIndex = 21;
            this.button16.Text = "Muuda PIN koodi";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(175, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(166, 23);
            this.button21.TabIndex = 18;
            this.button21.Text = "Teisenda väljaandeks Ultimate";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(175, 32);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(166, 23);
            this.button18.TabIndex = 15;
            this.button18.Text = "Varundushaldur";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(175, 61);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(166, 23);
            this.button19.TabIndex = 20;
            this.button19.Text = "Lisafunktsioonid";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // button31
            // 
            this.button31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button31.BackColor = System.Drawing.SystemColors.Control;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button31.Location = new System.Drawing.Point(347, 32);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(166, 23);
            this.button31.TabIndex = 22;
            this.button31.Text = "Lukusta haldusfunktsioonid";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Visible = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(79, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Haldamine";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(80, 190);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Täisekraan";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(80, 213);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(214, 17);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Muuda seadet andmete värskendamisel";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(384, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Käivita see programm iga kord kui Markuse mälupulk on arvutisse sisestatud";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.Location = new System.Drawing.Point(76, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Seadistused";
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DateLabel.Location = new System.Drawing.Point(488, 80);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(102, 13);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Kuupäev: {filedate}";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.VersionLabel.Location = new System.Drawing.Point(488, 67);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(99, 13);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Versioon: {asmver}";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.Location = new System.Drawing.Point(487, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Markuse mälupulga juhtpaneel";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Markuse_mälupulk.Properties.Resources.mas_flash;
            this.pictureBox3.Location = new System.Drawing.Point(381, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // DriveLabel
            // 
            this.DriveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DriveLabel.AutoSize = true;
            this.DriveLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DriveLabel.Location = new System.Drawing.Point(196, 103);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(49, 13);
            this.DriveLabel.TabIndex = 6;
            this.DriveLabel.Text = "Draiv: A:";
            // 
            // FsLabel
            // 
            this.FsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FsLabel.AutoSize = true;
            this.FsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FsLabel.Location = new System.Drawing.Point(196, 90);
            this.FsLabel.Name = "FsLabel";
            this.FsLabel.Size = new System.Drawing.Size(100, 13);
            this.FsLabel.TabIndex = 5;
            this.FsLabel.Text = "Failisüsteem: RAW";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CapacityLabel.Location = new System.Drawing.Point(196, 77);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(98, 13);
            this.CapacityLabel.TabIndex = 4;
            this.CapacityLabel.Text = "Maht: 0 GiB (0 GB)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(194, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Markuse mälupulk";
            // 
            // EditionColor
            // 
            this.EditionColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditionColor.BackColor = System.Drawing.Color.Gray;
            this.EditionColor.Location = new System.Drawing.Point(96, 39);
            this.EditionColor.Name = "EditionColor";
            this.EditionColor.Size = new System.Drawing.Size(92, 80);
            this.EditionColor.TabIndex = 1;
            this.EditionColor.DoubleClick += new System.EventHandler(this.EditionColor_DoubleClick);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(76, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Teave";
            // 
            // Tab_4
            // 
            this.Tab_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_4.BackColor = System.Drawing.Color.Transparent;
            this.Tab_4.Controls.Add(this.panel1);
            this.Tab_4.Location = new System.Drawing.Point(12, 107);
            this.Tab_4.Name = "Tab_4";
            this.Tab_4.Size = new System.Drawing.Size(790, 386);
            this.Tab_4.TabIndex = 15;
            this.Tab_4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 386);
            this.panel1.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Transparent};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(790, 386);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 14F);
            title1.Name = "Title1";
            title1.Text = "Mälupulga ruumikasutamise statistika";
            this.chart1.Titles.Add(title1);
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            // 
            // Tab_6
            // 
            this.Tab_6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_6.Controls.Add(this.flowLayoutPanel1);
            this.Tab_6.Controls.Add(this.label16);
            this.Tab_6.Controls.Add(this.button29);
            this.Tab_6.Controls.Add(this.button17);
            this.Tab_6.Controls.Add(this.checkBox4);
            this.Tab_6.Controls.Add(this.button24);
            this.Tab_6.Controls.Add(this.button28);
            this.Tab_6.Controls.Add(this.label19);
            this.Tab_6.Controls.Add(this.button27);
            this.Tab_6.Controls.Add(this.button26);
            this.Tab_6.Controls.Add(this.label18);
            this.Tab_6.Controls.Add(this.button25);
            this.Tab_6.Controls.Add(this.button23);
            this.Tab_6.Controls.Add(this.listBox5);
            this.Tab_6.Controls.Add(this.label17);
            this.Tab_6.Location = new System.Drawing.Point(12, 107);
            this.Tab_6.Name = "Tab_6";
            this.Tab_6.Size = new System.Drawing.Size(790, 386);
            this.Tab_6.TabIndex = 16;
            this.Tab_6.Visible = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.SystemColors.Control;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button29.Location = new System.Drawing.Point(278, 190);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(143, 23);
            this.button29.TabIndex = 24;
            this.button29.Text = "Loe arhiveeritud uudiseid";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click_2);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.Control;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button17.Location = new System.Drawing.Point(172, 190);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 23);
            this.button17.TabIndex = 23;
            this.button17.Text = "Arhiveeri uudis";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 356);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Simulatsioonirežiim";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox4_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(185, 120);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(139, 23);
            this.button24.TabIndex = 10;
            this.button24.Text = "Rakenda muudatused";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button28
            // 
            this.button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button28.Location = new System.Drawing.Point(639, 352);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(139, 23);
            this.button28.TabIndex = 9;
            this.button28.Text = "Rakenda muudatused";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label19.Location = new System.Drawing.Point(8, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Esiletõstetud videote haldamine";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(91, 190);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 7;
            this.button27.Text = "Loo ..";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(11, 190);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 6;
            this.button26.Text = "RTF failist ..";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label18.Location = new System.Drawing.Point(8, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Uudise lisamine";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(90, 120);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(89, 23);
            this.button25.TabIndex = 4;
            this.button25.Text = "Asenda video";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(9, 120);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 2;
            this.button23.Text = "Lisa video";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 17;
            this.listBox5.Location = new System.Drawing.Point(9, 59);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(775, 53);
            this.listBox5.TabIndex = 1;
            this.listBox5.Click += new System.EventHandler(this.listBox5_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label17.Location = new System.Drawing.Point(6, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Arendamine";
            // 
            // rtfDialog1
            // 
            this.rtfDialog1.Filter = "*.rtf|Wordpad\'i dokumendid (*.rtf)";
            // 
            // TabButton_5
            // 
            this.TabButton_5.Enabled = false;
            this.TabButton_5.FlatAppearance.BorderSize = 0;
            this.TabButton_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabButton_5.Location = new System.Drawing.Point(683, 72);
            this.TabButton_5.Name = "TabButton_5";
            this.TabButton_5.Size = new System.Drawing.Size(10, 23);
            this.TabButton_5.TabIndex = 18;
            this.TabButton_5.UseVisualStyleBackColor = true;
            this.TabButton_5.Visible = false;
            this.TabButton_5.Click += new System.EventHandler(this.TabButton_5_Click_1);
            // 
            // ThemeChecker
            // 
            this.ThemeChecker.Tick += new System.EventHandler(this.ThemeChecker_Tick);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(776, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 25);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.Button29_Click);
            this.closeButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // CheckIfConnected
            // 
            this.CheckIfConnected.Interval = 5000;
            this.CheckIfConnected.Tick += new System.EventHandler(this.CheckIfConnected_Tick);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label21.Location = new System.Drawing.Point(574, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 18);
            this.label21.TabIndex = 23;
            this.label21.Text = "|";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label22.Location = new System.Drawing.Point(495, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 18);
            this.label22.TabIndex = 24;
            this.label22.Text = "|";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label23.Location = new System.Drawing.Point(411, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 18);
            this.label23.TabIndex = 25;
            this.label23.Text = "|";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label24.Location = new System.Drawing.Point(301, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 18);
            this.label24.TabIndex = 26;
            this.label24.Text = "|";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label25.Location = new System.Drawing.Point(223, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 21);
            this.label25.TabIndex = 24;
            this.label25.Text = "|";
            // 
            // addVideoDialog
            // 
            this.addVideoDialog.Filter = "Videofailid mälupulgal|*.wmv;*.mp4;*.avi;*.asf;*.mov;*.flv";
            this.addVideoDialog.ShowHelp = true;
            this.addVideoDialog.HelpRequest += new System.EventHandler(this.addVideoDialog_HelpRequest);
            // 
            // moveLegacy
            // 
            this.moveLegacy.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // waitForComplete
            // 
            this.waitForComplete.Tick += new System.EventHandler(this.waitForComplete_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::Markuse_mälupulk.Properties.Resources.cool_pattern;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(819, 71);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.label20});
            this.statusStrip1.Location = new System.Drawing.Point(4, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(254, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // label20
            // 
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 17);
            this.label20.Text = "seadmete tuvastamine...";
            // 
            // Huer
            // 
            this.Huer.Interval = 16;
            this.Huer.Tick += new System.EventHandler(this.Huer_Tick);
            // 
            // CopyProgress
            // 
            this.CopyProgress.Tick += new System.EventHandler(this.CopyProgress_Tick);
            // 
            // waitForQAppThread
            // 
            this.waitForQAppThread.Tick += new System.EventHandler(this.waitForQAppThread_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(432, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Andmete kogumise ajal saate juba laaditud funktsioone kasutada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // checkfqa
            // 
            this.checkfqa.Tick += new System.EventHandler(this.checkfqa_Tick);
            // 
            // allvideosbutton
            // 
            this.allvideosbutton.Enabled = false;
            this.allvideosbutton.Location = new System.Drawing.Point(84, 229);
            this.allvideosbutton.Name = "allvideosbutton";
            this.allvideosbutton.Size = new System.Drawing.Size(82, 23);
            this.allvideosbutton.TabIndex = 11;
            this.allvideosbutton.Text = "Kõik videod";
            this.allvideosbutton.UseVisualStyleBackColor = true;
            this.allvideosbutton.Click += new System.EventHandler(this.allvideosbutton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label16.Location = new System.Drawing.Point(8, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Uudise muutmine";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button32);
            this.flowLayoutPanel1.Controls.Add(this.button33);
            this.flowLayoutPanel1.Controls.Add(this.button34);
            this.flowLayoutPanel1.Controls.Add(this.button35);
            this.flowLayoutPanel1.Controls.Add(this.button36);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 260);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(766, 35);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(3, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 0;
            this.button32.Text = "Uudis 1";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(84, 3);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 23);
            this.button33.TabIndex = 1;
            this.button33.Text = "Uudis 2";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(165, 3);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 2;
            this.button34.Text = "Uudis 3";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(246, 3);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(75, 23);
            this.button35.TabIndex = 3;
            this.button35.Text = "Uudis 4";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(327, 3);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(75, 23);
            this.button36.TabIndex = 4;
            this.button36.Text = "Uudis 5";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.Tab_6);
            this.Controls.Add(this.Tab_3);
            this.Controls.Add(this.Tab_0);
            this.Controls.Add(this.Tab_1);
            this.Controls.Add(this.Tab_4);
            this.Controls.Add(this.Tab_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.TabButton_5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabButton_6);
            this.Controls.Add(this.TabButton_4);
            this.Controls.Add(this.TabButton_3);
            this.Controls.Add(this.TabButton_2);
            this.Controls.Add(this.TabButton_1);
            this.Controls.Add(this.TabButton_0);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 503);
            this.Name = "Form1";
            this.Text = "Markuse mälupulk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Tab_0.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flp1.ResumeLayout(false);
            this.Tab_1.ResumeLayout(false);
            this.Tab_1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flp2.ResumeLayout(false);
            this.Tab_2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Tab_3.ResumeLayout(false);
            this.Tab_3.PerformLayout();
            this.flp4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Tab_4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Tab_6.ResumeLayout(false);
            this.Tab_6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Panel Tab_0;
        public System.Windows.Forms.Button TabButton_0;
        public System.Windows.Forms.Button TabButton_1;
        public System.Windows.Forms.Button TabButton_2;
        public System.Windows.Forms.Button TabButton_3;
        public System.Windows.Forms.Button TabButton_4;
        public System.Windows.Forms.Button TabButton_6;
        private System.Windows.Forms.Panel Tab_1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel Tab_2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel Tab_3;
        private System.Windows.Forms.FlowLayoutPanel flp4;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label DriveLabel;
        private System.Windows.Forms.Label FsLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel Tab_4;
        private System.Windows.Forms.Panel Tab_6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.OpenFileDialog rtfDialog1;
        private System.Windows.Forms.Button button24;
        public System.Windows.Forms.Button TabButton_5;
        private System.Windows.Forms.Timer ThemeChecker;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer CheckIfConnected;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog addVideoDialog;
        private System.Windows.Forms.FolderBrowserDialog moveLegacy;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Timer waitForComplete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Label label26;
        internal System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList appicons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer Huer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lõikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopeeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kleebiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uusKaustToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem attribuudidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tühjendaLõikelaudToolStripMenuItem;
        private System.Windows.Forms.Timer CopyProgress;
        private System.Windows.Forms.ToolStripMenuItem laadiUuestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kustutaToolStripMenuItem;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem avaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eemaldaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem lisaEemaldaKiirrakendusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem kuvaÜksikasjadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Timer waitForQAppThread;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.LinkLabel EditionLabel;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer checkfqa;
        private System.Windows.Forms.Timer DataCollectTimer;
        private Chart chart1;
        public System.Windows.Forms.ToolStripProgressBar progressBar1;
        public System.Windows.Forms.Label EditionColor;
        internal System.Windows.Forms.ToolStripStatusLabel label20;
        private Button allvideosbutton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Label label16;
    }
}

