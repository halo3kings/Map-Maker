using System;

namespace WindowsFormsApp2
{
    partial class New_Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WidthIn = new System.Windows.Forms.NumericUpDown();
            this.labelPowerDrain = new System.Windows.Forms.Label();
            this.PowerDrain = new System.Windows.Forms.CheckBox();
            this.labelAvalanches = new System.Windows.Forms.Label();
            this.Avalanche = new System.Windows.Forms.CheckBox();
            this.labelHostileAI = new System.Windows.Forms.Label();
            this.MapName = new System.Windows.Forms.TextBox();
            this.labelMapName = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.TerrainType = new System.Windows.Forms.ComboBox();
            this.labelTerrainType = new System.Windows.Forms.Label();
            this.labelErosion = new System.Windows.Forms.Label();
            this.Erosion = new System.Windows.Forms.CheckBox();
            this.labelAirThreat = new System.Windows.Forms.Label();
            this.HostileAI = new System.Windows.Forms.CheckBox();
            this.AirThreat = new System.Windows.Forms.CheckBox();
            this.HeightIn = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDamageToPlayer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultPlayerDamage = new System.Windows.Forms.CheckBox();
            this.labelCustomDamage = new System.Windows.Forms.Label();
            this.CustomDamage = new System.Windows.Forms.NumericUpDown();
            this.LabelDamageFromPlayer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultDamageFromPlayer = new System.Windows.Forms.CheckBox();
            this.labelPlayerCustomDamage = new System.Windows.Forms.Label();
            this.CustomPlayerDamage = new System.Windows.Forms.NumericUpDown();
            this.LabelSpawnChance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.SpawnChance = new System.Windows.Forms.CheckBox();
            this.labelCustomSpawnChance = new System.Windows.Forms.Label();
            this.CustomSpawnChance = new System.Windows.Forms.NumericUpDown();
            this.LabelHunger = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultHunger = new System.Windows.Forms.CheckBox();
            this.labelCustomHunger = new System.Windows.Forms.Label();
            this.CustomHunger = new System.Windows.Forms.NumericUpDown();
            this.LabelSpeed = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultSpeed = new System.Windows.Forms.CheckBox();
            this.labelCustomSpeed = new System.Windows.Forms.Label();
            this.labelDebrisMultiplyer = new System.Windows.Forms.Label();
            this.CustomSpeed = new System.Windows.Forms.NumericUpDown();
            this.DebrisMultiplier = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultRepairCost = new System.Windows.Forms.CheckBox();
            this.labelRepairCost = new System.Windows.Forms.Label();
            this.RepairCost = new System.Windows.Forms.NumericUpDown();
            this.LabelErosionSpeed = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultErosionSpeed = new System.Windows.Forms.CheckBox();
            this.labelCustomErosionSpeed = new System.Windows.Forms.Label();
            this.CustomErosionSpeed = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultAvalancheFrequency = new System.Windows.Forms.CheckBox();
            this.labelCustomAvalancheFrequency = new System.Windows.Forms.Label();
            this.CustomAvalanchFrequncy = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.defaultAvalancheDamageToPlayers = new System.Windows.Forms.CheckBox();
            this.labelCustomAvalancheDamage = new System.Windows.Forms.Label();
            this.CustomAvalanchDamage = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultAirQuantity = new System.Windows.Forms.CheckBox();
            this.labelAirQuantity = new System.Windows.Forms.Label();
            this.AirQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultRateOfConsumption = new System.Windows.Forms.CheckBox();
            this.labelRateOfConsumption = new System.Windows.Forms.Label();
            this.RateOfConsumption = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultPowerDrain = new System.Windows.Forms.CheckBox();
            this.label21PowerDrain = new System.Windows.Forms.Label();
            this.PowerDrainMultiplier = new System.Windows.Forms.NumericUpDown();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveReachTheTile = new System.Windows.Forms.CheckBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveRescue = new System.Windows.Forms.CheckBox();
            this.labelRescueUnit = new System.Windows.Forms.Label();
            this.comboBoxRescueUnit = new System.Windows.Forms.ComboBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveSpecificUnit = new System.Windows.Forms.CheckBox();
            this.labelSpecificUnit = new System.Windows.Forms.Label();
            this.comboBoxSpecificUnit = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveSpecificBuilding = new System.Windows.Forms.CheckBox();
            this.labelSpecificBuilding = new System.Windows.Forms.Label();
            this.comboBoxSpecificBuilding = new System.Windows.Forms.ComboBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveCrystalCollection = new System.Windows.Forms.CheckBox();
            this.labelCrystalCollection = new System.Windows.Forms.Label();
            this.NeededCrystals = new System.Windows.Forms.NumericUpDown();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightIn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.LabelDamageToPlayer.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDamage)).BeginInit();
            this.LabelDamageFromPlayer.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomPlayerDamage)).BeginInit();
            this.LabelSpawnChance.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSpawnChance)).BeginInit();
            this.LabelHunger.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomHunger)).BeginInit();
            this.LabelSpeed.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebrisMultiplier)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepairCost)).BeginInit();
            this.LabelErosionSpeed.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomErosionSpeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomAvalanchFrequncy)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomAvalanchDamage)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirQuantity)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateOfConsumption)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerDrainMultiplier)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeededCrystals)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.WidthIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPowerDrain, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.PowerDrain, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelAvalanches, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Avalanche, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelHostileAI, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MapName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMapName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWidth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TerrainType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTerrainType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelErosion, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Erosion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelAirThreat, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.HostileAI, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.AirThreat, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.HeightIn, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WidthIn
            // 
            this.WidthIn.Location = new System.Drawing.Point(79, 29);
            this.WidthIn.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.WidthIn.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WidthIn.Name = "WidthIn";
            this.WidthIn.Size = new System.Drawing.Size(120, 20);
            this.WidthIn.TabIndex = 1;
            this.WidthIn.Value = global::WindowsFormsApp2.Properties.Settings.Default.Width;
            this.WidthIn.ValueChanged += new System.EventHandler(this.SetWidth);
            // 
            // labelPowerDrain
            // 
            this.labelPowerDrain.AutoSize = true;
            this.labelPowerDrain.Location = new System.Drawing.Point(3, 185);
            this.labelPowerDrain.Name = "labelPowerDrain";
            this.labelPowerDrain.Size = new System.Drawing.Size(65, 13);
            this.labelPowerDrain.TabIndex = 16;
            this.labelPowerDrain.Text = "Power Drain";
            // 
            // PowerDrain
            // 
            this.PowerDrain.AutoSize = true;
            this.PowerDrain.Location = new System.Drawing.Point(79, 188);
            this.PowerDrain.Name = "PowerDrain";
            this.PowerDrain.Size = new System.Drawing.Size(15, 14);
            this.PowerDrain.TabIndex = 8;
            this.PowerDrain.UseVisualStyleBackColor = true;
            this.PowerDrain.CheckedChanged += new System.EventHandler(this.checkBoxPowerDrain);
            // 
            // labelAvalanches
            // 
            this.labelAvalanches.AutoSize = true;
            this.labelAvalanches.Location = new System.Drawing.Point(3, 145);
            this.labelAvalanches.Name = "labelAvalanches";
            this.labelAvalanches.Size = new System.Drawing.Size(63, 13);
            this.labelAvalanches.TabIndex = 13;
            this.labelAvalanches.Text = "Avalanches";
            // 
            // Avalanche
            // 
            this.Avalanche.AutoSize = true;
            this.Avalanche.Location = new System.Drawing.Point(79, 148);
            this.Avalanche.Name = "Avalanche";
            this.Avalanche.Size = new System.Drawing.Size(15, 14);
            this.Avalanche.TabIndex = 6;
            this.Avalanche.UseVisualStyleBackColor = true;
            this.Avalanche.CheckedChanged += new System.EventHandler(this.checkBoxAvalanche);
            // 
            // labelHostileAI
            // 
            this.labelHostileAI.AutoSize = true;
            this.labelHostileAI.Location = new System.Drawing.Point(3, 105);
            this.labelHostileAI.Name = "labelHostileAI";
            this.labelHostileAI.Size = new System.Drawing.Size(55, 13);
            this.labelHostileAI.TabIndex = 9;
            this.labelHostileAI.Text = "Hostile AI:";
            // 
            // MapName
            // 
            this.MapName.AcceptsReturn = true;
            this.MapName.Location = new System.Drawing.Point(79, 3);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(138, 20);
            this.MapName.TabIndex = 0;
            this.MapName.Text = global::WindowsFormsApp2.Properties.Settings.Default.MapName;
            this.MapName.TextChanged += new System.EventHandler(this.SetMapName);
            this.MapName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapNameEnterKey);
            this.MapName.Leave += new System.EventHandler(this.SetMapName);
            // 
            // labelMapName
            // 
            this.labelMapName.AutoSize = true;
            this.labelMapName.Location = new System.Drawing.Point(3, 0);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(59, 13);
            this.labelMapName.TabIndex = 4;
            this.labelMapName.Text = "Map Name";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(3, 26);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(48, 13);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Width(X)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(3, 52);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(51, 13);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height(Y)";
            // 
            // TerrainType
            // 
            this.TerrainType.FormattingEnabled = true;
            this.TerrainType.Items.AddRange(new object[] {
            "Rock",
            "Lava",
            "Ice"});
            this.TerrainType.Location = new System.Drawing.Point(79, 81);
            this.TerrainType.Name = "TerrainType";
            this.TerrainType.Size = new System.Drawing.Size(138, 21);
            this.TerrainType.TabIndex = 3;
            this.TerrainType.Text = global::WindowsFormsApp2.Properties.Settings.Default.TerrainType;
            this.TerrainType.TextChanged += new System.EventHandler(this.SetTerrainType);
            this.TerrainType.Leave += new System.EventHandler(this.SetTerrainType);
            // 
            // labelTerrainType
            // 
            this.labelTerrainType.AutoSize = true;
            this.labelTerrainType.Location = new System.Drawing.Point(3, 78);
            this.labelTerrainType.Name = "labelTerrainType";
            this.labelTerrainType.Size = new System.Drawing.Size(70, 13);
            this.labelTerrainType.TabIndex = 8;
            this.labelTerrainType.Text = "Terrain Type:";
            // 
            // labelErosion
            // 
            this.labelErosion.AutoSize = true;
            this.labelErosion.Location = new System.Drawing.Point(3, 125);
            this.labelErosion.Name = "labelErosion";
            this.labelErosion.Size = new System.Drawing.Size(42, 13);
            this.labelErosion.TabIndex = 11;
            this.labelErosion.Text = "Erosion";
            // 
            // Erosion
            // 
            this.Erosion.AutoSize = true;
            this.Erosion.Location = new System.Drawing.Point(79, 128);
            this.Erosion.Name = "Erosion";
            this.Erosion.Size = new System.Drawing.Size(15, 14);
            this.Erosion.TabIndex = 5;
            this.Erosion.UseVisualStyleBackColor = true;
            this.Erosion.CheckedChanged += new System.EventHandler(this.checkBoxErosion);
            // 
            // labelAirThreat
            // 
            this.labelAirThreat.AutoSize = true;
            this.labelAirThreat.Location = new System.Drawing.Point(3, 165);
            this.labelAirThreat.Name = "labelAirThreat";
            this.labelAirThreat.Size = new System.Drawing.Size(53, 13);
            this.labelAirThreat.TabIndex = 15;
            this.labelAirThreat.Text = "Air Threat";
            // 
            // HostileAI
            // 
            this.HostileAI.AutoSize = true;
            this.HostileAI.Location = new System.Drawing.Point(79, 108);
            this.HostileAI.Name = "HostileAI";
            this.HostileAI.Size = new System.Drawing.Size(15, 14);
            this.HostileAI.TabIndex = 4;
            this.HostileAI.UseVisualStyleBackColor = true;
            this.HostileAI.CheckedChanged += new System.EventHandler(this.checkBoxHostileAI);
            // 
            // AirThreat
            // 
            this.AirThreat.AutoSize = true;
            this.AirThreat.Location = new System.Drawing.Point(79, 168);
            this.AirThreat.Name = "AirThreat";
            this.AirThreat.Size = new System.Drawing.Size(15, 14);
            this.AirThreat.TabIndex = 7;
            this.AirThreat.UseVisualStyleBackColor = true;
            this.AirThreat.CheckedChanged += new System.EventHandler(this.checkBoxAirThreat);
            // 
            // HeightIn
            // 
            this.HeightIn.Location = new System.Drawing.Point(79, 55);
            this.HeightIn.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.HeightIn.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HeightIn.Name = "HeightIn";
            this.HeightIn.Size = new System.Drawing.Size(120, 20);
            this.HeightIn.TabIndex = 2;
            this.HeightIn.Value = global::WindowsFormsApp2.Properties.Settings.Default.Height;
            this.HeightIn.ValueChanged += new System.EventHandler(this.SetHeight);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(761, 427);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foundations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tabs);
            this.groupBox2.Location = new System.Drawing.Point(252, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 793);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Controls.Add(this.tabPage6);
            this.Tabs.Controls.Add(this.tabPage7);
            this.Tabs.Location = new System.Drawing.Point(6, 19);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(492, 363);
            this.Tabs.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enemy Ai";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LabelDamageToPlayer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LabelDamageFromPlayer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LabelSpawnChance, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.LabelHunger, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.LabelSpeed, 0, 3);
            this.tableLayoutPanel3.Enabled = false;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-4, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(470, 387);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LabelDamageToPlayer
            // 
            this.LabelDamageToPlayer.Controls.Add(this.tableLayoutPanel4);
            this.LabelDamageToPlayer.Location = new System.Drawing.Point(3, 3);
            this.LabelDamageToPlayer.Name = "LabelDamageToPlayer";
            this.LabelDamageToPlayer.Size = new System.Drawing.Size(464, 55);
            this.LabelDamageToPlayer.TabIndex = 0;
            this.LabelDamageToPlayer.TabStop = false;
            this.LabelDamageToPlayer.Text = "Damage to Player";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel4.Controls.Add(this.DefaultPlayerDamage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelCustomDamage, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.CustomDamage, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // DefaultPlayerDamage
            // 
            this.DefaultPlayerDamage.AutoSize = true;
            this.DefaultPlayerDamage.Checked = true;
            this.DefaultPlayerDamage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultPlayerDamage.Location = new System.Drawing.Point(3, 3);
            this.DefaultPlayerDamage.Name = "DefaultPlayerDamage";
            this.DefaultPlayerDamage.Size = new System.Drawing.Size(60, 17);
            this.DefaultPlayerDamage.TabIndex = 10;
            this.DefaultPlayerDamage.Text = "Default";
            this.DefaultPlayerDamage.UseVisualStyleBackColor = true;
            this.DefaultPlayerDamage.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // labelCustomDamage
            // 
            this.labelCustomDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomDamage.AutoSize = true;
            this.labelCustomDamage.Location = new System.Drawing.Point(117, 5);
            this.labelCustomDamage.Name = "labelCustomDamage";
            this.labelCustomDamage.Size = new System.Drawing.Size(120, 13);
            this.labelCustomDamage.TabIndex = 2;
            this.labelCustomDamage.Text = "Custom Damage:";
            // 
            // CustomDamage
            // 
            this.CustomDamage.Enabled = false;
            this.CustomDamage.Location = new System.Drawing.Point(243, 3);
            this.CustomDamage.Name = "CustomDamage";
            this.CustomDamage.Size = new System.Drawing.Size(120, 20);
            this.CustomDamage.TabIndex = 11;
            this.CustomDamage.Value = global::WindowsFormsApp2.Properties.Settings.Default.DamageToPlayer;
            this.CustomDamage.ValueChanged += new System.EventHandler(this.CustomValue_DamageToPlayer);
            // 
            // LabelDamageFromPlayer
            // 
            this.LabelDamageFromPlayer.Controls.Add(this.tableLayoutPanel5);
            this.LabelDamageFromPlayer.Location = new System.Drawing.Point(3, 64);
            this.LabelDamageFromPlayer.Name = "LabelDamageFromPlayer";
            this.LabelDamageFromPlayer.Size = new System.Drawing.Size(464, 56);
            this.LabelDamageFromPlayer.TabIndex = 1;
            this.LabelDamageFromPlayer.TabStop = false;
            this.LabelDamageFromPlayer.Text = "Damage from Player";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel5.Controls.Add(this.DefaultDamageFromPlayer, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelPlayerCustomDamage, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.CustomPlayerDamage, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 13);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(451, 27);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // DefaultDamageFromPlayer
            // 
            this.DefaultDamageFromPlayer.AutoSize = true;
            this.DefaultDamageFromPlayer.Checked = true;
            this.DefaultDamageFromPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDamageFromPlayer.Location = new System.Drawing.Point(3, 3);
            this.DefaultDamageFromPlayer.Name = "DefaultDamageFromPlayer";
            this.DefaultDamageFromPlayer.Size = new System.Drawing.Size(60, 17);
            this.DefaultDamageFromPlayer.TabIndex = 12;
            this.DefaultDamageFromPlayer.Text = "Default";
            this.DefaultDamageFromPlayer.UseVisualStyleBackColor = true;
            this.DefaultDamageFromPlayer.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // labelPlayerCustomDamage
            // 
            this.labelPlayerCustomDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerCustomDamage.AutoSize = true;
            this.labelPlayerCustomDamage.Location = new System.Drawing.Point(118, 7);
            this.labelPlayerCustomDamage.Name = "labelPlayerCustomDamage";
            this.labelPlayerCustomDamage.Size = new System.Drawing.Size(121, 13);
            this.labelPlayerCustomDamage.TabIndex = 2;
            this.labelPlayerCustomDamage.Text = "Custom Damage:";
            // 
            // CustomPlayerDamage
            // 
            this.CustomPlayerDamage.Enabled = false;
            this.CustomPlayerDamage.Location = new System.Drawing.Point(245, 3);
            this.CustomPlayerDamage.Name = "CustomPlayerDamage";
            this.CustomPlayerDamage.Size = new System.Drawing.Size(120, 20);
            this.CustomPlayerDamage.TabIndex = 13;
            this.CustomPlayerDamage.Value = global::WindowsFormsApp2.Properties.Settings.Default.DamageFromPlayer;
            this.CustomPlayerDamage.ValueChanged += new System.EventHandler(this.CustomValue_DamageFromPlayer);
            // 
            // LabelSpawnChance
            // 
            this.LabelSpawnChance.Controls.Add(this.tableLayoutPanel8);
            this.LabelSpawnChance.Location = new System.Drawing.Point(3, 285);
            this.LabelSpawnChance.Name = "LabelSpawnChance";
            this.LabelSpawnChance.Size = new System.Drawing.Size(464, 56);
            this.LabelSpawnChance.TabIndex = 1;
            this.LabelSpawnChance.TabStop = false;
            this.LabelSpawnChance.Text = "Spawn Chance";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel8.Controls.Add(this.SpawnChance, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelCustomSpawnChance, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.CustomSpawnChance, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(7, 13);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(451, 30);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // SpawnChance
            // 
            this.SpawnChance.AutoSize = true;
            this.SpawnChance.Checked = true;
            this.SpawnChance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpawnChance.Location = new System.Drawing.Point(3, 3);
            this.SpawnChance.Name = "SpawnChance";
            this.SpawnChance.Size = new System.Drawing.Size(60, 17);
            this.SpawnChance.TabIndex = 19;
            this.SpawnChance.Text = "Default";
            this.SpawnChance.UseVisualStyleBackColor = true;
            this.SpawnChance.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // labelCustomSpawnChance
            // 
            this.labelCustomSpawnChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomSpawnChance.AutoSize = true;
            this.labelCustomSpawnChance.Location = new System.Drawing.Point(119, 8);
            this.labelCustomSpawnChance.Name = "labelCustomSpawnChance";
            this.labelCustomSpawnChance.Size = new System.Drawing.Size(122, 13);
            this.labelCustomSpawnChance.TabIndex = 2;
            this.labelCustomSpawnChance.Text = "Custom Chance";
            // 
            // CustomSpawnChance
            // 
            this.CustomSpawnChance.Enabled = false;
            this.CustomSpawnChance.Location = new System.Drawing.Point(247, 3);
            this.CustomSpawnChance.Name = "CustomSpawnChance";
            this.CustomSpawnChance.Size = new System.Drawing.Size(119, 20);
            this.CustomSpawnChance.TabIndex = 20;
            this.CustomSpawnChance.Value = global::WindowsFormsApp2.Properties.Settings.Default.SpawnChance;
            this.CustomSpawnChance.ValueChanged += new System.EventHandler(this.CustomValue_Spawn);
            // 
            // LabelHunger
            // 
            this.LabelHunger.Controls.Add(this.tableLayoutPanel9);
            this.LabelHunger.Location = new System.Drawing.Point(3, 223);
            this.LabelHunger.Name = "LabelHunger";
            this.LabelHunger.Size = new System.Drawing.Size(462, 56);
            this.LabelHunger.TabIndex = 3;
            this.LabelHunger.TabStop = false;
            this.LabelHunger.Text = "Hunger";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel9.Controls.Add(this.DefaultHunger, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelCustomHunger, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.CustomHunger, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(7, 18);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(451, 27);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // DefaultHunger
            // 
            this.DefaultHunger.AutoSize = true;
            this.DefaultHunger.Checked = true;
            this.DefaultHunger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultHunger.Location = new System.Drawing.Point(3, 3);
            this.DefaultHunger.Name = "DefaultHunger";
            this.DefaultHunger.Size = new System.Drawing.Size(60, 17);
            this.DefaultHunger.TabIndex = 17;
            this.DefaultHunger.Text = "Default";
            this.DefaultHunger.UseVisualStyleBackColor = true;
            this.DefaultHunger.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // labelCustomHunger
            // 
            this.labelCustomHunger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomHunger.AutoSize = true;
            this.labelCustomHunger.Location = new System.Drawing.Point(118, 7);
            this.labelCustomHunger.Name = "labelCustomHunger";
            this.labelCustomHunger.Size = new System.Drawing.Size(121, 13);
            this.labelCustomHunger.TabIndex = 2;
            this.labelCustomHunger.Text = "Custom Hunger:";
            // 
            // CustomHunger
            // 
            this.CustomHunger.Enabled = false;
            this.CustomHunger.Location = new System.Drawing.Point(245, 3);
            this.CustomHunger.Name = "CustomHunger";
            this.CustomHunger.Size = new System.Drawing.Size(120, 20);
            this.CustomHunger.TabIndex = 18;
            this.CustomHunger.Value = global::WindowsFormsApp2.Properties.Settings.Default.Hunger;
            this.CustomHunger.ValueChanged += new System.EventHandler(this.CustomValue_HungerValue);
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.Controls.Add(this.tableLayoutPanel7);
            this.LabelSpeed.Location = new System.Drawing.Point(3, 126);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(464, 91);
            this.LabelSpeed.TabIndex = 1;
            this.LabelSpeed.TabStop = false;
            this.LabelSpeed.Text = "Speed";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel7.Controls.Add(this.DefaultSpeed, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelCustomSpeed, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelDebrisMultiplyer, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.CustomSpeed, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.DebrisMultiplier, 2, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(451, 64);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // DefaultSpeed
            // 
            this.DefaultSpeed.AutoSize = true;
            this.DefaultSpeed.Checked = true;
            this.DefaultSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultSpeed.Location = new System.Drawing.Point(3, 3);
            this.DefaultSpeed.Name = "DefaultSpeed";
            this.DefaultSpeed.Size = new System.Drawing.Size(60, 17);
            this.DefaultSpeed.TabIndex = 14;
            this.DefaultSpeed.Text = "Default";
            this.DefaultSpeed.UseVisualStyleBackColor = true;
            this.DefaultSpeed.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // labelCustomSpeed
            // 
            this.labelCustomSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomSpeed.AutoSize = true;
            this.labelCustomSpeed.Location = new System.Drawing.Point(118, 9);
            this.labelCustomSpeed.Name = "labelCustomSpeed";
            this.labelCustomSpeed.Size = new System.Drawing.Size(121, 13);
            this.labelCustomSpeed.TabIndex = 2;
            this.labelCustomSpeed.Text = "Custom Speed:";
            // 
            // labelDebrisMultiplyer
            // 
            this.labelDebrisMultiplyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDebrisMultiplyer.AutoSize = true;
            this.labelDebrisMultiplyer.Location = new System.Drawing.Point(118, 41);
            this.labelDebrisMultiplyer.Name = "labelDebrisMultiplyer";
            this.labelDebrisMultiplyer.Size = new System.Drawing.Size(121, 13);
            this.labelDebrisMultiplyer.TabIndex = 3;
            this.labelDebrisMultiplyer.Text = "Debris Multiplier:";
            // 
            // CustomSpeed
            // 
            this.CustomSpeed.Enabled = false;
            this.CustomSpeed.Location = new System.Drawing.Point(245, 3);
            this.CustomSpeed.Name = "CustomSpeed";
            this.CustomSpeed.Size = new System.Drawing.Size(120, 20);
            this.CustomSpeed.TabIndex = 15;
            this.CustomSpeed.Value = global::WindowsFormsApp2.Properties.Settings.Default.CreatureSpeed;
            this.CustomSpeed.ValueChanged += new System.EventHandler(this.CustomValue_CreatureSpeed);
            // 
            // DebrisMultiplier
            // 
            this.DebrisMultiplier.Enabled = false;
            this.DebrisMultiplier.Location = new System.Drawing.Point(245, 35);
            this.DebrisMultiplier.Name = "DebrisMultiplier";
            this.DebrisMultiplier.Size = new System.Drawing.Size(120, 20);
            this.DebrisMultiplier.TabIndex = 16;
            this.DebrisMultiplier.Value = global::WindowsFormsApp2.Properties.Settings.Default.DebrisMultiplier;
            this.DebrisMultiplier.ValueChanged += new System.EventHandler(this.CustomValue_DebrisMultiplier);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Erosion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.70712F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelErosionSpeed, 0, 0);
            this.tableLayoutPanel2.Enabled = false;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.76647F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.23354F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 334);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel13);
            this.groupBox6.Location = new System.Drawing.Point(3, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(464, 55);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Repair Cost";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.Controls.Add(this.DefaultRepairCost, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.labelRepairCost, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.RepairCost, 2, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // DefaultRepairCost
            // 
            this.DefaultRepairCost.AutoSize = true;
            this.DefaultRepairCost.Checked = true;
            this.DefaultRepairCost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultRepairCost.Location = new System.Drawing.Point(3, 3);
            this.DefaultRepairCost.Name = "DefaultRepairCost";
            this.DefaultRepairCost.Size = new System.Drawing.Size(60, 17);
            this.DefaultRepairCost.TabIndex = 23;
            this.DefaultRepairCost.Text = "Default";
            this.DefaultRepairCost.UseVisualStyleBackColor = true;
            this.DefaultRepairCost.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // labelRepairCost
            // 
            this.labelRepairCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRepairCost.AutoSize = true;
            this.labelRepairCost.Location = new System.Drawing.Point(118, 5);
            this.labelRepairCost.Name = "labelRepairCost";
            this.labelRepairCost.Size = new System.Drawing.Size(121, 13);
            this.labelRepairCost.TabIndex = 2;
            this.labelRepairCost.Text = "Repair Cost:";
            // 
            // RepairCost
            // 
            this.RepairCost.Enabled = false;
            this.RepairCost.Location = new System.Drawing.Point(245, 3);
            this.RepairCost.Name = "RepairCost";
            this.RepairCost.Size = new System.Drawing.Size(120, 20);
            this.RepairCost.TabIndex = 24;
            this.RepairCost.Value = global::WindowsFormsApp2.Properties.Settings.Default.RepairCost;
            this.RepairCost.ValueChanged += new System.EventHandler(this.CustomValue_RepairCost);
            // 
            // LabelErosionSpeed
            // 
            this.LabelErosionSpeed.Controls.Add(this.tableLayoutPanel6);
            this.LabelErosionSpeed.Location = new System.Drawing.Point(3, 3);
            this.LabelErosionSpeed.Name = "LabelErosionSpeed";
            this.LabelErosionSpeed.Size = new System.Drawing.Size(464, 49);
            this.LabelErosionSpeed.TabIndex = 1;
            this.LabelErosionSpeed.TabStop = false;
            this.LabelErosionSpeed.Text = "Erosion Speed";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel6.Controls.Add(this.DefaultErosionSpeed, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelCustomErosionSpeed, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.CustomErosionSpeed, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // DefaultErosionSpeed
            // 
            this.DefaultErosionSpeed.AutoSize = true;
            this.DefaultErosionSpeed.Checked = true;
            this.DefaultErosionSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultErosionSpeed.Location = new System.Drawing.Point(3, 3);
            this.DefaultErosionSpeed.Name = "DefaultErosionSpeed";
            this.DefaultErosionSpeed.Size = new System.Drawing.Size(60, 17);
            this.DefaultErosionSpeed.TabIndex = 21;
            this.DefaultErosionSpeed.Text = "Default";
            this.DefaultErosionSpeed.UseVisualStyleBackColor = true;
            this.DefaultErosionSpeed.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // labelCustomErosionSpeed
            // 
            this.labelCustomErosionSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomErosionSpeed.AutoSize = true;
            this.labelCustomErosionSpeed.Location = new System.Drawing.Point(118, 5);
            this.labelCustomErosionSpeed.Name = "labelCustomErosionSpeed";
            this.labelCustomErosionSpeed.Size = new System.Drawing.Size(121, 13);
            this.labelCustomErosionSpeed.TabIndex = 2;
            this.labelCustomErosionSpeed.Text = "Custom Speed:";
            // 
            // CustomErosionSpeed
            // 
            this.CustomErosionSpeed.Enabled = false;
            this.CustomErosionSpeed.Location = new System.Drawing.Point(245, 3);
            this.CustomErosionSpeed.Name = "CustomErosionSpeed";
            this.CustomErosionSpeed.Size = new System.Drawing.Size(120, 20);
            this.CustomErosionSpeed.TabIndex = 22;
            this.CustomErosionSpeed.Value = global::WindowsFormsApp2.Properties.Settings.Default.ErosionSpeed;
            this.CustomErosionSpeed.ValueChanged += new System.EventHandler(this.CustomValue_Erosion);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tableLayoutPanel10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(484, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Avalanche";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.70712F));
            this.tableLayoutPanel10.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel10.Enabled = false;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76048F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23952F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(478, 334);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel12);
            this.groupBox5.Location = new System.Drawing.Point(3, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 55);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequency";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel12.Controls.Add(this.DefaultAvalancheFrequency, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.labelCustomAvalancheFrequency, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.CustomAvalanchFrequncy, 2, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // DefaultAvalancheFrequency
            // 
            this.DefaultAvalancheFrequency.AutoSize = true;
            this.DefaultAvalancheFrequency.Checked = true;
            this.DefaultAvalancheFrequency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultAvalancheFrequency.Location = new System.Drawing.Point(3, 3);
            this.DefaultAvalancheFrequency.Name = "DefaultAvalancheFrequency";
            this.DefaultAvalancheFrequency.Size = new System.Drawing.Size(60, 17);
            this.DefaultAvalancheFrequency.TabIndex = 27;
            this.DefaultAvalancheFrequency.Text = "Default";
            this.DefaultAvalancheFrequency.UseVisualStyleBackColor = true;
            this.DefaultAvalancheFrequency.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // labelCustomAvalancheFrequency
            // 
            this.labelCustomAvalancheFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomAvalancheFrequency.AutoSize = true;
            this.labelCustomAvalancheFrequency.Location = new System.Drawing.Point(118, 5);
            this.labelCustomAvalancheFrequency.Name = "labelCustomAvalancheFrequency";
            this.labelCustomAvalancheFrequency.Size = new System.Drawing.Size(119, 13);
            this.labelCustomAvalancheFrequency.TabIndex = 2;
            this.labelCustomAvalancheFrequency.Text = "Custom Frequency:";
            // 
            // CustomAvalanchFrequncy
            // 
            this.CustomAvalanchFrequncy.Enabled = false;
            this.CustomAvalanchFrequncy.Location = new System.Drawing.Point(243, 3);
            this.CustomAvalanchFrequncy.Name = "CustomAvalanchFrequncy";
            this.CustomAvalanchFrequncy.Size = new System.Drawing.Size(120, 20);
            this.CustomAvalanchFrequncy.TabIndex = 28;
            this.CustomAvalanchFrequncy.Value = global::WindowsFormsApp2.Properties.Settings.Default.Frequency;
            this.CustomAvalanchFrequncy.ValueChanged += new System.EventHandler(this.CustomValue_AvalancheFrequency);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel11);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 55);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Damage to Player";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel11.Controls.Add(this.defaultAvalancheDamageToPlayers, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.labelCustomAvalancheDamage, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.CustomAvalanchDamage, 2, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // defaultAvalancheDamageToPlayers
            // 
            this.defaultAvalancheDamageToPlayers.AutoSize = true;
            this.defaultAvalancheDamageToPlayers.Checked = true;
            this.defaultAvalancheDamageToPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultAvalancheDamageToPlayers.Location = new System.Drawing.Point(3, 3);
            this.defaultAvalancheDamageToPlayers.Name = "defaultAvalancheDamageToPlayers";
            this.defaultAvalancheDamageToPlayers.Size = new System.Drawing.Size(60, 17);
            this.defaultAvalancheDamageToPlayers.TabIndex = 25;
            this.defaultAvalancheDamageToPlayers.Text = "Default";
            this.defaultAvalancheDamageToPlayers.UseVisualStyleBackColor = true;
            this.defaultAvalancheDamageToPlayers.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // labelCustomAvalancheDamage
            // 
            this.labelCustomAvalancheDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomAvalancheDamage.AutoSize = true;
            this.labelCustomAvalancheDamage.Location = new System.Drawing.Point(118, 5);
            this.labelCustomAvalancheDamage.Name = "labelCustomAvalancheDamage";
            this.labelCustomAvalancheDamage.Size = new System.Drawing.Size(121, 13);
            this.labelCustomAvalancheDamage.TabIndex = 2;
            this.labelCustomAvalancheDamage.Text = "Custom Damage:";
            // 
            // CustomAvalanchDamage
            // 
            this.CustomAvalanchDamage.Enabled = false;
            this.CustomAvalanchDamage.Location = new System.Drawing.Point(245, 3);
            this.CustomAvalanchDamage.Name = "CustomAvalanchDamage";
            this.CustomAvalanchDamage.Size = new System.Drawing.Size(120, 20);
            this.CustomAvalanchDamage.TabIndex = 26;
            this.CustomAvalanchDamage.Value = global::WindowsFormsApp2.Properties.Settings.Default.AvalancheDamageToPlayer;
            this.CustomAvalanchDamage.ValueChanged += new System.EventHandler(this.CustomValue_AvalancheDamageToPlayer);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.tableLayoutPanel14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(484, 337);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Air";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.70712F));
            this.tableLayoutPanel14.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel14.Enabled = false;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76048F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23952F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(478, 334);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel15);
            this.groupBox7.Location = new System.Drawing.Point(3, 69);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(464, 55);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Air Quantity";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10695F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89305F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel15.Controls.Add(this.DefaultAirQuantity, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.labelAirQuantity, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.AirQuantity, 2, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // DefaultAirQuantity
            // 
            this.DefaultAirQuantity.AutoSize = true;
            this.DefaultAirQuantity.Checked = true;
            this.DefaultAirQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultAirQuantity.Location = new System.Drawing.Point(3, 3);
            this.DefaultAirQuantity.Name = "DefaultAirQuantity";
            this.DefaultAirQuantity.Size = new System.Drawing.Size(60, 17);
            this.DefaultAirQuantity.TabIndex = 31;
            this.DefaultAirQuantity.Text = "Default";
            this.DefaultAirQuantity.UseVisualStyleBackColor = true;
            this.DefaultAirQuantity.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // labelAirQuantity
            // 
            this.labelAirQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAirQuantity.AutoSize = true;
            this.labelAirQuantity.Location = new System.Drawing.Point(100, 5);
            this.labelAirQuantity.Name = "labelAirQuantity";
            this.labelAirQuantity.Size = new System.Drawing.Size(140, 13);
            this.labelAirQuantity.TabIndex = 2;
            this.labelAirQuantity.Text = "Custom Level:";
            // 
            // AirQuantity
            // 
            this.AirQuantity.Enabled = false;
            this.AirQuantity.Location = new System.Drawing.Point(246, 3);
            this.AirQuantity.Name = "AirQuantity";
            this.AirQuantity.Size = new System.Drawing.Size(120, 20);
            this.AirQuantity.TabIndex = 32;
            this.AirQuantity.Value = global::WindowsFormsApp2.Properties.Settings.Default.AirQuantity;
            this.AirQuantity.ValueChanged += new System.EventHandler(this.CustomValue_AirQuantity);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel16);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(464, 55);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " Rate of Consumption";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel16.Controls.Add(this.DefaultRateOfConsumption, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.labelRateOfConsumption, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.RateOfConsumption, 2, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // DefaultRateOfConsumption
            // 
            this.DefaultRateOfConsumption.AutoSize = true;
            this.DefaultRateOfConsumption.Checked = true;
            this.DefaultRateOfConsumption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultRateOfConsumption.Location = new System.Drawing.Point(3, 3);
            this.DefaultRateOfConsumption.Name = "DefaultRateOfConsumption";
            this.DefaultRateOfConsumption.Size = new System.Drawing.Size(60, 17);
            this.DefaultRateOfConsumption.TabIndex = 29;
            this.DefaultRateOfConsumption.Text = "Default";
            this.DefaultRateOfConsumption.UseVisualStyleBackColor = true;
            this.DefaultRateOfConsumption.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // labelRateOfConsumption
            // 
            this.labelRateOfConsumption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRateOfConsumption.AutoSize = true;
            this.labelRateOfConsumption.Location = new System.Drawing.Point(102, 5);
            this.labelRateOfConsumption.Name = "labelRateOfConsumption";
            this.labelRateOfConsumption.Size = new System.Drawing.Size(138, 13);
            this.labelRateOfConsumption.TabIndex = 2;
            this.labelRateOfConsumption.Text = " Custom Consumption:";
            // 
            // RateOfConsumption
            // 
            this.RateOfConsumption.Enabled = false;
            this.RateOfConsumption.Location = new System.Drawing.Point(246, 3);
            this.RateOfConsumption.Name = "RateOfConsumption";
            this.RateOfConsumption.Size = new System.Drawing.Size(120, 20);
            this.RateOfConsumption.TabIndex = 30;
            this.RateOfConsumption.UseWaitCursor = true;
            this.RateOfConsumption.Value = global::WindowsFormsApp2.Properties.Settings.Default.RateOfConsumption;
            this.RateOfConsumption.ValueChanged += new System.EventHandler(this.CustomValue_RateOfConsumption);
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.tableLayoutPanel17);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(484, 337);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Power Drain";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.70712F));
            this.tableLayoutPanel17.Controls.Add(this.groupBox15, 0, 0);
            this.tableLayoutPanel17.Enabled = false;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76048F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23952F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(478, 334);
            this.tableLayoutPanel17.TabIndex = 3;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.tableLayoutPanel19);
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(464, 55);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Usage multiplier";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71186F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.28814F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel19.Controls.Add(this.DefaultPowerDrain, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.label21PowerDrain, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.PowerDrainMultiplier, 2, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // DefaultPowerDrain
            // 
            this.DefaultPowerDrain.AutoSize = true;
            this.DefaultPowerDrain.Checked = true;
            this.DefaultPowerDrain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultPowerDrain.Location = new System.Drawing.Point(3, 3);
            this.DefaultPowerDrain.Name = "DefaultPowerDrain";
            this.DefaultPowerDrain.Size = new System.Drawing.Size(60, 17);
            this.DefaultPowerDrain.TabIndex = 33;
            this.DefaultPowerDrain.Text = "Default";
            this.DefaultPowerDrain.UseVisualStyleBackColor = true;
            this.DefaultPowerDrain.CheckStateChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // label21PowerDrain
            // 
            this.label21PowerDrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21PowerDrain.AutoSize = true;
            this.label21PowerDrain.Location = new System.Drawing.Point(95, 5);
            this.label21PowerDrain.Name = "label21PowerDrain";
            this.label21PowerDrain.Size = new System.Drawing.Size(147, 13);
            this.label21PowerDrain.TabIndex = 2;
            this.label21PowerDrain.Text = " Custom Multiplier:";
            // 
            // PowerDrainMultiplier
            // 
            this.PowerDrainMultiplier.Enabled = false;
            this.PowerDrainMultiplier.Location = new System.Drawing.Point(248, 3);
            this.PowerDrainMultiplier.Name = "PowerDrainMultiplier";
            this.PowerDrainMultiplier.Size = new System.Drawing.Size(118, 20);
            this.PowerDrainMultiplier.TabIndex = 34;
            this.PowerDrainMultiplier.Value = global::WindowsFormsApp2.Properties.Settings.Default.PowerDrainMultiplier;
            this.PowerDrainMultiplier.ValueChanged += new System.EventHandler(this.CustomValue_PowerDrainMultiplier);
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.tableLayoutPanel18);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(484, 337);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Win State";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.groupBox19, 0, 4);
            this.tableLayoutPanel18.Controls.Add(this.groupBox18, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.groupBox17, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.groupBox13, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.groupBox16, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 5;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(478, 334);
            this.tableLayoutPanel18.TabIndex = 1;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.tableLayoutPanel24);
            this.groupBox19.Location = new System.Drawing.Point(3, 246);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(464, 59);
            this.groupBox19.TabIndex = 5;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Reach the Tile";
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 3;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.62948F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.37052F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel24.Controls.Add(this.ActiveReachTheTile, 0, 0);
            this.tableLayoutPanel24.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel24.TabIndex = 0;
            // 
            // ActiveReachTheTile
            // 
            this.ActiveReachTheTile.AutoSize = true;
            this.ActiveReachTheTile.Location = new System.Drawing.Point(3, 3);
            this.ActiveReachTheTile.Name = "ActiveReachTheTile";
            this.ActiveReachTheTile.Size = new System.Drawing.Size(56, 17);
            this.ActiveReachTheTile.TabIndex = 43;
            this.ActiveReachTheTile.Text = "Active";
            this.ActiveReachTheTile.UseVisualStyleBackColor = true;
            this.ActiveReachTheTile.CheckedChanged += new System.EventHandler(this.checkbox23_CheckedChanged);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.tableLayoutPanel23);
            this.groupBox18.Location = new System.Drawing.Point(3, 181);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(464, 59);
            this.groupBox18.TabIndex = 4;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Rescue Specific Unit";
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 3;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53312F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.46688F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel23.Controls.Add(this.ActiveRescue, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.labelRescueUnit, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.comboBoxRescueUnit, 2, 0);
            this.tableLayoutPanel23.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // ActiveRescue
            // 
            this.ActiveRescue.AutoSize = true;
            this.ActiveRescue.Location = new System.Drawing.Point(3, 3);
            this.ActiveRescue.Name = "ActiveRescue";
            this.ActiveRescue.Size = new System.Drawing.Size(56, 17);
            this.ActiveRescue.TabIndex = 41;
            this.ActiveRescue.Text = "Active";
            this.ActiveRescue.UseVisualStyleBackColor = true;
            this.ActiveRescue.CheckedChanged += new System.EventHandler(this.checkBox22_CheckedChanged);
            // 
            // labelRescueUnit
            // 
            this.labelRescueUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRescueUnit.AutoSize = true;
            this.labelRescueUnit.Location = new System.Drawing.Point(105, 5);
            this.labelRescueUnit.Name = "labelRescueUnit";
            this.labelRescueUnit.Size = new System.Drawing.Size(127, 13);
            this.labelRescueUnit.TabIndex = 2;
            this.labelRescueUnit.Text = "Specify unit:";
            // 
            // comboBoxRescueUnit
            // 
            this.comboBoxRescueUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRescueUnit.Enabled = false;
            this.comboBoxRescueUnit.FormattingEnabled = true;
            this.comboBoxRescueUnit.Items.AddRange(new object[] {
            "Miner",
            "Miner -Demolition",
            "Miner -Driver",
            "Miner -Geologist",
            "Miner -Veteran",
            "Miner - Soldier",
            "Small Truck",
            "Small Mining Truck",
            "Small Mining Vehicle",
            "Small RC Scout",
            "Ultra Light Copter",
            "Boat",
            "Cargo Boat",
            "Loader",
            "Heavy Mining Vehicle",
            "Lazer Mining Vehicle",
            "Mammoth",
            " "});
            this.comboBoxRescueUnit.Location = new System.Drawing.Point(238, 3);
            this.comboBoxRescueUnit.Name = "comboBoxRescueUnit";
            this.comboBoxRescueUnit.Size = new System.Drawing.Size(128, 21);
            this.comboBoxRescueUnit.TabIndex = 42;
            this.comboBoxRescueUnit.Text = global::WindowsFormsApp2.Properties.Settings.Default.SpecificRescueUnit;
            this.comboBoxRescueUnit.TextChanged += new System.EventHandler(this.CustomValue_SpecificRescueUnit);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.tableLayoutPanel22);
            this.groupBox17.Location = new System.Drawing.Point(3, 116);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(464, 59);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Build Specific Unit";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.23602F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.76398F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel22.Controls.Add(this.ActiveSpecificUnit, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.labelSpecificUnit, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.comboBoxSpecificUnit, 2, 0);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel22.TabIndex = 0;
            // 
            // ActiveSpecificUnit
            // 
            this.ActiveSpecificUnit.AutoSize = true;
            this.ActiveSpecificUnit.Location = new System.Drawing.Point(3, 3);
            this.ActiveSpecificUnit.Name = "ActiveSpecificUnit";
            this.ActiveSpecificUnit.Size = new System.Drawing.Size(56, 17);
            this.ActiveSpecificUnit.TabIndex = 39;
            this.ActiveSpecificUnit.Text = "Active";
            this.ActiveSpecificUnit.UseVisualStyleBackColor = true;
            this.ActiveSpecificUnit.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // labelSpecificUnit
            // 
            this.labelSpecificUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpecificUnit.AutoSize = true;
            this.labelSpecificUnit.Location = new System.Drawing.Point(104, 5);
            this.labelSpecificUnit.Name = "labelSpecificUnit";
            this.labelSpecificUnit.Size = new System.Drawing.Size(133, 13);
            this.labelSpecificUnit.TabIndex = 2;
            this.labelSpecificUnit.Text = "Specify unit:";
            // 
            // comboBoxSpecificUnit
            // 
            this.comboBoxSpecificUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecificUnit.Enabled = false;
            this.comboBoxSpecificUnit.FormattingEnabled = true;
            this.comboBoxSpecificUnit.Items.AddRange(new object[] {
            "Miner",
            "Miner -Demolition",
            "Miner -Driver",
            "Miner -Geologist",
            "Miner -Veteran",
            "Miner - Soldier",
            "Small Truck",
            "Small Mining Truck",
            "Small Mining Vehicle",
            "Small RC Scout",
            "Ultra Light Copter",
            "Boat",
            "Cargo Boat",
            "Loader",
            "Heavy Mining Vehicle",
            "Lazer Mining Vehicle",
            "Mammoth",
            " "});
            this.comboBoxSpecificUnit.Location = new System.Drawing.Point(243, 3);
            this.comboBoxSpecificUnit.Name = "comboBoxSpecificUnit";
            this.comboBoxSpecificUnit.Size = new System.Drawing.Size(123, 21);
            this.comboBoxSpecificUnit.TabIndex = 40;
            this.comboBoxSpecificUnit.Text = global::WindowsFormsApp2.Properties.Settings.Default.SpecificUnit;
            this.comboBoxSpecificUnit.TextChanged += new System.EventHandler(this.CustomValue_SpecificUnit);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.tableLayoutPanel20);
            this.groupBox13.Location = new System.Drawing.Point(3, 55);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(464, 55);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Build Specific Building";
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 3;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel20.Controls.Add(this.ActiveSpecificBuilding, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.labelSpecificBuilding, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.comboBoxSpecificBuilding, 2, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // ActiveSpecificBuilding
            // 
            this.ActiveSpecificBuilding.AutoSize = true;
            this.ActiveSpecificBuilding.Location = new System.Drawing.Point(3, 3);
            this.ActiveSpecificBuilding.Name = "ActiveSpecificBuilding";
            this.ActiveSpecificBuilding.Size = new System.Drawing.Size(56, 17);
            this.ActiveSpecificBuilding.TabIndex = 37;
            this.ActiveSpecificBuilding.Text = "Active";
            this.ActiveSpecificBuilding.UseVisualStyleBackColor = true;
            this.ActiveSpecificBuilding.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // labelSpecificBuilding
            // 
            this.labelSpecificBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpecificBuilding.AutoSize = true;
            this.labelSpecificBuilding.Location = new System.Drawing.Point(104, 5);
            this.labelSpecificBuilding.Name = "labelSpecificBuilding";
            this.labelSpecificBuilding.Size = new System.Drawing.Size(134, 13);
            this.labelSpecificBuilding.TabIndex = 2;
            this.labelSpecificBuilding.Text = "Specify Building:";
            // 
            // comboBoxSpecificBuilding
            // 
            this.comboBoxSpecificBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecificBuilding.Enabled = false;
            this.comboBoxSpecificBuilding.FormattingEnabled = true;
            this.comboBoxSpecificBuilding.Items.AddRange(new object[] {
            "FOB",
            "Transporter Pad",
            "Generators",
            "Marina",
            "Habitat Center",
            "Mineralogy",
            "Material Processor",
            "Mechanics yard",
            "Guard Tower",
            "Large Equipment Transporter",
            "Infrastructure",
            "Microwave Emitters",
            " "});
            this.comboBoxSpecificBuilding.Location = new System.Drawing.Point(244, 3);
            this.comboBoxSpecificBuilding.Name = "comboBoxSpecificBuilding";
            this.comboBoxSpecificBuilding.Size = new System.Drawing.Size(122, 21);
            this.comboBoxSpecificBuilding.TabIndex = 38;
            this.comboBoxSpecificBuilding.Text = global::WindowsFormsApp2.Properties.Settings.Default.SpecificBuilding;
            this.comboBoxSpecificBuilding.TextChanged += new System.EventHandler(this.CustomValue_SpecificBuilding);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.tableLayoutPanel21);
            this.groupBox16.Location = new System.Drawing.Point(3, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(464, 46);
            this.groupBox16.TabIndex = 1;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Collect Crystals";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 3;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.36364F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.63636F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel21.Controls.Add(this.ActiveCrystalCollection, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.labelCrystalCollection, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.NeededCrystals, 2, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(451, 24);
            this.tableLayoutPanel21.TabIndex = 0;
            // 
            // ActiveCrystalCollection
            // 
            this.ActiveCrystalCollection.AutoSize = true;
            this.ActiveCrystalCollection.Checked = true;
            this.ActiveCrystalCollection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveCrystalCollection.Location = new System.Drawing.Point(3, 3);
            this.ActiveCrystalCollection.Name = "ActiveCrystalCollection";
            this.ActiveCrystalCollection.Size = new System.Drawing.Size(56, 17);
            this.ActiveCrystalCollection.TabIndex = 35;
            this.ActiveCrystalCollection.Text = "Active";
            this.ActiveCrystalCollection.UseVisualStyleBackColor = true;
            this.ActiveCrystalCollection.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // labelCrystalCollection
            // 
            this.labelCrystalCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCrystalCollection.AutoSize = true;
            this.labelCrystalCollection.Location = new System.Drawing.Point(103, 5);
            this.labelCrystalCollection.Name = "labelCrystalCollection";
            this.labelCrystalCollection.Size = new System.Drawing.Size(137, 13);
            this.labelCrystalCollection.TabIndex = 2;
            this.labelCrystalCollection.Text = "Custom Crystal Amount";
            // 
            // NeededCrystals
            // 
            this.NeededCrystals.Location = new System.Drawing.Point(246, 3);
            this.NeededCrystals.Name = "NeededCrystals";
            this.NeededCrystals.Size = new System.Drawing.Size(120, 20);
            this.NeededCrystals.TabIndex = 36;
            this.NeededCrystals.Value = global::WindowsFormsApp2.Properties.Settings.Default.CrystalsCount;
            this.NeededCrystals.ValueChanged += new System.EventHandler(this.CustomValue_CrystalsCount);
            // 
            // tabPage7
            // 
            this.tabPage7.AutoScroll = true;
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(484, 337);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "General";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(270, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 32);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 99;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyButton);
            // 
            // New_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "New_Map";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.New_Map_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightIn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.LabelDamageToPlayer.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDamage)).EndInit();
            this.LabelDamageFromPlayer.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomPlayerDamage)).EndInit();
            this.LabelSpawnChance.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSpawnChance)).EndInit();
            this.LabelHunger.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomHunger)).EndInit();
            this.LabelSpeed.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebrisMultiplier)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepairCost)).EndInit();
            this.LabelErosionSpeed.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomErosionSpeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomAvalanchFrequncy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomAvalanchDamage)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirQuantity)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateOfConsumption)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerDrainMultiplier)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeededCrystals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox MapName;
        public System.Windows.Forms.Label labelMapName;
        public System.Windows.Forms.Label labelWidth;
        public System.Windows.Forms.Label labelHeight;
        public System.Windows.Forms.ComboBox TerrainType;
        public System.Windows.Forms.Label labelHostileAI;
        public System.Windows.Forms.Label labelTerrainType;
        public System.Windows.Forms.CheckBox HostileAI;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.CheckBox Erosion;
        public System.Windows.Forms.Label labelErosion;
        public System.Windows.Forms.Label labelAvalanches;
        public System.Windows.Forms.CheckBox Avalanche;
        public System.Windows.Forms.Label labelAirThreat;
        public System.Windows.Forms.Label labelPowerDrain;
        public System.Windows.Forms.CheckBox AirThreat;
        public System.Windows.Forms.CheckBox PowerDrain;
        public System.Windows.Forms.TabControl Tabs;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.GroupBox LabelSpeed;
        public System.Windows.Forms.GroupBox LabelDamageToPlayer;
        public System.Windows.Forms.GroupBox LabelDamageFromPlayer;
        public System.Windows.Forms.GroupBox LabelHunger;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.CheckBox DefaultPlayerDamage;
        public System.Windows.Forms.Label labelCustomDamage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.CheckBox DefaultDamageFromPlayer;
        public System.Windows.Forms.Label labelPlayerCustomDamage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        public System.Windows.Forms.CheckBox SpawnChance;
        public System.Windows.Forms.Label labelCustomHunger;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public System.Windows.Forms.CheckBox DefaultSpeed;
        public System.Windows.Forms.Label labelCustomSpeed;
        public System.Windows.Forms.Label labelDebrisMultiplyer;
        public System.Windows.Forms.GroupBox LabelSpawnChance;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        public System.Windows.Forms.CheckBox DefaultHunger;
        public System.Windows.Forms.Label labelCustomSpawnChance;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.GroupBox LabelErosionSpeed;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.CheckBox DefaultErosionSpeed;
        public System.Windows.Forms.Label labelCustomErosionSpeed;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        public System.Windows.Forms.CheckBox DefaultAvalancheFrequency;
        public System.Windows.Forms.Label labelCustomAvalancheFrequency;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        public System.Windows.Forms.CheckBox defaultAvalancheDamageToPlayers;
        public System.Windows.Forms.Label labelCustomAvalancheDamage;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        public System.Windows.Forms.CheckBox DefaultRepairCost;
        public System.Windows.Forms.Label labelRepairCost;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        public System.Windows.Forms.CheckBox DefaultAirQuantity;
        public System.Windows.Forms.Label labelAirQuantity;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        public System.Windows.Forms.CheckBox DefaultRateOfConsumption;
        public System.Windows.Forms.Label labelRateOfConsumption;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        public System.Windows.Forms.GroupBox groupBox15;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        public System.Windows.Forms.CheckBox DefaultPowerDrain;
        public System.Windows.Forms.Label label21PowerDrain;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        public System.Windows.Forms.GroupBox groupBox13;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        public System.Windows.Forms.CheckBox ActiveSpecificBuilding;
        public System.Windows.Forms.Label labelSpecificBuilding;
        public System.Windows.Forms.GroupBox groupBox16;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        public System.Windows.Forms.CheckBox ActiveCrystalCollection;
        public System.Windows.Forms.Label labelCrystalCollection;
        public System.Windows.Forms.GroupBox groupBox17;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        public System.Windows.Forms.CheckBox ActiveSpecificUnit;
        public System.Windows.Forms.Label labelSpecificUnit;
        public System.Windows.Forms.ComboBox comboBoxSpecificUnit;
        public System.Windows.Forms.ComboBox comboBoxSpecificBuilding;
        public System.Windows.Forms.GroupBox groupBox19;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        public System.Windows.Forms.CheckBox ActiveReachTheTile;
        public System.Windows.Forms.GroupBox groupBox18;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        public System.Windows.Forms.CheckBox ActiveRescue;
        public System.Windows.Forms.Label labelRescueUnit;
        public System.Windows.Forms.ComboBox comboBoxRescueUnit;
        public System.Windows.Forms.NumericUpDown WidthIn;
        public System.Windows.Forms.NumericUpDown HeightIn;
        public System.Windows.Forms.NumericUpDown CustomDamage;
        public System.Windows.Forms.NumericUpDown CustomPlayerDamage;
        public System.Windows.Forms.NumericUpDown CustomSpawnChance;
        public System.Windows.Forms.NumericUpDown CustomHunger;
        public System.Windows.Forms.NumericUpDown CustomSpeed;
        public System.Windows.Forms.NumericUpDown DebrisMultiplier;
        public System.Windows.Forms.NumericUpDown RepairCost;
        public System.Windows.Forms.NumericUpDown CustomErosionSpeed;
        public System.Windows.Forms.NumericUpDown CustomAvalanchFrequncy;
        public System.Windows.Forms.NumericUpDown CustomAvalanchDamage;
        public System.Windows.Forms.NumericUpDown AirQuantity;
        public System.Windows.Forms.NumericUpDown RateOfConsumption;
        public System.Windows.Forms.NumericUpDown PowerDrainMultiplier;
        public System.Windows.Forms.NumericUpDown NeededCrystals;
        private System.Windows.Forms.Label label1;
    }
}