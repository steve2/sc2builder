namespace SC2Builder
{
    partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.FileMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StepList = new System.Windows.Forms.ListView();
			this.StepHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Images = new System.Windows.Forms.ImageList(this.components);
			this.BuildList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BuildPreviewerGroup = new System.Windows.Forms.GroupBox();
			this.BuildEditorGroup = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BuildSpecTextBox = new System.Windows.Forms.RichTextBox();
			this.BuildSpecCustomizables = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.terranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.supplyDepotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.supplyDepotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.refineryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.barracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commandCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.engineeringBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.starportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.armoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fusionCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.missileTurretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sensorTowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.upgradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orbitalCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.planetaryFortressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.techLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.protossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zergToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteBuild = new System.Windows.Forms.Button();
			this.UpdateBuild = new System.Windows.Forms.Button();
			this.CreateBuild = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.MatchupBox = new System.Windows.Forms.ComboBox();
			this.RaceBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.OpenBuildDialog = new System.DirectoryServices.DirectorySearcher();
			this.FileMenu.SuspendLayout();
			this.BuildPreviewerGroup.SuspendLayout();
			this.BuildEditorGroup.SuspendLayout();
			this.BuildSpecCustomizables.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileMenu
			// 
			this.FileMenu.BackColor = System.Drawing.SystemColors.Control;
			this.FileMenu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.FileMenu.Location = new System.Drawing.Point(0, 0);
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.FileMenu.Size = new System.Drawing.Size(814, 24);
			this.FileMenu.TabIndex = 1;
			this.FileMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ExitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// LoadToolStripMenuItem
			// 
			this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
			this.LoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.LoadToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.LoadToolStripMenuItem.Text = "&Load Build File...";
			this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.ExitToolStripMenuItem.Text = "&Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBuildToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// createBuildToolStripMenuItem
			// 
			this.createBuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.createBuildToolStripMenuItem.Name = "createBuildToolStripMenuItem";
			this.createBuildToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.createBuildToolStripMenuItem.Text = "&Build";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.createToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.createToolStripMenuItem.Text = "&Create";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.updateToolStripMenuItem.Text = "&Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// StepList
			// 
			this.StepList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StepList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StepList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StepHeader});
			this.StepList.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StepList.FullRowSelect = true;
			this.StepList.GridLines = true;
			this.StepList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.StepList.LabelWrap = false;
			this.StepList.Location = new System.Drawing.Point(332, 22);
			this.StepList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StepList.MultiSelect = false;
			this.StepList.Name = "StepList";
			this.StepList.Size = new System.Drawing.Size(220, 216);
			this.StepList.SmallImageList = this.Images;
			this.StepList.TabIndex = 3;
			this.StepList.TileSize = new System.Drawing.Size(1, 1);
			this.StepList.UseCompatibleStateImageBehavior = false;
			this.StepList.View = System.Windows.Forms.View.Details;
			// 
			// StepHeader
			// 
			this.StepHeader.Text = "Steps";
			this.StepHeader.Width = 430;
			// 
			// Images
			// 
			this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
			this.Images.TransparentColor = System.Drawing.Color.Transparent;
			this.Images.Images.SetKeyName(0, "protoss.gif");
			this.Images.Images.SetKeyName(1, "terran.gif");
			this.Images.Images.SetKeyName(2, "zerg.gif");
			this.Images.Images.SetKeyName(3, "gas.gif");
			this.Images.Images.SetKeyName(4, "supply.gif");
			this.Images.Images.SetKeyName(5, "time.gif");
			this.Images.Images.SetKeyName(6, "gas.gif");
			this.Images.Images.SetKeyName(7, "supply.gif");
			this.Images.Images.SetKeyName(8, "time.gif");
			this.Images.Images.SetKeyName(9, "gas.gif");
			this.Images.Images.SetKeyName(10, "supply.gif");
			this.Images.Images.SetKeyName(11, "time.gif");
			this.Images.Images.SetKeyName(12, "minerals.gif");
			// 
			// BuildList
			// 
			this.BuildList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.BuildList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BuildList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.BuildList.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildList.FullRowSelect = true;
			this.BuildList.GridLines = true;
			this.BuildList.HideSelection = false;
			this.BuildList.LabelWrap = false;
			this.BuildList.Location = new System.Drawing.Point(3, 22);
			this.BuildList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BuildList.MultiSelect = false;
			this.BuildList.Name = "BuildList";
			this.BuildList.Size = new System.Drawing.Size(320, 216);
			this.BuildList.SmallImageList = this.Images;
			this.BuildList.TabIndex = 4;
			this.BuildList.TileSize = new System.Drawing.Size(1, 1);
			this.BuildList.UseCompatibleStateImageBehavior = false;
			this.BuildList.View = System.Windows.Forms.View.Details;
			this.BuildList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.BuildList_ColumnClick);
			this.BuildList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.BuildList_ColumnWidthChanging);
			this.BuildList.SelectedIndexChanged += new System.EventHandler(this.BuildList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Builds";
			this.columnHeader1.Width = 185;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Race";
			this.columnHeader2.Width = 59;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Matchup";
			this.columnHeader3.Width = 113;
			// 
			// BuildPreviewerGroup
			// 
			this.BuildPreviewerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.BuildPreviewerGroup.Controls.Add(this.BuildList);
			this.BuildPreviewerGroup.Controls.Add(this.StepList);
			this.BuildPreviewerGroup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildPreviewerGroup.Location = new System.Drawing.Point(0, 28);
			this.BuildPreviewerGroup.Name = "BuildPreviewerGroup";
			this.BuildPreviewerGroup.Size = new System.Drawing.Size(558, 245);
			this.BuildPreviewerGroup.TabIndex = 5;
			this.BuildPreviewerGroup.TabStop = false;
			this.BuildPreviewerGroup.Text = "Build Previewer";
			// 
			// BuildEditorGroup
			// 
			this.BuildEditorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BuildEditorGroup.BackColor = System.Drawing.SystemColors.Control;
			this.BuildEditorGroup.Controls.Add(this.label4);
			this.BuildEditorGroup.Controls.Add(this.BuildSpecTextBox);
			this.BuildEditorGroup.Controls.Add(this.DeleteBuild);
			this.BuildEditorGroup.Controls.Add(this.UpdateBuild);
			this.BuildEditorGroup.Controls.Add(this.CreateBuild);
			this.BuildEditorGroup.Controls.Add(this.label3);
			this.BuildEditorGroup.Controls.Add(this.NameBox);
			this.BuildEditorGroup.Controls.Add(this.MatchupBox);
			this.BuildEditorGroup.Controls.Add(this.RaceBox);
			this.BuildEditorGroup.Controls.Add(this.label2);
			this.BuildEditorGroup.Controls.Add(this.label1);
			this.BuildEditorGroup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildEditorGroup.Location = new System.Drawing.Point(563, 28);
			this.BuildEditorGroup.Name = "BuildEditorGroup";
			this.BuildEditorGroup.Size = new System.Drawing.Size(251, 333);
			this.BuildEditorGroup.TabIndex = 6;
			this.BuildEditorGroup.TabStop = false;
			this.BuildEditorGroup.Text = "Build Editor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 14);
			this.label4.TabIndex = 10;
			this.label4.Text = "Build Specification:";
			// 
			// BuildSpecTextBox
			// 
			this.BuildSpecTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BuildSpecTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.BuildSpecTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BuildSpecTextBox.ContextMenuStrip = this.BuildSpecCustomizables;
			this.BuildSpecTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildSpecTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.BuildSpecTextBox.Location = new System.Drawing.Point(6, 131);
			this.BuildSpecTextBox.Name = "BuildSpecTextBox";
			this.BuildSpecTextBox.Size = new System.Drawing.Size(238, 122);
			this.BuildSpecTextBox.TabIndex = 5;
			this.BuildSpecTextBox.Text = "";
			this.BuildSpecTextBox.WordWrap = false;
			this.BuildSpecTextBox.TextChanged += new System.EventHandler(this.BuildSpecTextBox_TextChanged);
			// 
			// BuildSpecCustomizables
			// 
			this.BuildSpecCustomizables.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.BuildSpecCustomizables.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.BuildSpecCustomizables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
			this.BuildSpecCustomizables.Name = "BuildSpecCustomizables";
			this.BuildSpecCustomizables.Size = new System.Drawing.Size(138, 26);
			this.BuildSpecCustomizables.Text = "Widgets";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terranToolStripMenuItem,
            this.protossToolStripMenuItem,
            this.zergToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.addToolStripMenuItem.Text = "Graphic Tags";
			// 
			// terranToolStripMenuItem
			// 
			this.terranToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.terranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyDepotToolStripMenuItem,
            this.upgradesToolStripMenuItem});
			this.terranToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.terran;
			this.terranToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.terranToolStripMenuItem.Name = "terranToolStripMenuItem";
			this.terranToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.terranToolStripMenuItem.Text = "Terran";
			// 
			// supplyDepotToolStripMenuItem
			// 
			this.supplyDepotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyDepotToolStripMenuItem1,
            this.refineryToolStripMenuItem,
            this.barracksToolStripMenuItem,
            this.commandCenterToolStripMenuItem,
            this.engineeringBayToolStripMenuItem,
            this.factoryToolStripMenuItem,
            this.starportToolStripMenuItem,
            this.armoryToolStripMenuItem,
            this.fusionCoreToolStripMenuItem,
            this.missileTurretToolStripMenuItem,
            this.sensorTowerToolStripMenuItem,
            this.bunkerToolStripMenuItem});
			this.supplyDepotToolStripMenuItem.Name = "supplyDepotToolStripMenuItem";
			this.supplyDepotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.supplyDepotToolStripMenuItem.Text = "Structures";
			// 
			// supplyDepotToolStripMenuItem1
			// 
			this.supplyDepotToolStripMenuItem1.Image = global::SC2Builder.Properties.Resources.btn_building_terran_supplydepot;
			this.supplyDepotToolStripMenuItem1.Name = "supplyDepotToolStripMenuItem1";
			this.supplyDepotToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
			this.supplyDepotToolStripMenuItem1.Text = "Supply Depot";
			this.supplyDepotToolStripMenuItem1.Click += new System.EventHandler(this.supplyDepotToolStripMenuItem1_Click);
			// 
			// refineryToolStripMenuItem
			// 
			this.refineryToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_refinery;
			this.refineryToolStripMenuItem.Name = "refineryToolStripMenuItem";
			this.refineryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.refineryToolStripMenuItem.Text = "Refinery";
			this.refineryToolStripMenuItem.Click += new System.EventHandler(this.refineryToolStripMenuItem_Click);
			// 
			// barracksToolStripMenuItem
			// 
			this.barracksToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_barracks;
			this.barracksToolStripMenuItem.Name = "barracksToolStripMenuItem";
			this.barracksToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.barracksToolStripMenuItem.Text = "Barracks";
			this.barracksToolStripMenuItem.Click += new System.EventHandler(this.barracksToolStripMenuItem_Click);
			// 
			// commandCenterToolStripMenuItem
			// 
			this.commandCenterToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_commandcenter;
			this.commandCenterToolStripMenuItem.Name = "commandCenterToolStripMenuItem";
			this.commandCenterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.commandCenterToolStripMenuItem.Text = "Command Center";
			this.commandCenterToolStripMenuItem.Click += new System.EventHandler(this.commandCenterToolStripMenuItem_Click);
			// 
			// engineeringBayToolStripMenuItem
			// 
			this.engineeringBayToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_engineeringbay;
			this.engineeringBayToolStripMenuItem.Name = "engineeringBayToolStripMenuItem";
			this.engineeringBayToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.engineeringBayToolStripMenuItem.Text = "Engineering Bay";
			this.engineeringBayToolStripMenuItem.Click += new System.EventHandler(this.engineeringBayToolStripMenuItem_Click);
			// 
			// factoryToolStripMenuItem
			// 
			this.factoryToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_factory;
			this.factoryToolStripMenuItem.Name = "factoryToolStripMenuItem";
			this.factoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.factoryToolStripMenuItem.Text = "Factory";
			this.factoryToolStripMenuItem.Click += new System.EventHandler(this.factoryToolStripMenuItem_Click);
			// 
			// starportToolStripMenuItem
			// 
			this.starportToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_starport;
			this.starportToolStripMenuItem.Name = "starportToolStripMenuItem";
			this.starportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.starportToolStripMenuItem.Text = "Starport";
			this.starportToolStripMenuItem.Click += new System.EventHandler(this.starportToolStripMenuItem_Click);
			// 
			// armoryToolStripMenuItem
			// 
			this.armoryToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_armory;
			this.armoryToolStripMenuItem.Name = "armoryToolStripMenuItem";
			this.armoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.armoryToolStripMenuItem.Text = "Armory";
			this.armoryToolStripMenuItem.Click += new System.EventHandler(this.armoryToolStripMenuItem_Click);
			// 
			// fusionCoreToolStripMenuItem
			// 
			this.fusionCoreToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_fusioncore;
			this.fusionCoreToolStripMenuItem.Name = "fusionCoreToolStripMenuItem";
			this.fusionCoreToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.fusionCoreToolStripMenuItem.Text = "Fusion Core";
			this.fusionCoreToolStripMenuItem.Click += new System.EventHandler(this.fusionCoreToolStripMenuItem_Click);
			// 
			// missileTurretToolStripMenuItem
			// 
			this.missileTurretToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_missileturret;
			this.missileTurretToolStripMenuItem.Name = "missileTurretToolStripMenuItem";
			this.missileTurretToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.missileTurretToolStripMenuItem.Text = "Missile Turret";
			this.missileTurretToolStripMenuItem.Click += new System.EventHandler(this.missileTurretToolStripMenuItem_Click);
			// 
			// sensorTowerToolStripMenuItem
			// 
			this.sensorTowerToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_sensordome;
			this.sensorTowerToolStripMenuItem.Name = "sensorTowerToolStripMenuItem";
			this.sensorTowerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.sensorTowerToolStripMenuItem.Text = "Sensor Tower";
			this.sensorTowerToolStripMenuItem.Click += new System.EventHandler(this.sensorTowerToolStripMenuItem_Click);
			// 
			// bunkerToolStripMenuItem
			// 
			this.bunkerToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_bunker;
			this.bunkerToolStripMenuItem.Name = "bunkerToolStripMenuItem";
			this.bunkerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.bunkerToolStripMenuItem.Text = "Bunker";
			this.bunkerToolStripMenuItem.Click += new System.EventHandler(this.bunkerToolStripMenuItem_Click);
			// 
			// upgradesToolStripMenuItem
			// 
			this.upgradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orbitalCommandToolStripMenuItem,
            this.planetaryFortressToolStripMenuItem,
            this.techLabToolStripMenuItem,
            this.reactorToolStripMenuItem});
			this.upgradesToolStripMenuItem.Name = "upgradesToolStripMenuItem";
			this.upgradesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.upgradesToolStripMenuItem.Text = "Upgrades";
			// 
			// orbitalCommandToolStripMenuItem
			// 
			this.orbitalCommandToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_surveillancestation;
			this.orbitalCommandToolStripMenuItem.Name = "orbitalCommandToolStripMenuItem";
			this.orbitalCommandToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.orbitalCommandToolStripMenuItem.Text = "Orbital Command";
			// 
			// planetaryFortressToolStripMenuItem
			// 
			this.planetaryFortressToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_planetaryfortress;
			this.planetaryFortressToolStripMenuItem.Name = "planetaryFortressToolStripMenuItem";
			this.planetaryFortressToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.planetaryFortressToolStripMenuItem.Text = "Planetary Fortress";
			// 
			// techLabToolStripMenuItem
			// 
			this.techLabToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_techlab;
			this.techLabToolStripMenuItem.Name = "techLabToolStripMenuItem";
			this.techLabToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.techLabToolStripMenuItem.Text = "Tech Lab";
			// 
			// reactorToolStripMenuItem
			// 
			this.reactorToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.btn_building_terran_reactor;
			this.reactorToolStripMenuItem.Name = "reactorToolStripMenuItem";
			this.reactorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.reactorToolStripMenuItem.Text = "Reactor";
			// 
			// protossToolStripMenuItem
			// 
			this.protossToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.protoss;
			this.protossToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.protossToolStripMenuItem.Name = "protossToolStripMenuItem";
			this.protossToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.protossToolStripMenuItem.Text = "Protoss";
			// 
			// zergToolStripMenuItem
			// 
			this.zergToolStripMenuItem.Image = global::SC2Builder.Properties.Resources.zerg;
			this.zergToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.zergToolStripMenuItem.Name = "zergToolStripMenuItem";
			this.zergToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.zergToolStripMenuItem.Text = "Zerg";
			// 
			// DeleteBuild
			// 
			this.DeleteBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.DeleteBuild.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleteBuild.Location = new System.Drawing.Point(127, 261);
			this.DeleteBuild.Name = "DeleteBuild";
			this.DeleteBuild.Size = new System.Drawing.Size(113, 30);
			this.DeleteBuild.TabIndex = 8;
			this.DeleteBuild.Text = "Delete";
			this.DeleteBuild.UseVisualStyleBackColor = true;
			this.DeleteBuild.Click += new System.EventHandler(this.DeleteBuild_Click);
			// 
			// UpdateBuild
			// 
			this.UpdateBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.UpdateBuild.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpdateBuild.ImageList = this.Images;
			this.UpdateBuild.Location = new System.Drawing.Point(15, 290);
			this.UpdateBuild.Name = "UpdateBuild";
			this.UpdateBuild.Size = new System.Drawing.Size(113, 30);
			this.UpdateBuild.TabIndex = 7;
			this.UpdateBuild.Text = "Update";
			this.UpdateBuild.UseVisualStyleBackColor = true;
			this.UpdateBuild.Click += new System.EventHandler(this.UpdateBuild_Click);
			// 
			// CreateBuild
			// 
			this.CreateBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CreateBuild.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateBuild.ImageList = this.Images;
			this.CreateBuild.Location = new System.Drawing.Point(15, 261);
			this.CreateBuild.Name = "CreateBuild";
			this.CreateBuild.Size = new System.Drawing.Size(113, 30);
			this.CreateBuild.TabIndex = 6;
			this.CreateBuild.Text = "Create Build";
			this.CreateBuild.UseVisualStyleBackColor = true;
			this.CreateBuild.Click += new System.EventHandler(this.CreateBuild_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name";
			// 
			// NameBox
			// 
			this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameBox.Location = new System.Drawing.Point(64, 84);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(181, 22);
			this.NameBox.TabIndex = 4;
			// 
			// MatchupBox
			// 
			this.MatchupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MatchupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MatchupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MatchupBox.FormattingEnabled = true;
			this.MatchupBox.Items.AddRange(new object[] {
            "-vs- Terran",
            "-vs- Protoss",
            "-vs- Zerg"});
			this.MatchupBox.Location = new System.Drawing.Point(64, 56);
			this.MatchupBox.Name = "MatchupBox";
			this.MatchupBox.Size = new System.Drawing.Size(181, 24);
			this.MatchupBox.TabIndex = 2;
			// 
			// RaceBox
			// 
			this.RaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RaceBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.RaceBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RaceBox.FormattingEnabled = true;
			this.RaceBox.Items.AddRange(new object[] {
            "Terran",
            "Protoss",
            "Zerg"});
			this.RaceBox.Location = new System.Drawing.Point(64, 28);
			this.RaceBox.Name = "RaceBox";
			this.RaceBox.Size = new System.Drawing.Size(181, 24);
			this.RaceBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Matchup";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Race";
			// 
			// OpenBuildDialog
			// 
			this.OpenBuildDialog.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.OpenBuildDialog.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.OpenBuildDialog.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(814, 361);
			this.Controls.Add(this.FileMenu);
			this.Controls.Add(this.BuildEditorGroup);
			this.Controls.Add(this.BuildPreviewerGroup);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.FileMenu;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(830, 400);
			this.Name = "MainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StarCraft 2 Build Helper";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.FileMenu.ResumeLayout(false);
			this.FileMenu.PerformLayout();
			this.BuildPreviewerGroup.ResumeLayout(false);
			this.BuildEditorGroup.ResumeLayout(false);
			this.BuildEditorGroup.PerformLayout();
			this.BuildSpecCustomizables.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView StepList;
        private System.Windows.Forms.ColumnHeader StepHeader;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ListView BuildList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox BuildPreviewerGroup;
        private System.Windows.Forms.GroupBox BuildEditorGroup;
        private System.Windows.Forms.ComboBox RaceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MatchupBox;
        private System.Windows.Forms.Label label2;
        private System.DirectoryServices.DirectorySearcher OpenBuildDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button UpdateBuild;
        private System.Windows.Forms.Button CreateBuild;
				private System.Windows.Forms.Button DeleteBuild;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.RichTextBox BuildSpecTextBox;
				private System.Windows.Forms.ToolStripMenuItem createBuildToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
				private System.Windows.Forms.ContextMenuStrip BuildSpecCustomizables;
				private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem terranToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem protossToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem zergToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem supplyDepotToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem supplyDepotToolStripMenuItem1;
				private System.Windows.Forms.ToolStripMenuItem refineryToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem barracksToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem commandCenterToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem engineeringBayToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem factoryToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem starportToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem armoryToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem missileTurretToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem sensorTowerToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem bunkerToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem fusionCoreToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem upgradesToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem orbitalCommandToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem planetaryFortressToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem techLabToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem reactorToolStripMenuItem;

    }
}

