namespace Mp3_Player
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPath = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.btnType = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShuffle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPlaying = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstPlaylist = new System.Windows.Forms.ListView();
            this.clmFileName = new System.Windows.Forms.ColumnHeader();
            this.clmPath = new System.Windows.Forms.ColumnHeader();
            this.clmArtist = new System.Windows.Forms.ColumnHeader();
            this.clmTitle = new System.Windows.Forms.ColumnHeader();
            this.clmAlbum = new System.Windows.Forms.ColumnHeader();
            this.clmType = new System.Windows.Forms.ColumnHeader();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.trbBalance = new System.Windows.Forms.TrackBar();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnTrackNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.toolStripMenuItem1,
            this.btnPlayBack,
            this.infoToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(701, 24);
            this.mnsMenu.TabIndex = 6;
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(35, 20);
            this.btnFile.Text = "&File";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addSongsToolStripMenuItem.Text = "&Open File";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowColumns,
            this.fontToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&Edit";
            // 
            // btnShowColumns
            // 
            this.btnShowColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileName,
            this.btnPath,
            this.btnArtist,
            this.btnTitle,
            this.btnAlbum,
            this.btnTrackNumber,
            this.btnType});
            this.btnShowColumns.Name = "btnShowColumns";
            this.btnShowColumns.Size = new System.Drawing.Size(154, 22);
            this.btnShowColumns.Text = "&Show Columns";
            // 
            // btnFileName
            // 
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(152, 22);
            this.btnFileName.Text = "File Name";
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // btnPath
            // 
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(152, 22);
            this.btnPath.Text = "Path";
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(152, 22);
            this.btnArtist.Text = "Artist";
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(152, 22);
            this.btnTitle.Text = "Title";
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(152, 22);
            this.btnAlbum.Text = "Album";
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnType
            // 
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(152, 22);
            this.btnType.Text = "Type";
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.textColorToolStripMenuItem.Text = "&Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // btnPlayBack
            // 
            this.btnPlayBack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShuffle,
            this.btnLoop});
            this.btnPlayBack.Name = "btnPlayBack";
            this.btnPlayBack.Size = new System.Drawing.Size(61, 20);
            this.btnPlayBack.Text = "&Playback";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(152, 22);
            this.btnShuffle.Text = "&Shuffle";
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(152, 22);
            this.btnLoop.Text = "&Loop";
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPlaying});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPlaying
            // 
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(0, 17);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.AllowDrop = true;
            this.lstPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlaylist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFileName,
            this.clmPath,
            this.clmArtist,
            this.clmTitle,
            this.clmAlbum,
            this.clmType});
            this.lstPlaylist.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstPlaylist.FullRowSelect = true;
            this.lstPlaylist.HideSelection = false;
            this.lstPlaylist.Location = new System.Drawing.Point(-3, 86);
            this.lstPlaylist.MultiSelect = false;
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.ShowGroups = false;
            this.lstPlaylist.Size = new System.Drawing.Size(704, 284);
            this.lstPlaylist.TabIndex = 8;
            this.lstPlaylist.UseCompatibleStateImageBehavior = false;
            this.lstPlaylist.View = System.Windows.Forms.View.Details;
            this.lstPlaylist.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lstPlaylist_ColumnWidthChanged);
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            this.lstPlaylist.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.lstPlaylist.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // clmFileName
            // 
            this.clmFileName.Text = "File Name";
            this.clmFileName.Width = 0;
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path";
            this.clmPath.Width = 0;
            // 
            // clmArtist
            // 
            this.clmArtist.Text = "Artist";
            this.clmArtist.Width = 100;
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Title";
            this.clmTitle.Width = 100;
            // 
            // clmAlbum
            // 
            this.clmAlbum.Text = "Album";
            this.clmAlbum.Width = 100;
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            this.clmType.Width = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // trackBar
            // 
            this.trackBar.AutoSize = false;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(0, 58);
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(318, 22);
            this.trackBar.TabIndex = 11;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseDown);
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTime.Location = new System.Drawing.Point(211, 26);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(98, 26);
            this.txtTime.TabIndex = 12;
            this.txtTime.Text = "00:00 / 00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Mp3_Player.Properties.Resources.play_off;
            this.btnPlay.Location = new System.Drawing.Point(12, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 25);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::Mp3_Player.Properties.Resources.pause_off;
            this.btnPause.Location = new System.Drawing.Point(43, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(25, 25);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.MouseLeave += new System.EventHandler(this.btnPause_MouseLeave);
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseHover += new System.EventHandler(this.btnPause_MouseHover);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Mp3_Player.Properties.Resources.stop_off;
            this.btnStop.Location = new System.Drawing.Point(74, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(25, 25);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseLeave += new System.EventHandler(this.btnStop_MouseLeave);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseHover += new System.EventHandler(this.btnStop_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Mp3_Player.Properties.Resources.next_off;
            this.btnNext.Location = new System.Drawing.Point(136, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::Mp3_Player.Properties.Resources.previus_off;
            this.btnPrevious.Location = new System.Drawing.Point(105, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 25);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // trbVolume
            // 
            this.trbVolume.AutoSize = false;
            this.trbVolume.Location = new System.Drawing.Point(396, 26);
            this.trbVolume.Maximum = 1000;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(104, 25);
            this.trbVolume.TabIndex = 13;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolume.Value = 800;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(345, 33);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 14;
            this.lblVolume.Text = "Volume:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(341, 57);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Balance:";
            // 
            // trbBalance
            // 
            this.trbBalance.AutoSize = false;
            this.trbBalance.Location = new System.Drawing.Point(396, 50);
            this.trbBalance.Maximum = 1000;
            this.trbBalance.Name = "trbBalance";
            this.trbBalance.Size = new System.Drawing.Size(104, 30);
            this.trbBalance.TabIndex = 15;
            this.trbBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBalance.Value = 500;
            this.trbBalance.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(507, 27);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(50, 17);
            this.chkMute.TabIndex = 16;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // btnTrackNumber
            // 
            this.btnTrackNumber.Name = "btnTrackNumber";
            this.btnTrackNumber.Size = new System.Drawing.Size(152, 22);
            this.btnTrackNumber.Text = "Track number";
            this.btnTrackNumber.Click += new System.EventHandler(this.btnTrackNumber_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 395);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.trbBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trbVolume);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.mnsMenu);
            this.Controls.Add(this.btnPrevious);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCIplayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPlaying;
        private System.Windows.Forms.ToolStripMenuItem btnPlayBack;
        private System.Windows.Forms.ToolStripMenuItem btnShuffle;
        private System.Windows.Forms.ToolStripMenuItem btnLoop;
        private System.Windows.Forms.ListView lstPlaylist;
        private System.Windows.Forms.ColumnHeader clmFileName;
        private System.Windows.Forms.ColumnHeader clmArtist;
        private System.Windows.Forms.ColumnHeader clmAlbum;
        private System.Windows.Forms.ColumnHeader clmTitle;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnShowColumns;
        private System.Windows.Forms.ToolStripMenuItem btnFileName;
        private System.Windows.Forms.ToolStripMenuItem btnPath;
        private System.Windows.Forms.ToolStripMenuItem btnArtist;
        private System.Windows.Forms.ToolStripMenuItem btnTitle;
        private System.Windows.Forms.ToolStripMenuItem btnAlbum;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ToolStripMenuItem btnType;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TrackBar trbBalance;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.ToolStripMenuItem btnTrackNumber;
    }
}

