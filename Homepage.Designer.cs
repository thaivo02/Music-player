namespace Muzic
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.trackVol = new Guna.UI2.WinForms.Guna2TrackBar();
            this.track = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labPlaying_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labTime_cur = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labTime_end = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.labPlaying_singer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSound = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRandom = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLoop = new Guna.UI2.WinForms.Guna2ImageButton();
            this.picPlaying_song = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panColumn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenre = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPlaylist = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTrend = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExplore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.labLib = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labMenu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaying_song)).BeginInit();
            this.panColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panPlaying
            // 
            this.panPlaying.BackColor = System.Drawing.Color.LavenderBlush;
            this.panPlaying.Controls.Add(this.trackVol);
            this.panPlaying.Controls.Add(this.track);
            this.panPlaying.Controls.Add(this.labPlaying_name);
            this.panPlaying.Controls.Add(this.labTime_cur);
            this.panPlaying.Controls.Add(this.labTime_end);
            this.panPlaying.Controls.Add(this.btnPause);
            this.panPlaying.Controls.Add(this.labPlaying_singer);
            this.panPlaying.Controls.Add(this.btnSound);
            this.panPlaying.Controls.Add(this.btnRandom);
            this.panPlaying.Controls.Add(this.btnNext);
            this.panPlaying.Controls.Add(this.btnBack);
            this.panPlaying.Controls.Add(this.btnLoop);
            this.panPlaying.Controls.Add(this.picPlaying_song);
            this.panPlaying.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panPlaying.Location = new System.Drawing.Point(282, 851);
            this.panPlaying.Name = "panPlaying";
            this.panPlaying.Size = new System.Drawing.Size(1326, 98);
            this.panPlaying.TabIndex = 5;
            // 
            // trackVol
            // 
            this.trackVol.Location = new System.Drawing.Point(1186, 35);
            this.trackVol.Name = "trackVol";
            this.trackVol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackVol.Size = new System.Drawing.Size(105, 29);
            this.trackVol.TabIndex = 9;
            this.trackVol.ThumbColor = System.Drawing.Color.HotPink;
            this.trackVol.Value = 70;
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(653, 35);
            this.track.Name = "track";
            this.track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.track.Size = new System.Drawing.Size(376, 29);
            this.track.TabIndex = 9;
            this.track.ThumbColor = System.Drawing.Color.HotPink;
            this.track.Value = 20;
            // 
            // labPlaying_name
            // 
            this.labPlaying_name.BackColor = System.Drawing.Color.Transparent;
            this.labPlaying_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPlaying_name.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labPlaying_name.IsSelectionEnabled = false;
            this.labPlaying_name.Location = new System.Drawing.Point(114, 25);
            this.labPlaying_name.Name = "labPlaying_name";
            this.labPlaying_name.Size = new System.Drawing.Size(104, 27);
            this.labPlaying_name.TabIndex = 6;
            this.labPlaying_name.Text = "Back to you";
            this.labPlaying_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTime_cur
            // 
            this.labTime_cur.BackColor = System.Drawing.Color.Transparent;
            this.labTime_cur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTime_cur.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labTime_cur.IsSelectionEnabled = false;
            this.labTime_cur.Location = new System.Drawing.Point(604, 38);
            this.labTime_cur.Name = "labTime_cur";
            this.labTime_cur.Size = new System.Drawing.Size(34, 22);
            this.labTime_cur.TabIndex = 6;
            this.labTime_cur.Text = "1:20";
            this.labTime_cur.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTime_end
            // 
            this.labTime_end.BackColor = System.Drawing.Color.Transparent;
            this.labTime_end.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTime_end.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labTime_end.IsSelectionEnabled = false;
            this.labTime_end.Location = new System.Drawing.Point(1044, 38);
            this.labTime_end.Name = "labTime_end";
            this.labTime_end.Size = new System.Drawing.Size(34, 22);
            this.labTime_end.TabIndex = 6;
            this.labTime_end.Text = "3:45";
            this.labTime_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.HotPink;
            this.btnPause.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnPause.CheckedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnPause.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPause.ImageRotate = 0F;
            this.btnPause.ImageSize = new System.Drawing.Size(27, 27);
            this.btnPause.Location = new System.Drawing.Point(422, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnPause.Size = new System.Drawing.Size(45, 45);
            this.btnPause.TabIndex = 8;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // labPlaying_singer
            // 
            this.labPlaying_singer.BackColor = System.Drawing.Color.Transparent;
            this.labPlaying_singer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPlaying_singer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labPlaying_singer.IsSelectionEnabled = false;
            this.labPlaying_singer.Location = new System.Drawing.Point(114, 51);
            this.labPlaying_singer.Name = "labPlaying_singer";
            this.labPlaying_singer.Size = new System.Drawing.Size(118, 22);
            this.labPlaying_singer.TabIndex = 6;
            this.labPlaying_singer.Text = "Lost frequencies";
            this.labPlaying_singer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSound
            // 
            this.btnSound.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSound.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSound.Image = ((System.Drawing.Image)(resources.GetObject("btnSound.Image")));
            this.btnSound.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSound.ImageRotate = 0F;
            this.btnSound.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSound.Location = new System.Drawing.Point(1129, 26);
            this.btnSound.Name = "btnSound";
            this.btnSound.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSound.Size = new System.Drawing.Size(45, 45);
            this.btnSound.TabIndex = 8;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.HotPink;
            this.btnRandom.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRandom.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnRandom.Image")));
            this.btnRandom.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRandom.ImageRotate = 0F;
            this.btnRandom.ImageSize = new System.Drawing.Size(27, 27);
            this.btnRandom.Location = new System.Drawing.Point(532, 26);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnRandom.Size = new System.Drawing.Size(45, 45);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(27, 27);
            this.btnNext.Location = new System.Drawing.Point(481, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(27, 27);
            this.btnBack.Location = new System.Drawing.Point(363, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 8;
            // 
            // btnLoop
            // 
            this.btnLoop.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLoop.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoop.Image = ((System.Drawing.Image)(resources.GetObject("btnLoop.Image")));
            this.btnLoop.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLoop.ImageRotate = 0F;
            this.btnLoop.ImageSize = new System.Drawing.Size(27, 27);
            this.btnLoop.Location = new System.Drawing.Point(302, 27);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnLoop.Size = new System.Drawing.Size(45, 45);
            this.btnLoop.TabIndex = 8;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // picPlaying_song
            // 
            this.picPlaying_song.BackColor = System.Drawing.Color.Transparent;
            this.picPlaying_song.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlaying_song.BorderRadius = 37;
            this.picPlaying_song.Image = ((System.Drawing.Image)(resources.GetObject("picPlaying_song.Image")));
            this.picPlaying_song.ImageRotate = 0F;
            this.picPlaying_song.Location = new System.Drawing.Point(31, 12);
            this.picPlaying_song.Name = "picPlaying_song";
            this.picPlaying_song.Size = new System.Drawing.Size(72, 74);
            this.picPlaying_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlaying_song.TabIndex = 3;
            this.picPlaying_song.TabStop = false;
            // 
            // panColumn
            // 
            this.panColumn.BackColor = System.Drawing.Color.Linen;
            this.panColumn.Controls.Add(this.btnHistory);
            this.panColumn.Controls.Add(this.btnGenre);
            this.panColumn.Controls.Add(this.btnPlaylist);
            this.panColumn.Controls.Add(this.btnFavorite);
            this.panColumn.Controls.Add(this.btnTop);
            this.panColumn.Controls.Add(this.btnTrend);
            this.panColumn.Controls.Add(this.btnExplore);
            this.panColumn.Controls.Add(this.picLogo);
            this.panColumn.Controls.Add(this.labLib);
            this.panColumn.Controls.Add(this.labMenu);
            this.panColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panColumn.Location = new System.Drawing.Point(0, 0);
            this.panColumn.Name = "panColumn";
            this.panColumn.Size = new System.Drawing.Size(282, 949);
            this.panColumn.TabIndex = 4;
            // 
            // btnHistory
            // 
            this.btnHistory.BorderRadius = 10;
            this.btnHistory.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnHistory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnHistory.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHistory.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Location = new System.Drawing.Point(29, 519);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnHistory.Size = new System.Drawing.Size(225, 41);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "History";
            // 
            // btnGenre
            // 
            this.btnGenre.BorderRadius = 10;
            this.btnGenre.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnGenre.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenre.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenre.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenre.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGenre.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnGenre.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenre.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenre.Location = new System.Drawing.Point(29, 302);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnGenre.Size = new System.Drawing.Size(225, 41);
            this.btnGenre.TabIndex = 5;
            this.btnGenre.Text = "Genre";
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnPlaylist.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaylist.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlaylist.FillColor = System.Drawing.SystemColors.Info;
            this.btnPlaylist.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPlaylist.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnPlaylist.HoverState.FillColor2 = System.Drawing.SystemColors.Info;
            this.btnPlaylist.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 900);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnPlaylist.Size = new System.Drawing.Size(282, 49);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "New playlist";
            // 
            // btnFavorite
            // 
            this.btnFavorite.BorderRadius = 10;
            this.btnFavorite.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnFavorite.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFavorite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFavorite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFavorite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFavorite.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFavorite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFavorite.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFavorite.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnFavorite.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnFavorite.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFavorite.Location = new System.Drawing.Point(29, 464);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnFavorite.Size = new System.Drawing.Size(225, 45);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "Favorite";
            // 
            // btnTop
            // 
            this.btnTop.BorderRadius = 10;
            this.btnTop.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnTop.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTop.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTop.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTop.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnTop.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTop.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTop.Location = new System.Drawing.Point(29, 357);
            this.btnTop.Name = "btnTop";
            this.btnTop.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnTop.Size = new System.Drawing.Size(225, 41);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Top 100";
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnTrend
            // 
            this.btnTrend.BorderRadius = 10;
            this.btnTrend.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnTrend.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrend.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTrend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrend.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrend.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTrend.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnTrend.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTrend.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrend.Location = new System.Drawing.Point(29, 247);
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnTrend.Size = new System.Drawing.Size(225, 41);
            this.btnTrend.TabIndex = 1;
            this.btnTrend.Text = "Trending";
            this.btnTrend.Click += new System.EventHandler(this.btnTrend_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.BorderRadius = 10;
            this.btnExplore.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.btnExplore.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExplore.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExplore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExplore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExplore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExplore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExplore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExplore.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExplore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnExplore.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExplore.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExplore.Location = new System.Drawing.Point(29, 192);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnExplore.Size = new System.Drawing.Size(225, 41);
            this.btnExplore.TabIndex = 1;
            this.btnExplore.Text = "Discover";
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(282, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // labLib
            // 
            this.labLib.BackColor = System.Drawing.Color.Transparent;
            this.labLib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLib.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labLib.IsSelectionEnabled = false;
            this.labLib.Location = new System.Drawing.Point(29, 426);
            this.labLib.Name = "labLib";
            this.labLib.Size = new System.Drawing.Size(66, 22);
            this.labLib.TabIndex = 6;
            this.labLib.Text = "LIBRARY";
            this.labLib.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labMenu
            // 
            this.labMenu.BackColor = System.Drawing.Color.Transparent;
            this.labMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labMenu.IsSelectionEnabled = false;
            this.labMenu.Location = new System.Drawing.Point(29, 154);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(48, 22);
            this.labMenu.TabIndex = 6;
            this.labMenu.Text = "MENU";
            this.labMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panMain
            // 
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(282, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1326, 851);
            this.panMain.TabIndex = 6;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1608, 949);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panPlaying);
            this.Controls.Add(this.panColumn);
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panPlaying.ResumeLayout(false);
            this.panPlaying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaying_song)).EndInit();
            this.panColumn.ResumeLayout(false);
            this.panColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panPlaying;
        private Guna.UI2.WinForms.Guna2TrackBar trackVol;
        private Guna.UI2.WinForms.Guna2TrackBar track;
        private Guna.UI2.WinForms.Guna2ImageButton btnPause;
        private Guna.UI2.WinForms.Guna2ImageButton btnSound;
        private Guna.UI2.WinForms.Guna2ImageButton btnRandom;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnLoop;
        private Guna.UI2.WinForms.Guna2PictureBox picPlaying_song;
        private Guna.UI2.WinForms.Guna2Panel panColumn;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenre;
        private Guna.UI2.WinForms.Guna2GradientButton btnPlaylist;
        private Guna.UI2.WinForms.Guna2GradientButton btnFavorite;
        private Guna.UI2.WinForms.Guna2GradientButton btnTop;
        private Guna.UI2.WinForms.Guna2GradientButton btnTrend;
        private Guna.UI2.WinForms.Guna2GradientButton btnExplore;
        private PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPlaying_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPlaying_singer;
        private Guna.UI2.WinForms.Guna2HtmlLabel labLib;
        private Guna.UI2.WinForms.Guna2HtmlLabel labMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTime_cur;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTime_end;
        private Guna.UI2.WinForms.Guna2Panel panMain;
    }
}