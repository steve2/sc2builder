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
			this.NamingProblem = new System.Windows.Forms.ErrorProvider(this.components);
			this.createBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileMenu.SuspendLayout();
			this.BuildPreviewerGroup.SuspendLayout();
			this.BuildEditorGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NamingProblem)).BeginInit();
			this.SuspendLayout();
			// 
			// FileMenu
			// 
			this.FileMenu.BackColor = System.Drawing.SystemColors.Control;
			this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.FileMenu.Location = new System.Drawing.Point(0, 0);
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.FileMenu.Size = new System.Drawing.Size(809, 24);
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
			this.LoadToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.LoadToolStripMenuItem.Text = "&Load Build File...";
			this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.ExitToolStripMenuItem.Text = "&Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBuildToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// StepList
			// 
			this.StepList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.StepList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StepList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StepHeader});
			this.StepList.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.StepList.FullRowSelect = true;
			this.StepList.GridLines = true;
			this.StepList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.StepList.LabelWrap = false;
			this.StepList.Location = new System.Drawing.Point(336, 24);
			this.StepList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.StepList.MultiSelect = false;
			this.StepList.Name = "StepList";
			this.StepList.Size = new System.Drawing.Size(215, 428);
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
			this.Images.Images.SetKeyName(0, "trash-1127191527.png");
			this.Images.Images.SetKeyName(1, "protoss.gif");
			this.Images.Images.SetKeyName(2, "terran.gif");
			this.Images.Images.SetKeyName(3, "zerg.gif");
			this.Images.Images.SetKeyName(4, "gas.gif");
			this.Images.Images.SetKeyName(5, "supply.gif");
			this.Images.Images.SetKeyName(6, "time.gif");
			this.Images.Images.SetKeyName(7, "gas.gif");
			this.Images.Images.SetKeyName(8, "supply.gif");
			this.Images.Images.SetKeyName(9, "time.gif");
			this.Images.Images.SetKeyName(10, "gas.gif");
			this.Images.Images.SetKeyName(11, "supply.gif");
			this.Images.Images.SetKeyName(12, "time.gif");
			this.Images.Images.SetKeyName(13, "minerals.gif");
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
			this.BuildList.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.BuildList.FullRowSelect = true;
			this.BuildList.GridLines = true;
			this.BuildList.LabelWrap = false;
			this.BuildList.Location = new System.Drawing.Point(7, 24);
			this.BuildList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BuildList.MultiSelect = false;
			this.BuildList.Name = "BuildList";
			this.BuildList.Size = new System.Drawing.Size(321, 427);
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
			this.BuildPreviewerGroup.Controls.Add(this.StepList);
			this.BuildPreviewerGroup.Controls.Add(this.BuildList);
			this.BuildPreviewerGroup.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildPreviewerGroup.Location = new System.Drawing.Point(9, 29);
			this.BuildPreviewerGroup.Name = "BuildPreviewerGroup";
			this.BuildPreviewerGroup.Size = new System.Drawing.Size(558, 459);
			this.BuildPreviewerGroup.TabIndex = 5;
			this.BuildPreviewerGroup.TabStop = false;
			this.BuildPreviewerGroup.Text = "Build Previewer";
			// 
			// BuildEditorGroup
			// 
			this.BuildEditorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.BuildEditorGroup.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildEditorGroup.Location = new System.Drawing.Point(573, 28);
			this.BuildEditorGroup.Name = "BuildEditorGroup";
			this.BuildEditorGroup.Size = new System.Drawing.Size(228, 460);
			this.BuildEditorGroup.TabIndex = 6;
			this.BuildEditorGroup.TabStop = false;
			this.BuildEditorGroup.Text = "Build Editor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 121);
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
			this.BuildSpecTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BuildSpecTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildSpecTextBox.Location = new System.Drawing.Point(6, 142);
			this.BuildSpecTextBox.Name = "BuildSpecTextBox";
			this.BuildSpecTextBox.Size = new System.Drawing.Size(203, 238);
			this.BuildSpecTextBox.TabIndex = 5;
			this.BuildSpecTextBox.Text = "";
			this.BuildSpecTextBox.WordWrap = false;
			// 
			// DeleteBuild
			// 
			this.DeleteBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.DeleteBuild.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.DeleteBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleteBuild.ImageIndex = 0;
			this.DeleteBuild.ImageList = this.Images;
			this.DeleteBuild.Location = new System.Drawing.Point(116, 423);
			this.DeleteBuild.Name = "DeleteBuild";
			this.DeleteBuild.Size = new System.Drawing.Size(106, 31);
			this.DeleteBuild.TabIndex = 8;
			this.DeleteBuild.Text = "Delete";
			this.DeleteBuild.UseVisualStyleBackColor = true;
			this.DeleteBuild.Click += new System.EventHandler(this.DeleteBuild_Click);
			// 
			// UpdateBuild
			// 
			this.UpdateBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.UpdateBuild.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.UpdateBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpdateBuild.ImageList = this.Images;
			this.UpdateBuild.Location = new System.Drawing.Point(6, 423);
			this.UpdateBuild.Name = "UpdateBuild";
			this.UpdateBuild.Size = new System.Drawing.Size(106, 31);
			this.UpdateBuild.TabIndex = 7;
			this.UpdateBuild.Text = "Update";
			this.UpdateBuild.UseVisualStyleBackColor = true;
			this.UpdateBuild.Click += new System.EventHandler(this.UpdateBuild_Click);
			// 
			// CreateBuild
			// 
			this.CreateBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CreateBuild.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.CreateBuild.ImageList = this.Images;
			this.CreateBuild.Location = new System.Drawing.Point(6, 386);
			this.CreateBuild.Name = "CreateBuild";
			this.CreateBuild.Size = new System.Drawing.Size(106, 31);
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
			this.label3.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.label3.Location = new System.Drawing.Point(19, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name";
			// 
			// NameBox
			// 
			this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameBox.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.NameBox.Location = new System.Drawing.Point(64, 84);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(158, 22);
			this.NameBox.TabIndex = 4;
			// 
			// MatchupBox
			// 
			this.MatchupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MatchupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MatchupBox.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.MatchupBox.FormattingEnabled = true;
			this.MatchupBox.Items.AddRange(new object[] {
            "-vs- Terran",
            "-vs- Protoss",
            "-vs- Zerg"});
			this.MatchupBox.Location = new System.Drawing.Point(64, 56);
			this.MatchupBox.Name = "MatchupBox";
			this.MatchupBox.Size = new System.Drawing.Size(158, 22);
			this.MatchupBox.TabIndex = 2;
			// 
			// RaceBox
			// 
			this.RaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RaceBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.RaceBox.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.RaceBox.FormattingEnabled = true;
			this.RaceBox.Items.AddRange(new object[] {
            "Terran",
            "Protoss",
            "Zerg"});
			this.RaceBox.Location = new System.Drawing.Point(64, 28);
			this.RaceBox.Name = "RaceBox";
			this.RaceBox.Size = new System.Drawing.Size(158, 22);
			this.RaceBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.label2.Location = new System.Drawing.Point(6, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Matchup";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.label1.Location = new System.Drawing.Point(26, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Race";
			// 
			// OpenBuildDialog
			// 
			this.OpenBuildDialog.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.OpenBuildDialog.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.OpenBuildDialog.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// NamingProblem
			// 
			this.NamingProblem.ContainerControl = this;
			// 
			// createBuildToolStripMenuItem
			// 
			this.createBuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.createBuildToolStripMenuItem.Name = "createBuildToolStripMenuItem";
			this.createBuildToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.createBuildToolStripMenuItem.Text = "&Build";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.createToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.createToolStripMenuItem.Text = "&Create";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.updateToolStripMenuItem.Text = "&Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(809, 499);
			this.Controls.Add(this.FileMenu);
			this.Controls.Add(this.BuildEditorGroup);
			this.Controls.Add(this.BuildPreviewerGroup);
			this.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.FileMenu;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(825, 538);
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
			((System.ComponentModel.ISupportInitialize)(this.NamingProblem)).EndInit();
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
        private System.Windows.Forms.ErrorProvider NamingProblem;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.RichTextBox BuildSpecTextBox;
				private System.Windows.Forms.ToolStripMenuItem createBuildToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}

