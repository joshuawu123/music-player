namespace music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scroll = new System.Windows.Forms.TrackBar();
            this.volume = new System.Windows.Forms.TrackBar();
            this.playPause = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.songs = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shuffleSongs = new System.Windows.Forms.Button();
            this.repeatSongs = new System.Windows.Forms.Button();
            this.openSongs = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scroll
            // 
            this.scroll.BackColor = System.Drawing.SystemColors.Control;
            this.scroll.LargeChange = 250;
            this.scroll.Location = new System.Drawing.Point(125, 411);
            this.scroll.Maximum = 5000;
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(454, 45);
            this.scroll.SmallChange = 50;
            this.scroll.TabIndex = 1;
            this.scroll.TickFrequency = 5000;
            this.scroll.Scroll += new System.EventHandler(this.scroll_Scroll);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(630, 411);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(138, 45);
            this.volume.TabIndex = 8;
            this.volume.TickFrequency = 100;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // playPause
            // 
            this.playPause.Location = new System.Drawing.Point(38, 0);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(31, 22);
            this.playPause.TabIndex = 4;
            this.playPause.Text = "p";
            this.playPause.UseVisualStyleBackColor = true;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 331);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(31, 23);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // songs
            // 
            this.songs.FormattingEnabled = true;
            this.songs.Location = new System.Drawing.Point(630, 59);
            this.songs.Name = "songs";
            this.songs.Size = new System.Drawing.Size(134, 329);
            this.songs.TabIndex = 7;
            this.songs.SelectedIndexChanged += new System.EventHandler(this.songs_SelectedIndexChanged_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shuffleSongs
            // 
            this.shuffleSongs.Location = new System.Drawing.Point(86, 0);
            this.shuffleSongs.Name = "shuffleSongs";
            this.shuffleSongs.Size = new System.Drawing.Size(22, 22);
            this.shuffleSongs.TabIndex = 10;
            this.shuffleSongs.Text = "s";
            this.shuffleSongs.UseVisualStyleBackColor = true;
            this.shuffleSongs.Click += new System.EventHandler(this.shuffleSongs_Click);
            // 
            // repeatSongs
            // 
            this.repeatSongs.Location = new System.Drawing.Point(114, 0);
            this.repeatSongs.Name = "repeatSongs";
            this.repeatSongs.Size = new System.Drawing.Size(22, 22);
            this.repeatSongs.TabIndex = 11;
            this.repeatSongs.Text = "r";
            this.repeatSongs.UseVisualStyleBackColor = true;
            this.repeatSongs.Click += new System.EventHandler(this.repeatSongs_Click);
            // 
            // openSongs
            // 
            this.openSongs.Location = new System.Drawing.Point(626, 12);
            this.openSongs.Name = "openSongs";
            this.openSongs.Size = new System.Drawing.Size(51, 23);
            this.openSongs.TabIndex = 5;
            this.openSongs.Text = "Open";
            this.openSongs.UseVisualStyleBackColor = true;
            this.openSongs.Click += new System.EventHandler(this.openSongs_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(736, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.playPause);
            this.panel1.Controls.Add(this.repeatSongs);
            this.panel1.Controls.Add(this.shuffleSongs);
            this.panel1.Location = new System.Drawing.Point(-26, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 63);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 436);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.openSongs);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.scroll);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar scroll;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Button playPause;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button shuffleSongs;
        private System.Windows.Forms.Button repeatSongs;
        private System.Windows.Forms.Button openSongs;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
    }
}

