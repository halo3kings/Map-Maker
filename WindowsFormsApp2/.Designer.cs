using System;

namespace WindowsFormsApp2
{
    partial class Default_Window
    {
        public event EventHandler QuitBut;

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default_Window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EyeDropperTool = new System.Windows.Forms.PictureBox();
            this.EraserTool = new System.Windows.Forms.PictureBox();
            this.BoxSelectTool = new System.Windows.Forms.PictureBox();
            this.SelectTool = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tiles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Buildings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Workspace = new System.Windows.Forms.Panel();
            this.Map = new System.Windows.Forms.Panel();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeDropperTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelectTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTool)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tiles.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.Buildings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1281, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.Quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.New_Map);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // mapToolStripMenuItem1
            // 
            this.mapToolStripMenuItem1.Name = "mapToolStripMenuItem1";
            this.mapToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.mapToolStripMenuItem1.Text = "Map";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem2,
            this.mapImageToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // mapToolStripMenuItem2
            // 
            this.mapToolStripMenuItem2.Name = "mapToolStripMenuItem2";
            this.mapToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.mapToolStripMenuItem2.Text = "Map";
            // 
            // mapImageToolStripMenuItem
            // 
            this.mapImageToolStripMenuItem.Name = "mapImageToolStripMenuItem";
            this.mapImageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mapImageToolStripMenuItem.Text = "Map Image";
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(114, 22);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.QuitButton);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(50, 677);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.EyeDropperTool, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.EraserTool, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BoxSelectTool, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SelectTool, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(44, 658);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // EyeDropperTool
            // 
            this.EyeDropperTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EyeDropperTool.Image = global::WindowsFormsApp2.Properties.Resources.img_425707;
            this.EyeDropperTool.InitialImage = global::WindowsFormsApp2.Properties.Resources.img_425707;
            this.EyeDropperTool.Location = new System.Drawing.Point(3, 123);
            this.EyeDropperTool.Name = "EyeDropperTool";
            this.EyeDropperTool.Size = new System.Drawing.Size(38, 34);
            this.EyeDropperTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EyeDropperTool.TabIndex = 6;
            this.EyeDropperTool.TabStop = false;
            // 
            // EraserTool
            // 
            this.EraserTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EraserTool.Image = global::WindowsFormsApp2.Properties.Resources.img_468470;
            this.EraserTool.InitialImage = global::WindowsFormsApp2.Properties.Resources.img_468470;
            this.EraserTool.Location = new System.Drawing.Point(3, 83);
            this.EraserTool.Name = "EraserTool";
            this.EraserTool.Size = new System.Drawing.Size(38, 34);
            this.EraserTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EraserTool.TabIndex = 5;
            this.EraserTool.TabStop = false;
            // 
            // BoxSelectTool
            // 
            this.BoxSelectTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxSelectTool.Image = ((System.Drawing.Image)(resources.GetObject("BoxSelectTool.Image")));
            this.BoxSelectTool.InitialImage = ((System.Drawing.Image)(resources.GetObject("BoxSelectTool.InitialImage")));
            this.BoxSelectTool.Location = new System.Drawing.Point(3, 43);
            this.BoxSelectTool.Name = "BoxSelectTool";
            this.BoxSelectTool.Size = new System.Drawing.Size(38, 34);
            this.BoxSelectTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxSelectTool.TabIndex = 2;
            this.BoxSelectTool.TabStop = false;
            // 
            // SelectTool
            // 
            this.SelectTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectTool.Image = global::WindowsFormsApp2.Properties.Resources.cursor_PNG78;
            this.SelectTool.InitialImage = global::WindowsFormsApp2.Properties.Resources.cursor_PNG78;
            this.SelectTool.Location = new System.Drawing.Point(3, 3);
            this.SelectTool.Name = "SelectTool";
            this.SelectTool.Size = new System.Drawing.Size(38, 34);
            this.SelectTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectTool.TabIndex = 0;
            this.SelectTool.TabStop = false;
            this.SelectTool.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1077, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 677);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assets";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tiles);
            this.tabControl1.Controls.Add(this.Buildings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(198, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // Tiles
            // 
            this.Tiles.Controls.Add(this.tableLayoutPanel3);
            this.Tiles.Location = new System.Drawing.Point(4, 22);
            this.Tiles.Name = "Tiles";
            this.Tiles.Padding = new System.Windows.Forms.Padding(3);
            this.Tiles.Size = new System.Drawing.Size(190, 632);
            this.Tiles.TabIndex = 1;
            this.Tiles.Text = "Tiles";
            this.Tiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(184, 626);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._256x256;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources._256x256V2;
            this.pictureBox2.Location = new System.Drawing.Point(95, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources._256x256V3;
            this.pictureBox3.Location = new System.Drawing.Point(3, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources._256x256V4;
            this.pictureBox4.Location = new System.Drawing.Point(95, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources._256x256V5;
            this.pictureBox5.Location = new System.Drawing.Point(3, 159);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources._256x256V6;
            this.pictureBox6.Location = new System.Drawing.Point(95, 159);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(86, 72);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // Buildings
            // 
            this.Buildings.Controls.Add(this.tableLayoutPanel1);
            this.Buildings.Location = new System.Drawing.Point(4, 22);
            this.Buildings.Name = "Buildings";
            this.Buildings.Padding = new System.Windows.Forms.Padding(3);
            this.Buildings.Size = new System.Drawing.Size(190, 632);
            this.Buildings.TabIndex = 0;
            this.Buildings.Text = "Buildings";
            this.Buildings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 626);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Workspace);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(50, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1027, 677);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Viewer";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Workspace
            // 
            this.Workspace.BackColor = System.Drawing.SystemColors.Window;
            this.Workspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Workspace.Controls.Add(this.Map);
            this.Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workspace.Location = new System.Drawing.Point(3, 16);
            this.Workspace.Name = "Workspace";
            this.Workspace.Size = new System.Drawing.Size(1021, 658);
            this.Workspace.TabIndex = 0;
            this.Workspace.Paint += new System.Windows.Forms.PaintEventHandler(this.Workspace_Paint);
            // 
            // Map
            // 
            this.Map.AutoScroll = true;
            this.Map.AutoSize = true;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1019, 656);
            this.Map.TabIndex = 0;
            this.Map.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.New_Map);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(WindowsFormsApp2.model);
            // 
            // Default_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 701);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Default_Window";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EyeDropperTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelectTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTool)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Tiles.ResumeLayout(false);
            this.Tiles.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.Buildings.ResumeLayout(false);
            this.Buildings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Workspace.ResumeLayout(false);
            this.Workspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem mapImageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Quit;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Panel Workspace;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage Buildings;
        public System.Windows.Forms.TabPage Tiles;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.BindingSource modelBindingSource;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Panel Map;
        public System.Windows.Forms.PictureBox SelectTool;
        public System.Windows.Forms.PictureBox BoxSelectTool;
        public System.Windows.Forms.PictureBox EyeDropperTool;
        public System.Windows.Forms.PictureBox EraserTool;
    }
}

