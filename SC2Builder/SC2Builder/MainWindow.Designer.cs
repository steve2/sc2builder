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
            this.AppTitle = new System.Windows.Forms.Label();
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StepList = new System.Windows.Forms.ListView();
            this.StepHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BuildList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.FileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.Location = new System.Drawing.Point(9, 24);
            this.AppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(189, 23);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "StarCraft 2 Build Helper";
            // 
            // FileMenu
            // 
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.FileMenu.Size = new System.Drawing.Size(779, 24);
            this.FileMenu.TabIndex = 1;
            this.FileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeBuildToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openToolStripMenuItem.Text = "Open Build...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeBuildToolStripMenuItem
            // 
            this.closeBuildToolStripMenuItem.Name = "closeBuildToolStripMenuItem";
            this.closeBuildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.closeBuildToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeBuildToolStripMenuItem.Text = "Save Build...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // StepList
            // 
            this.StepList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StepHeader});
            this.StepList.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepList.FullRowSelect = true;
            this.StepList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StepList.LabelWrap = false;
            this.StepList.Location = new System.Drawing.Point(335, 51);
            this.StepList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StepList.MultiSelect = false;
            this.StepList.Name = "StepList";
            this.StepList.Scrollable = false;
            this.StepList.Size = new System.Drawing.Size(431, 351);
            this.StepList.SmallImageList = this.imageList1;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "supply.gif");
            this.imageList1.Images.SetKeyName(1, "RandomIcon.jpg");
            this.imageList1.Images.SetKeyName(2, "terran.gif");
            this.imageList1.Images.SetKeyName(3, "defaultportrait.png");
            this.imageList1.Images.SetKeyName(4, "TerranIcon.png");
            this.imageList1.Images.SetKeyName(5, "ProtossIcon.png");
            this.imageList1.Images.SetKeyName(6, "zergicon.png");
            // 
            // BuildList
            // 
            this.BuildList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.BuildList.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildList.FullRowSelect = true;
            this.BuildList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BuildList.LabelWrap = false;
            this.BuildList.LargeImageList = this.imageList2;
            this.BuildList.Location = new System.Drawing.Point(13, 51);
            this.BuildList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuildList.MultiSelect = false;
            this.BuildList.Name = "BuildList";
            this.BuildList.Scrollable = false;
            this.BuildList.Size = new System.Drawing.Size(314, 351);
            this.BuildList.SmallImageList = this.imageList2;
            this.BuildList.StateImageList = this.imageList2;
            this.BuildList.TabIndex = 4;
            this.BuildList.TileSize = new System.Drawing.Size(1, 1);
            this.BuildList.UseCompatibleStateImageBehavior = false;
            this.BuildList.View = System.Windows.Forms.View.Details;
            this.BuildList.SelectedIndexChanged += new System.EventHandler(this.BuildList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Builds";
            this.columnHeader1.Width = 313;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "supply.gif");
            this.imageList2.Images.SetKeyName(1, "RandomIcon.jpg");
            this.imageList2.Images.SetKeyName(2, "terran.gif");
            this.imageList2.Images.SetKeyName(3, "defaultportrait.png");
            this.imageList2.Images.SetKeyName(4, "TerranIcon.png");
            this.imageList2.Images.SetKeyName(5, "ProtossIcon.png");
            this.imageList2.Images.SetKeyName(6, "zergicon.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(779, 527);
            this.Controls.Add(this.BuildList);
            this.Controls.Add(this.StepList);
            this.Controls.Add(this.AppTitle);
            this.Controls.Add(this.FileMenu);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.FileMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StarCraft 2 Build Helper";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView StepList;
        private System.Windows.Forms.ColumnHeader StepHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView BuildList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList2;

    }
}

