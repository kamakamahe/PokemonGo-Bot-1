namespace PokemonGo.RocketAPI.Console
{
    partial class Pokemons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemons));
            this.PokemonListView = new System.Windows.Forms.ListView();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnIVToNick = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iVsToNicknameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTexbox = new System.Windows.Forms.TextBox();
            this.checkBoxreload = new System.Windows.Forms.CheckBox();
            this.reloadsecondstextbox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.reloadtimer = new System.Windows.Forms.Timer(this.components);
            this.btnFullPowerUp = new System.Windows.Forms.Button();
            this.freezedenshit = new System.Windows.Forms.Timer(this.components);
            this.btnForceUnban = new System.Windows.Forms.Button();
            this.numPwrUpLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.changesPanel1 = new PokemonGo.RocketAPI.Console.ChangesPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.itemsPanel1 = new PokemonGo.RocketAPI.Console.ItemsPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RepeatRoute = new System.Windows.Forms.CheckBox();
            this.CreateRoute = new System.Windows.Forms.Button();
            this.locationPanel1 = new PokemonGo.RocketAPI.Console.LocationPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.playerPanel1 = new PokemonGo.RocketAPI.Console.PlayerPanel();
            this.tabPageEggs = new System.Windows.Forms.TabPage();
            this.eggsPanel1 = new PokemonGo.RocketAPI.Console.EggsPanel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.sniperPanel1 = new PokemonGo.RocketAPI.Console.SniperPanel();
            this.lang_tr_btn2 = new System.Windows.Forms.Button();
            this.lang_ptBR_btn2 = new System.Windows.Forms.Button();
            this.lang_spain_btn2 = new System.Windows.Forms.Button();
            this.lang_de_btn_2 = new System.Windows.Forms.Button();
            this.lang_en_btn2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadsecondstextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPwrUpLimit)).BeginInit();
            this.Options.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPageEggs.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PokemonListView
            // 
            this.PokemonListView.AllowColumnReorder = true;
            this.PokemonListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PokemonListView.FullRowSelect = true;
            this.PokemonListView.GridLines = true;
            this.PokemonListView.Location = new System.Drawing.Point(0, 0);
            this.PokemonListView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PokemonListView.Name = "PokemonListView";
            this.PokemonListView.Size = new System.Drawing.Size(892, 388);
            this.PokemonListView.TabIndex = 0;
            this.PokemonListView.UseCompatibleStateImageBehavior = false;
            this.PokemonListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // btnreload
            // 
            this.btnreload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreload.Location = new System.Drawing.Point(628, 444);
            this.btnreload.Margin = new System.Windows.Forms.Padding(2);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(171, 29);
            this.btnreload.TabIndex = 1;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEvolve
            // 
            this.btnEvolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEvolve.Location = new System.Drawing.Point(252, 408);
            this.btnEvolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(108, 29);
            this.btnEvolve.TabIndex = 2;
            this.btnEvolve.Text = "Evolve";
            this.btnEvolve.UseVisualStyleBackColor = true;
            this.btnEvolve.Click += new System.EventHandler(this.btnEvolve_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpgrade.Location = new System.Drawing.Point(156, 444);
            this.btnUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(92, 29);
            this.btnUpgrade.TabIndex = 3;
            this.btnUpgrade.Text = "PowerUp";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransfer.Location = new System.Drawing.Point(252, 444);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(108, 29);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnIVToNick
            // 
            this.btnIVToNick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIVToNick.Location = new System.Drawing.Point(156, 408);
            this.btnIVToNick.Margin = new System.Windows.Forms.Padding(2);
            this.btnIVToNick.Name = "btnIVToNick";
            this.btnIVToNick.Size = new System.Drawing.Size(92, 29);
            this.btnIVToNick.TabIndex = 45;
            this.btnIVToNick.Text = "Nickname";
            this.btnIVToNick.UseVisualStyleBackColor = true;
            this.btnIVToNick.Click += new System.EventHandler(this.BtnIVToNickClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.powerUpToolStripMenuItem,
            this.evolveToolStripMenuItem,
            this.iVsToNicknameToolStripMenuItem,
            this.changeFavouritesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 134);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // powerUpToolStripMenuItem
            // 
            this.powerUpToolStripMenuItem.Name = "powerUpToolStripMenuItem";
            this.powerUpToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.powerUpToolStripMenuItem.Text = "PowerUp";
            this.powerUpToolStripMenuItem.Click += new System.EventHandler(this.powerUpToolStripMenuItem_Click);
            // 
            // evolveToolStripMenuItem
            // 
            this.evolveToolStripMenuItem.Name = "evolveToolStripMenuItem";
            this.evolveToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.evolveToolStripMenuItem.Text = "Evolve";
            this.evolveToolStripMenuItem.Visible = false;
            this.evolveToolStripMenuItem.Click += new System.EventHandler(this.evolveToolStripMenuItem_Click);
            // 
            // iVsToNicknameToolStripMenuItem
            // 
            this.iVsToNicknameToolStripMenuItem.Name = "iVsToNicknameToolStripMenuItem";
            this.iVsToNicknameToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.iVsToNicknameToolStripMenuItem.Text = "IVs to Nickname";
            this.iVsToNicknameToolStripMenuItem.Click += new System.EventHandler(this.IVsToNicknameToolStripMenuItemClick);
            // 
            // changeFavouritesToolStripMenuItem
            // 
            this.changeFavouritesToolStripMenuItem.Name = "changeFavouritesToolStripMenuItem";
            this.changeFavouritesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.changeFavouritesToolStripMenuItem.Text = "Change Favourites";
            this.changeFavouritesToolStripMenuItem.Click += new System.EventHandler(this.changeFavouritesToolStripMenuItemClick);
            // 
            // statusTexbox
            // 
            this.statusTexbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTexbox.Enabled = false;
            this.statusTexbox.Location = new System.Drawing.Point(16, 531);
            this.statusTexbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusTexbox.Name = "statusTexbox";
            this.statusTexbox.Size = new System.Drawing.Size(895, 22);
            this.statusTexbox.TabIndex = 5;
            // 
            // checkBoxreload
            // 
            this.checkBoxreload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxreload.AutoSize = true;
            this.checkBoxreload.Location = new System.Drawing.Point(631, 411);
            this.checkBoxreload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxreload.Name = "checkBoxreload";
            this.checkBoxreload.Size = new System.Drawing.Size(114, 21);
            this.checkBoxreload.TabIndex = 6;
            this.checkBoxreload.Text = "Reload every";
            this.checkBoxreload.UseVisualStyleBackColor = true;
            this.checkBoxreload.CheckedChanged += new System.EventHandler(this.checkboxReload_CheckedChanged);
            // 
            // reloadsecondstextbox
            // 
            this.reloadsecondstextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadsecondstextbox.Location = new System.Drawing.Point(746, 410);
            this.reloadsecondstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reloadsecondstextbox.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.reloadsecondstextbox.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.reloadsecondstextbox.Name = "reloadsecondstextbox";
            this.reloadsecondstextbox.Size = new System.Drawing.Size(50, 22);
            this.reloadsecondstextbox.TabIndex = 7;
            this.reloadsecondstextbox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // reloadtimer
            // 
            this.reloadtimer.Interval = 1000;
            this.reloadtimer.Tick += new System.EventHandler(this.reloadtimer_Tick);
            // 
            // btnFullPowerUp
            // 
            this.btnFullPowerUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFullPowerUp.Location = new System.Drawing.Point(11, 444);
            this.btnFullPowerUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullPowerUp.Name = "btnFullPowerUp";
            this.btnFullPowerUp.Size = new System.Drawing.Size(140, 29);
            this.btnFullPowerUp.TabIndex = 11;
            this.btnFullPowerUp.Text = "FULL-PowerUp";
            this.btnFullPowerUp.UseVisualStyleBackColor = true;
            this.btnFullPowerUp.Click += new System.EventHandler(this.btnFullPowerUp_Click);
            // 
            // freezedenshit
            // 
            this.freezedenshit.Interval = 5000;
            this.freezedenshit.Tick += new System.EventHandler(this.freezedenshit_Tick);
            // 
            // btnForceUnban
            // 
            this.btnForceUnban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForceUnban.Location = new System.Drawing.Point(502, 409);
            this.btnForceUnban.Margin = new System.Windows.Forms.Padding(2);
            this.btnForceUnban.Name = "btnForceUnban";
            this.btnForceUnban.Size = new System.Drawing.Size(120, 29);
            this.btnForceUnban.TabIndex = 43;
            this.btnForceUnban.Text = "Pause Walking";
            this.btnForceUnban.UseVisualStyleBackColor = true;
            this.btnForceUnban.Click += new System.EventHandler(this.btnForceUnban_Click);
            // 
            // numPwrUpLimit
            // 
            this.numPwrUpLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPwrUpLimit.Location = new System.Drawing.Point(101, 412);
            this.numPwrUpLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPwrUpLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numPwrUpLimit.Name = "numPwrUpLimit";
            this.numPwrUpLimit.Size = new System.Drawing.Size(49, 22);
            this.numPwrUpLimit.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Power Up Qty";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(502, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Use Incense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(366, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 29);
            this.button2.TabIndex = 43;
            this.button2.Text = "Use Lure";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(366, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 29);
            this.button3.TabIndex = 43;
            this.button3.Text = "Use Lucky Egg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.Controls.Add(this.tabPage2);
            this.Options.Controls.Add(this.tabPage1);
            this.Options.Controls.Add(this.tabPage3);
            this.Options.Controls.Add(this.tabPage4);
            this.Options.Controls.Add(this.tabPage5);
            this.Options.Controls.Add(this.tabPageEggs);
            this.Options.Controls.Add(this.tabPage6);
            this.Options.Location = new System.Drawing.Point(16, 14);
            this.Options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Options.Name = "Options";
            this.Options.SelectedIndex = 0;
            this.Options.Size = new System.Drawing.Size(899, 516);
            this.Options.TabIndex = 46;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.reloadsecondstextbox);
            this.tabPage2.Controls.Add(this.checkBoxreload);
            this.tabPage2.Controls.Add(this.PokemonListView);
            this.tabPage2.Controls.Add(this.btnreload);
            this.tabPage2.Controls.Add(this.btnUpgrade);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnShowMap);
            this.tabPage2.Controls.Add(this.btnFullPowerUp);
            this.tabPage2.Controls.Add(this.btnForceUnban);
            this.tabPage2.Controls.Add(this.numPwrUpLimit);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnEvolve);
            this.tabPage2.Controls.Add(this.btnTransfer);
            this.tabPage2.Controls.Add(this.btnIVToNick);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(891, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pokemon List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowMap
            // 
            this.btnShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowMap.Image = global::PokemonGo.RocketAPI.Console.Properties.Resources.map;
            this.btnShowMap.Location = new System.Drawing.Point(805, 408);
            this.btnShowMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(72, 65);
            this.btnShowMap.TabIndex = 12;
            this.btnShowMap.UseVisualStyleBackColor = true;
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.changesPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(891, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // changesPanel1
            // 
            this.changesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changesPanel1.Location = new System.Drawing.Point(0, 0);
            this.changesPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.changesPanel1.Name = "changesPanel1";
            this.changesPanel1.Size = new System.Drawing.Size(895, 483);
            this.changesPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.itemsPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(891, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // itemsPanel1
            // 
            this.itemsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsPanel1.Location = new System.Drawing.Point(6, 6);
            this.itemsPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itemsPanel1.Name = "itemsPanel1";
            this.itemsPanel1.Size = new System.Drawing.Size(875, 485);
            this.itemsPanel1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RepeatRoute);
            this.tabPage4.Controls.Add(this.CreateRoute);
            this.tabPage4.Controls.Add(this.locationPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(891, 487);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Location";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RepeatRoute
            // 
            this.RepeatRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatRoute.AutoSize = true;
            this.RepeatRoute.Enabled = false;
            this.RepeatRoute.Location = new System.Drawing.Point(764, 427);
            this.RepeatRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RepeatRoute.Name = "RepeatRoute";
            this.RepeatRoute.Size = new System.Drawing.Size(118, 21);
            this.RepeatRoute.TabIndex = 46;
            this.RepeatRoute.Text = "Repeat Route";
            this.RepeatRoute.UseVisualStyleBackColor = true;
            this.RepeatRoute.CheckedChanged += new System.EventHandler(this.RepeatRoute_CheckedChanged);
            // 
            // CreateRoute
            // 
            this.CreateRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateRoute.Location = new System.Drawing.Point(764, 454);
            this.CreateRoute.Margin = new System.Windows.Forms.Padding(2);
            this.CreateRoute.Name = "CreateRoute";
            this.CreateRoute.Size = new System.Drawing.Size(111, 29);
            this.CreateRoute.TabIndex = 47;
            this.CreateRoute.Text = "Define Route";
            this.CreateRoute.UseVisualStyleBackColor = true;
            this.CreateRoute.Click += new System.EventHandler(this.CreateRoute_Click);
            // 
            // locationPanel1
            // 
            this.locationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationPanel1.Location = new System.Drawing.Point(4, 4);
            this.locationPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.locationPanel1.Name = "locationPanel1";
            this.locationPanel1.Size = new System.Drawing.Size(887, 479);
            this.locationPanel1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.playerPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(891, 487);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Player Information";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // playerPanel1
            // 
            this.playerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerPanel1.BuddyInfoEnabled = false;
            this.playerPanel1.Location = new System.Drawing.Point(0, 0);
            this.playerPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.playerPanel1.Name = "playerPanel1";
            this.playerPanel1.Size = new System.Drawing.Size(891, 298);
            this.playerPanel1.TabIndex = 0;
            // 
            // tabPageEggs
            // 
            this.tabPageEggs.Controls.Add(this.eggsPanel1);
            this.tabPageEggs.Location = new System.Drawing.Point(4, 25);
            this.tabPageEggs.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEggs.Name = "tabPageEggs";
            this.tabPageEggs.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEggs.Size = new System.Drawing.Size(891, 487);
            this.tabPageEggs.TabIndex = 5;
            this.tabPageEggs.Text = "Eggs";
            this.tabPageEggs.UseVisualStyleBackColor = true;
            // 
            // eggsPanel1
            // 
            this.eggsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eggsPanel1.AutoSize = true;
            this.eggsPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eggsPanel1.Location = new System.Drawing.Point(6, 6);
            this.eggsPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.eggsPanel1.Name = "eggsPanel1";
            this.eggsPanel1.Size = new System.Drawing.Size(881, 388);
            this.eggsPanel1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.sniperPanel1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(891, 487);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Sniper Tools";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // sniperPanel1
            // 
            this.sniperPanel1.Location = new System.Drawing.Point(19, 6);
            this.sniperPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sniperPanel1.Name = "sniperPanel1";
            this.sniperPanel1.Size = new System.Drawing.Size(872, 481);
            this.sniperPanel1.TabIndex = 0;
            // 
            // lang_tr_btn2
            // 
            this.lang_tr_btn2.BackgroundImage = global::PokemonGo.RocketAPI.Console.Properties.Resources.tr1;
            this.lang_tr_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lang_tr_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lang_tr_btn2.Location = new System.Drawing.Point(865, 11);
            this.lang_tr_btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang_tr_btn2.Name = "lang_tr_btn2";
            this.lang_tr_btn2.Size = new System.Drawing.Size(30, 19);
            this.lang_tr_btn2.TabIndex = 42;
            this.lang_tr_btn2.UseVisualStyleBackColor = false;
            this.lang_tr_btn2.Click += new System.EventHandler(this.lang_tr_btn2_Click);
            // 
            // lang_ptBR_btn2
            // 
            this.lang_ptBR_btn2.BackgroundImage = global::PokemonGo.RocketAPI.Console.Properties.Resources.ptBR;
            this.lang_ptBR_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lang_ptBR_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lang_ptBR_btn2.Location = new System.Drawing.Point(828, 11);
            this.lang_ptBR_btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang_ptBR_btn2.Name = "lang_ptBR_btn2";
            this.lang_ptBR_btn2.Size = new System.Drawing.Size(30, 19);
            this.lang_ptBR_btn2.TabIndex = 42;
            this.lang_ptBR_btn2.UseVisualStyleBackColor = false;
            this.lang_ptBR_btn2.Click += new System.EventHandler(this.lang_ptBR_btn2_Click);
            // 
            // lang_spain_btn2
            // 
            this.lang_spain_btn2.BackgroundImage = global::PokemonGo.RocketAPI.Console.Properties.Resources.spain;
            this.lang_spain_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lang_spain_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lang_spain_btn2.Location = new System.Drawing.Point(790, 11);
            this.lang_spain_btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang_spain_btn2.Name = "lang_spain_btn2";
            this.lang_spain_btn2.Size = new System.Drawing.Size(30, 19);
            this.lang_spain_btn2.TabIndex = 15;
            this.lang_spain_btn2.UseVisualStyleBackColor = false;
            this.lang_spain_btn2.Click += new System.EventHandler(this.lang_spain_btn2_Click);
            // 
            // lang_de_btn_2
            // 
            this.lang_de_btn_2.BackgroundImage = global::PokemonGo.RocketAPI.Console.Properties.Resources.de;
            this.lang_de_btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lang_de_btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lang_de_btn_2.Location = new System.Drawing.Point(752, 11);
            this.lang_de_btn_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang_de_btn_2.Name = "lang_de_btn_2";
            this.lang_de_btn_2.Size = new System.Drawing.Size(30, 19);
            this.lang_de_btn_2.TabIndex = 14;
            this.lang_de_btn_2.UseVisualStyleBackColor = false;
            this.lang_de_btn_2.Click += new System.EventHandler(this.lang_de_btn_2_Click);
            // 
            // lang_en_btn2
            // 
            this.lang_en_btn2.BackgroundImage = global::PokemonGo.RocketAPI.Console.Properties.Resources.en;
            this.lang_en_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lang_en_btn2.Enabled = false;
            this.lang_en_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lang_en_btn2.Location = new System.Drawing.Point(715, 11);
            this.lang_en_btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang_en_btn2.Name = "lang_en_btn2";
            this.lang_en_btn2.Size = new System.Drawing.Size(30, 19);
            this.lang_en_btn2.TabIndex = 13;
            this.lang_en_btn2.UseVisualStyleBackColor = false;
            this.lang_en_btn2.Click += new System.EventHandler(this.lang_en_btn2_Click);
            // 
            // Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(929, 570);
            this.Controls.Add(this.lang_tr_btn2);
            this.Controls.Add(this.lang_ptBR_btn2);
            this.Controls.Add(this.lang_spain_btn2);
            this.Controls.Add(this.lang_de_btn_2);
            this.Controls.Add(this.lang_en_btn2);
            this.Controls.Add(this.statusTexbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Options);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(913, 603);
            this.Name = "Pokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pokemons_Close);
            this.Load += new System.EventHandler(this.Pokemons_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reloadsecondstextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPwrUpLimit)).EndInit();
            this.Options.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPageEggs.ResumeLayout(false);
            this.tabPageEggs.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PokemonListView;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnIVToNick;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.TextBox statusTexbox;
        private System.Windows.Forms.ToolStripMenuItem powerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iVsToNicknameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFavouritesToolStripMenuItem;        
        private System.Windows.Forms.CheckBox checkBoxreload;
        private System.Windows.Forms.NumericUpDown reloadsecondstextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer reloadtimer;
        private System.Windows.Forms.Button btnFullPowerUp;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.Button lang_en_btn2;
        private System.Windows.Forms.Button lang_de_btn_2;
        private System.Windows.Forms.Button lang_spain_btn2;
        private System.Windows.Forms.Button lang_ptBR_btn2;
        private System.Windows.Forms.Timer freezedenshit;
        private System.Windows.Forms.Button lang_tr_btn2;
        private System.Windows.Forms.Button btnForceUnban;
        private System.Windows.Forms.NumericUpDown numPwrUpLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl Options;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
                
        private System.Windows.Forms.TextBox NumericUpDown;
        private PokemonGo.RocketAPI.Console.ItemsPanel itemsPanel1;
        private System.Windows.Forms.TabPage tabPage4;
        private PokemonGo.RocketAPI.Console.LocationPanel locationPanel1;
        private System.Windows.Forms.TabPage tabPage5;
        private PokemonGo.RocketAPI.Console.PlayerPanel playerPanel1;
        private System.Windows.Forms.TabPage tabPageEggs;
        private PokemonGo.RocketAPI.Console.EggsPanel eggsPanel1;
        private PokemonGo.RocketAPI.Console.ChangesPanel changesPanel1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox RepeatRoute;
        private System.Windows.Forms.Button CreateRoute;
        private PokemonGo.RocketAPI.Console.SniperPanel sniperPanel1;
    }
}