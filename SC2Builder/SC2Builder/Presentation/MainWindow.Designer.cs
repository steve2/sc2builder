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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenu
            // 
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.FileMenu.Size = new System.Drawing.Size(870, 24);
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
            this.StepList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StepList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StepHeader});
            this.StepList.Font = new System.Drawing.Font("Calibri Light", 8.75F);
            this.StepList.FullRowSelect = true;
            this.StepList.GridLines = true;
            this.StepList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StepList.LabelWrap = false;
            this.StepList.Location = new System.Drawing.Point(331, 24);
            this.StepList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StepList.MultiSelect = false;
            this.StepList.Name = "StepList";
            this.StepList.Size = new System.Drawing.Size(210, 295);
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
            this.imageList1.Images.SetKeyName(0, "bronze.png");
            this.imageList1.Images.SetKeyName(1, "cross.png");
            this.imageList1.Images.SetKeyName(2, "defaultportrait.png");
            this.imageList1.Images.SetKeyName(3, "diamond.png");
            this.imageList1.Images.SetKeyName(4, "gold.png");
            this.imageList1.Images.SetKeyName(5, "grandmaster.png");
            this.imageList1.Images.SetKeyName(6, "imageicon.gif");
            this.imageList1.Images.SetKeyName(7, "master.png");
            this.imageList1.Images.SetKeyName(8, "none.png");
            this.imageList1.Images.SetKeyName(9, "platinum.png");
            this.imageList1.Images.SetKeyName(10, "portrait-summary.png");
            this.imageList1.Images.SetKeyName(11, "protoss.gif");
            this.imageList1.Images.SetKeyName(12, "ProtossIcon.png");
            this.imageList1.Images.SetKeyName(13, "random.gif");
            this.imageList1.Images.SetKeyName(14, "RandomIcon.jpg");
            this.imageList1.Images.SetKeyName(15, "RandomIcon.png");
            this.imageList1.Images.SetKeyName(16, "silver.png");
            this.imageList1.Images.SetKeyName(17, "snapshot-protoss.png");
            this.imageList1.Images.SetKeyName(18, "snapshot-random.png");
            this.imageList1.Images.SetKeyName(19, "snapshot-terran.png");
            this.imageList1.Images.SetKeyName(20, "snapshot-zerg.png");
            this.imageList1.Images.SetKeyName(21, "terran.gif");
            this.imageList1.Images.SetKeyName(22, "TerranIcon.png");
            this.imageList1.Images.SetKeyName(23, "texticon.gif");
            this.imageList1.Images.SetKeyName(24, "tick.png");
            this.imageList1.Images.SetKeyName(25, "zerg.gif");
            this.imageList1.Images.SetKeyName(26, "zergicon.png");
            this.imageList1.Images.SetKeyName(27, "gas.gif");
            this.imageList1.Images.SetKeyName(28, "minerals.gif");
            this.imageList1.Images.SetKeyName(29, "supply.gif");
            this.imageList1.Images.SetKeyName(30, "time.gif");
            this.imageList1.Images.SetKeyName(31, "gas.gif");
            this.imageList1.Images.SetKeyName(32, "minerals.gif");
            this.imageList1.Images.SetKeyName(33, "supply.gif");
            this.imageList1.Images.SetKeyName(34, "time.gif");
            this.imageList1.Images.SetKeyName(35, "gas.gif");
            this.imageList1.Images.SetKeyName(36, "minerals.gif");
            this.imageList1.Images.SetKeyName(37, "supply.gif");
            this.imageList1.Images.SetKeyName(38, "time.gif");
            this.imageList1.Images.SetKeyName(39, "btn-building-protoss-assimilator.png");
            this.imageList1.Images.SetKeyName(40, "btn-building-protoss-cyberneticscore.png");
            this.imageList1.Images.SetKeyName(41, "btn-building-protoss-darkshrine.png");
            this.imageList1.Images.SetKeyName(42, "btn-building-protoss-energycrystal.png");
            this.imageList1.Images.SetKeyName(43, "btn-building-protoss-eyeofadun.png");
            this.imageList1.Images.SetKeyName(44, "btn-building-protoss-fleetbeacon.png");
            this.imageList1.Images.SetKeyName(45, "btn-building-protoss-forge.png");
            this.imageList1.Images.SetKeyName(46, "btn-building-protoss-gateway.png");
            this.imageList1.Images.SetKeyName(47, "btn-building-protoss-nexus.png");
            this.imageList1.Images.SetKeyName(48, "btn-building-protoss-obelisk.png");
            this.imageList1.Images.SetKeyName(49, "btn-building-protoss-phasecannon.png");
            this.imageList1.Images.SetKeyName(50, "btn-building-protoss-photoncannon.png");
            this.imageList1.Images.SetKeyName(51, "btn-building-protoss-pylon.png");
            this.imageList1.Images.SetKeyName(52, "btn-building-protoss-roboticsfacility.png");
            this.imageList1.Images.SetKeyName(53, "btn-building-protoss-roboticssupportbay.png");
            this.imageList1.Images.SetKeyName(54, "btn-building-protoss-stargate.png");
            this.imageList1.Images.SetKeyName(55, "btn-building-protoss-templararchives.png");
            this.imageList1.Images.SetKeyName(56, "btn-building-protoss-twilightcouncil.png");
            this.imageList1.Images.SetKeyName(57, "btn-building-protoss-warpgate.png");
            this.imageList1.Images.SetKeyName(58, "btn-building-terran-armory.png");
            this.imageList1.Images.SetKeyName(59, "btn-building-terran-autoturret.png");
            this.imageList1.Images.SetKeyName(60, "btn-building-terran-barracks.png");
            this.imageList1.Images.SetKeyName(61, "btn-building-terran-bunker.png");
            this.imageList1.Images.SetKeyName(62, "btn-building-terran-commandcenter.png");
            this.imageList1.Images.SetKeyName(63, "btn-building-terran-deepspacerelay.png");
            this.imageList1.Images.SetKeyName(64, "btn-building-terran-engineeringbay.png");
            this.imageList1.Images.SetKeyName(65, "btn-building-terran-factory.png");
            this.imageList1.Images.SetKeyName(66, "btn-building-terran-fusioncore.png");
            this.imageList1.Images.SetKeyName(67, "btn-building-terran-ghostacademy.png");
            this.imageList1.Images.SetKeyName(68, "btn-building-terran-merccompound.png");
            this.imageList1.Images.SetKeyName(69, "btn-building-terran-mercenaryport.png");
            this.imageList1.Images.SetKeyName(70, "btn-building-terran-missileturret.png");
            this.imageList1.Images.SetKeyName(71, "btn-building-terran-planetaryfortress.png");
            this.imageList1.Images.SetKeyName(72, "btn-building-terran-reactor.png");
            this.imageList1.Images.SetKeyName(73, "btn-building-terran-refinery.png");
            this.imageList1.Images.SetKeyName(74, "btn-building-terran-sensordome.png");
            this.imageList1.Images.SetKeyName(75, "btn-building-terran-starport.png");
            this.imageList1.Images.SetKeyName(76, "btn-building-terran-supplydepot.png");
            this.imageList1.Images.SetKeyName(77, "btn-building-terran-supplydepotlowered.png");
            this.imageList1.Images.SetKeyName(78, "btn-building-terran-surveillancestation.png");
            this.imageList1.Images.SetKeyName(79, "btn-building-terran-techlab.png");
            this.imageList1.Images.SetKeyName(80, "btn-building-zerg-banelingnest.png");
            this.imageList1.Images.SetKeyName(81, "btn-building-zerg-creeptumor.png");
            this.imageList1.Images.SetKeyName(82, "btn-building-zerg-evolutionchamber.png");
            this.imageList1.Images.SetKeyName(83, "btn-building-zerg-extractor.png");
            this.imageList1.Images.SetKeyName(84, "btn-building-zerg-greaterspire.png");
            this.imageList1.Images.SetKeyName(85, "btn-building-zerg-hatchery.png");
            this.imageList1.Images.SetKeyName(86, "btn-building-zerg-hive.png");
            this.imageList1.Images.SetKeyName(87, "btn-building-zerg-hydraliskden.png");
            this.imageList1.Images.SetKeyName(88, "btn-building-zerg-infestationpit.png");
            this.imageList1.Images.SetKeyName(89, "btn-building-zerg-infestorpit.png");
            this.imageList1.Images.SetKeyName(90, "btn-building-zerg-lair.png");
            this.imageList1.Images.SetKeyName(91, "btn-building-zerg-lurkerden.png");
            this.imageList1.Images.SetKeyName(92, "btn-building-zerg-nydusnetwork.png");
            this.imageList1.Images.SetKeyName(93, "btn-building-zerg-nydusworm.png");
            this.imageList1.Images.SetKeyName(94, "btn-building-zerg-roachwarren.png");
            this.imageList1.Images.SetKeyName(95, "btn-building-zerg-spawningpool.png");
            this.imageList1.Images.SetKeyName(96, "btn-building-zerg-spinecrawler.png");
            this.imageList1.Images.SetKeyName(97, "btn-building-zerg-spire.png");
            this.imageList1.Images.SetKeyName(98, "btn-building-zerg-sporecrawler.png");
            this.imageList1.Images.SetKeyName(99, "btn-building-zerg-ultraliskcavern.png");
            this.imageList1.Images.SetKeyName(100, "btn-unit-protoss-archon.png");
            this.imageList1.Images.SetKeyName(101, "btn-unit-protoss-carrier.png");
            this.imageList1.Images.SetKeyName(102, "btn-unit-protoss-colossus.png");
            this.imageList1.Images.SetKeyName(103, "btn-unit-protoss-darktemplar.png");
            this.imageList1.Images.SetKeyName(104, "btn-unit-protoss-hightemplar.png");
            this.imageList1.Images.SetKeyName(105, "btn-unit-protoss-immortal.png");
            this.imageList1.Images.SetKeyName(106, "btn-unit-protoss-interceptor.png");
            this.imageList1.Images.SetKeyName(107, "btn-unit-protoss-mothership.png");
            this.imageList1.Images.SetKeyName(108, "btn-unit-protoss-nullifier.png");
            this.imageList1.Images.SetKeyName(109, "btn-unit-protoss-observer.png");
            this.imageList1.Images.SetKeyName(110, "btn-unit-protoss-phaseprism.png");
            this.imageList1.Images.SetKeyName(111, "btn-unit-protoss-phaseprismstationary.png");
            this.imageList1.Images.SetKeyName(112, "btn-unit-protoss-phoenix.png");
            this.imageList1.Images.SetKeyName(113, "btn-unit-protoss-probe.png");
            this.imageList1.Images.SetKeyName(114, "btn-unit-protoss-sentry.png");
            this.imageList1.Images.SetKeyName(115, "btn-unit-protoss-stalker.png");
            this.imageList1.Images.SetKeyName(116, "btn-unit-protoss-warpprism.png");
            this.imageList1.Images.SetKeyName(117, "btn-unit-protoss-warpprismstationary.png");
            this.imageList1.Images.SetKeyName(118, "btn-unit-protoss-warpray.png");
            this.imageList1.Images.SetKeyName(119, "btn-unit-protoss-zealot.png");
            this.imageList1.Images.SetKeyName(120, "btn-unit-targetingdrone.png");
            this.imageList1.Images.SetKeyName(121, "btn-unit-terran-banshee.png");
            this.imageList1.Images.SetKeyName(122, "btn-unit-terran-battlecruiser.png");
            this.imageList1.Images.SetKeyName(123, "btn-unit-terran-cobra.png");
            this.imageList1.Images.SetKeyName(124, "btn-unit-terran-diamondback.png");
            this.imageList1.Images.SetKeyName(125, "btn-unit-terran-dropship.png");
            this.imageList1.Images.SetKeyName(126, "btn-unit-terran-firebat.png");
            this.imageList1.Images.SetKeyName(127, "btn-unit-terran-ghost.png");
            this.imageList1.Images.SetKeyName(128, "btn-unit-terran-hellion.png");
            this.imageList1.Images.SetKeyName(129, "btn-unit-terran-hurcules.png");
            this.imageList1.Images.SetKeyName(130, "btn-unit-terran-jackal.png");
            this.imageList1.Images.SetKeyName(131, "btn-unit-terran-marauder.png");
            this.imageList1.Images.SetKeyName(132, "btn-unit-terran-marine.png");
            this.imageList1.Images.SetKeyName(133, "btn-unit-terran-medivac.png");
            this.imageList1.Images.SetKeyName(134, "btn-unit-terran-mule.png");
            this.imageList1.Images.SetKeyName(135, "btn-unit-terran-nomad.png");
            this.imageList1.Images.SetKeyName(136, "btn-unit-terran-raven.png");
            this.imageList1.Images.SetKeyName(137, "btn-unit-terran-reaper.png");
            this.imageList1.Images.SetKeyName(138, "btn-unit-terran-scv.png");
            this.imageList1.Images.SetKeyName(139, "btn-unit-terran-siegetank.png");
            this.imageList1.Images.SetKeyName(140, "btn-unit-terran-siegetanksiegemode.png");
            this.imageList1.Images.SetKeyName(141, "btn-unit-terran-targetingdrone.png");
            this.imageList1.Images.SetKeyName(142, "btn-unit-terran-thor.png");
            this.imageList1.Images.SetKeyName(143, "btn-unit-terran-viking.png");
            this.imageList1.Images.SetKeyName(144, "btn-unit-terran-vikingassault.png");
            this.imageList1.Images.SetKeyName(145, "btn-unit-terran-vikingfighter.png");
            this.imageList1.Images.SetKeyName(146, "btn-unit-terran-vulture.png");
            this.imageList1.Images.SetKeyName(147, "btn-unit-zerg-baneling.png");
            this.imageList1.Images.SetKeyName(148, "btn-unit-zerg-broodlord.png");
            this.imageList1.Images.SetKeyName(149, "btn-unit-zerg-changeling.png");
            this.imageList1.Images.SetKeyName(150, "btn-unit-zerg-corruptedmass.png");
            this.imageList1.Images.SetKeyName(151, "btn-unit-zerg-corruptor.png");
            this.imageList1.Images.SetKeyName(152, "btn-unit-zerg-drone.png");
            this.imageList1.Images.SetKeyName(153, "btn-unit-zerg-egg.png");
            this.imageList1.Images.SetKeyName(154, "btn-unit-zerg-hydralisk.png");
            this.imageList1.Images.SetKeyName(155, "btn-unit-zerg-infestedmarine.png");
            this.imageList1.Images.SetKeyName(156, "btn-unit-zerg-infestor.png");
            this.imageList1.Images.SetKeyName(157, "btn-unit-zerg-larva.png");
            this.imageList1.Images.SetKeyName(158, "btn-unit-zerg-lurker.png");
            this.imageList1.Images.SetKeyName(159, "btn-unit-zerg-mantalisk.png");
            this.imageList1.Images.SetKeyName(160, "btn-unit-zerg-mutalisk.png");
            this.imageList1.Images.SetKeyName(161, "btn-unit-zerg-omegalisk.png");
            this.imageList1.Images.SetKeyName(162, "btn-unit-zerg-overlord.png");
            this.imageList1.Images.SetKeyName(163, "btn-unit-zerg-overseer.png");
            this.imageList1.Images.SetKeyName(164, "btn-unit-zerg-queen.png");
            this.imageList1.Images.SetKeyName(165, "btn-unit-zerg-roach.png");
            this.imageList1.Images.SetKeyName(166, "btn-unit-zerg-symbiote.png");
            this.imageList1.Images.SetKeyName(167, "btn-unit-zerg-ultralisk.png");
            this.imageList1.Images.SetKeyName(168, "btn-unit-zerg-zergling.png");
            this.imageList1.Images.SetKeyName(169, "btn-upgrade-protoss-airarmorlevel0.png");
            this.imageList1.Images.SetKeyName(170, "btn-upgrade-protoss-airarmorlevel1.png");
            this.imageList1.Images.SetKeyName(171, "btn-upgrade-protoss-airarmorlevel2.png");
            this.imageList1.Images.SetKeyName(172, "btn-upgrade-protoss-airarmorlevel3.png");
            this.imageList1.Images.SetKeyName(173, "btn-upgrade-protoss-airweaponslevel0.png");
            this.imageList1.Images.SetKeyName(174, "btn-upgrade-protoss-airweaponslevel1.png");
            this.imageList1.Images.SetKeyName(175, "btn-upgrade-protoss-airweaponslevel2.png");
            this.imageList1.Images.SetKeyName(176, "btn-upgrade-protoss-airweaponslevel3.png");
            this.imageList1.Images.SetKeyName(177, "btn-upgrade-protoss-extendedthermallance.png");
            this.imageList1.Images.SetKeyName(178, "btn-upgrade-protoss-fluxvanes.png");
            this.imageList1.Images.SetKeyName(179, "btn-upgrade-protoss-graviticbooster.png");
            this.imageList1.Images.SetKeyName(180, "btn-upgrade-protoss-graviticdrive.png");
            this.imageList1.Images.SetKeyName(181, "btn-upgrade-protoss-gravitoncatapult.png");
            this.imageList1.Images.SetKeyName(182, "btn-upgrade-protoss-groundarmorlevel0.png");
            this.imageList1.Images.SetKeyName(183, "btn-upgrade-protoss-groundarmorlevel1.png");
            this.imageList1.Images.SetKeyName(184, "btn-upgrade-protoss-groundarmorlevel2.png");
            this.imageList1.Images.SetKeyName(185, "btn-upgrade-protoss-groundarmorlevel3.png");
            this.imageList1.Images.SetKeyName(186, "btn-upgrade-protoss-groundweaponslevel0.png");
            this.imageList1.Images.SetKeyName(187, "btn-upgrade-protoss-groundweaponslevel1.png");
            this.imageList1.Images.SetKeyName(188, "btn-upgrade-protoss-groundweaponslevel2.png");
            this.imageList1.Images.SetKeyName(189, "btn-upgrade-protoss-groundweaponslevel3.png");
            this.imageList1.Images.SetKeyName(190, "btn-upgrade-protoss-khaydarinamulet.png");
            this.imageList1.Images.SetKeyName(191, "btn-upgrade-protoss-shieldslevel0.png");
            this.imageList1.Images.SetKeyName(192, "btn-upgrade-protoss-shieldslevel1.png");
            this.imageList1.Images.SetKeyName(193, "btn-upgrade-protoss-shieldslevel2.png");
            this.imageList1.Images.SetKeyName(194, "btn-upgrade-protoss-shieldslevel3.png");
            this.imageList1.Images.SetKeyName(195, "btn-upgrade-terran-behemothreactor.png");
            this.imageList1.Images.SetKeyName(196, "btn-upgrade-terran-buildingarmor.png");
            this.imageList1.Images.SetKeyName(197, "btn-upgrade-terran-caduceusreactor.png");
            this.imageList1.Images.SetKeyName(198, "btn-upgrade-terran-cloak.png");
            this.imageList1.Images.SetKeyName(199, "btn-upgrade-terran-corvidreactor.png");
            this.imageList1.Images.SetKeyName(200, "btn-upgrade-terran-durablematerials.png");
            this.imageList1.Images.SetKeyName(201, "btn-upgrade-terran-hisecautotracking.png");
            this.imageList1.Images.SetKeyName(202, "btn-upgrade-terran-infantryarmorlevel0.png");
            this.imageList1.Images.SetKeyName(203, "btn-upgrade-terran-infantryarmorlevel1.png");
            this.imageList1.Images.SetKeyName(204, "btn-upgrade-terran-infantryarmorlevel2.png");
            this.imageList1.Images.SetKeyName(205, "btn-upgrade-terran-infantryarmorlevel3.png");
            this.imageList1.Images.SetKeyName(206, "btn-upgrade-terran-infantryweaponslevel0.png");
            this.imageList1.Images.SetKeyName(207, "btn-upgrade-terran-infantryweaponslevel1.png");
            this.imageList1.Images.SetKeyName(208, "btn-upgrade-terran-infantryweaponslevel2.png");
            this.imageList1.Images.SetKeyName(209, "btn-upgrade-terran-infantryweaponslevel3.png");
            this.imageList1.Images.SetKeyName(210, "btn-upgrade-terran-infernalpreigniter.png");
            this.imageList1.Images.SetKeyName(211, "btn-upgrade-terran-jotunboosters.png");
            this.imageList1.Images.SetKeyName(212, "btn-upgrade-terran-mobiusreactor.png");
            this.imageList1.Images.SetKeyName(213, "btn-upgrade-terran-moebiusreactor.png");
            this.imageList1.Images.SetKeyName(214, "btn-upgrade-terran-neosteelframe.png");
            this.imageList1.Images.SetKeyName(215, "btn-upgrade-terran-reapernitropacks.png");
            this.imageList1.Images.SetKeyName(216, "btn-upgrade-terran-shipplatinglevel0.png");
            this.imageList1.Images.SetKeyName(217, "btn-upgrade-terran-shipplatinglevel1.png");
            this.imageList1.Images.SetKeyName(218, "btn-upgrade-terran-shipplatinglevel2.png");
            this.imageList1.Images.SetKeyName(219, "btn-upgrade-terran-shipplatinglevel3.png");
            this.imageList1.Images.SetKeyName(220, "btn-upgrade-terran-shipweaponslevel0.png");
            this.imageList1.Images.SetKeyName(221, "btn-upgrade-terran-shipweaponslevel1.png");
            this.imageList1.Images.SetKeyName(222, "btn-upgrade-terran-shipweaponslevel2.png");
            this.imageList1.Images.SetKeyName(223, "btn-upgrade-terran-shipweaponslevel3.png");
            this.imageList1.Images.SetKeyName(224, "btn-upgrade-terran-twin-linkedflamethrower.png");
            this.imageList1.Images.SetKeyName(225, "btn-upgrade-terran-vehicleplatinglevel0.png");
            this.imageList1.Images.SetKeyName(226, "btn-upgrade-terran-vehicleplatinglevel1.png");
            this.imageList1.Images.SetKeyName(227, "btn-upgrade-terran-vehicleplatinglevel2.png");
            this.imageList1.Images.SetKeyName(228, "btn-upgrade-terran-vehicleplatinglevel3.png");
            this.imageList1.Images.SetKeyName(229, "btn-upgrade-terran-vehicleweaponslevel0.png");
            this.imageList1.Images.SetKeyName(230, "btn-upgrade-terran-vehicleweaponslevel1.png");
            this.imageList1.Images.SetKeyName(231, "btn-upgrade-terran-vehicleweaponslevel2.png");
            this.imageList1.Images.SetKeyName(232, "btn-upgrade-terran-vehicleweaponslevel3.png");
            this.imageList1.Images.SetKeyName(233, "btn-upgrade-terran-weaponrefit.png");
            this.imageList1.Images.SetKeyName(234, "btn-upgrade-zerg-adrenalglands.png");
            this.imageList1.Images.SetKeyName(235, "btn-upgrade-zerg-airattacks-level0.png");
            this.imageList1.Images.SetKeyName(236, "btn-upgrade-zerg-airattacks-level1.png");
            this.imageList1.Images.SetKeyName(237, "btn-upgrade-zerg-airattacks-level2.png");
            this.imageList1.Images.SetKeyName(238, "btn-upgrade-zerg-airattacks-level3.png");
            this.imageList1.Images.SetKeyName(239, "btn-upgrade-zerg-anabolicsynthesis.png");
            this.imageList1.Images.SetKeyName(240, "btn-upgrade-zerg-buildingarmor.png");
            this.imageList1.Images.SetKeyName(241, "btn-upgrade-zerg-centrifugalhooks.png");
            this.imageList1.Images.SetKeyName(242, "btn-upgrade-zerg-chitinousplating.png");
            this.imageList1.Images.SetKeyName(243, "btn-upgrade-zerg-cleave.png");
            this.imageList1.Images.SetKeyName(244, "btn-upgrade-zerg-enduringcorruption.png");
            this.imageList1.Images.SetKeyName(245, "btn-upgrade-zerg-flyercarapace-level0.png");
            this.imageList1.Images.SetKeyName(246, "btn-upgrade-zerg-flyercarapace-level1.png");
            this.imageList1.Images.SetKeyName(247, "btn-upgrade-zerg-flyercarapace-level2.png");
            this.imageList1.Images.SetKeyName(248, "btn-upgrade-zerg-flyercarapace-level3.png");
            this.imageList1.Images.SetKeyName(249, "btn-upgrade-zerg-glialreconstitution.png");
            this.imageList1.Images.SetKeyName(250, "btn-upgrade-zerg-groovedspines.png");
            this.imageList1.Images.SetKeyName(251, "btn-upgrade-zerg-groundcarapace-level0.png");
            this.imageList1.Images.SetKeyName(252, "btn-upgrade-zerg-groundcarapace-level1.png");
            this.imageList1.Images.SetKeyName(253, "btn-upgrade-zerg-groundcarapace-level2.png");
            this.imageList1.Images.SetKeyName(254, "btn-upgrade-zerg-groundcarapace-level3.png");
            this.imageList1.Images.SetKeyName(255, "btn-upgrade-zerg-meleeattacks-leve3.png");
            this.imageList1.Images.SetKeyName(256, "btn-upgrade-zerg-meleeattacks-level0.png");
            this.imageList1.Images.SetKeyName(257, "btn-upgrade-zerg-meleeattacks-level1.png");
            this.imageList1.Images.SetKeyName(258, "btn-upgrade-zerg-meleeattacks-level2.png");
            this.imageList1.Images.SetKeyName(259, "btn-upgrade-zerg-meleeattacks-level3.png");
            this.imageList1.Images.SetKeyName(260, "btn-upgrade-zerg-metabolicboost.png");
            this.imageList1.Images.SetKeyName(261, "btn-upgrade-zerg-missileattacks-level0.png");
            this.imageList1.Images.SetKeyName(262, "btn-upgrade-zerg-missileattacks-level1.png");
            this.imageList1.Images.SetKeyName(263, "btn-upgrade-zerg-missileattacks-level2.png");
            this.imageList1.Images.SetKeyName(264, "btn-upgrade-zerg-missileattacks-level3.png");
            this.imageList1.Images.SetKeyName(265, "btn-upgrade-zerg-muscularaugments.png");
            this.imageList1.Images.SetKeyName(266, "btn-upgrade-zerg-organiccarapace.png");
            this.imageList1.Images.SetKeyName(267, "btn-upgrade-zerg-pathogenglands.png");
            this.imageList1.Images.SetKeyName(268, "btn-upgrade-zerg-peristalsis.png");
            this.imageList1.Images.SetKeyName(269, "btn-upgrade-zerg-pneumatizedcarapace.png");
            this.imageList1.Images.SetKeyName(270, "btn-upgrade-zerg-seismicspines.png");
            this.imageList1.Images.SetKeyName(271, "btn-upgrade-zerg-tunnelingclaws.png");
            this.imageList1.Images.SetKeyName(272, "btn-upgrade-zerg-ventralsacs.png");
            // 
            // BuildList
            // 
            this.BuildList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuildList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.BuildList.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildList.FullRowSelect = true;
            this.BuildList.GridLines = true;
            this.BuildList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BuildList.LabelWrap = false;
            this.BuildList.Location = new System.Drawing.Point(7, 24);
            this.BuildList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuildList.MultiSelect = false;
            this.BuildList.Name = "BuildList";
            this.BuildList.Size = new System.Drawing.Size(316, 295);
            this.BuildList.SmallImageList = this.imageList1;
            this.BuildList.TabIndex = 4;
            this.BuildList.TileSize = new System.Drawing.Size(1, 1);
            this.BuildList.UseCompatibleStateImageBehavior = false;
            this.BuildList.View = System.Windows.Forms.View.Details;
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
            this.columnHeader2.Width = 54;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Matchup";
            this.columnHeader3.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StepList);
            this.groupBox1.Controls.Add(this.BuildList);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 327);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Previewer";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(565, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 464);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Build Editor";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(870, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FileMenu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.FileMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarCraft 2 Build Helper";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

