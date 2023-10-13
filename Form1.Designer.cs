namespace cljproj
{
    partial class autoplaynext
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoplaynext));
            this.musiclistbox = new System.Windows.Forms.CheckedListBox();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.playpausebtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.durationlabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.playtimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fulldurationlabel = new System.Windows.Forms.Label();
            this.progpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playbuttondisplay = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.volumee = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.vollbl = new System.Windows.Forms.Label();
            this.mute_unmute = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.unmute = new System.Windows.Forms.Button();
            this.replayon = new System.Windows.Forms.Button();
            this.replayoff = new System.Windows.Forms.Button();
            this.replayonoff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.musicpic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Author = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel.SuspendLayout();
            this.progpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // musiclistbox
            // 
            this.musiclistbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.musiclistbox.FormattingEnabled = true;
            this.musiclistbox.Location = new System.Drawing.Point(12, 71);
            this.musiclistbox.Name = "musiclistbox";
            this.musiclistbox.ScrollAlwaysVisible = true;
            this.musiclistbox.Size = new System.Drawing.Size(192, 319);
            this.musiclistbox.TabIndex = 0;
            this.musiclistbox.SelectedIndexChanged += new System.EventHandler(this.musiclistbox_SelectedIndexChanged);
            // 
            // Browsebtn
            // 
            this.Browsebtn.AutoSize = true;
            this.Browsebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Browsebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browsebtn.BackgroundImage")));
            this.Browsebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Browsebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Browsebtn.Location = new System.Drawing.Point(12, 389);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(88, 32);
            this.Browsebtn.TabIndex = 1;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browsebtn.UseCompatibleTextRendering = true;
            this.Browsebtn.UseVisualStyleBackColor = false;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear.BackgroundImage")));
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clear.Location = new System.Drawing.Point(106, 389);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 32);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.previousbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousbtn.BackgroundImage")));
            this.previousbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousbtn.Location = new System.Drawing.Point(209, 389);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(75, 32);
            this.previousbtn.TabIndex = 3;
            this.previousbtn.UseVisualStyleBackColor = false;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // playpausebtn
            // 
            this.playpausebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.playpausebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playpausebtn.BackgroundImage")));
            this.playpausebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playpausebtn.Location = new System.Drawing.Point(285, 389);
            this.playpausebtn.Name = "playpausebtn";
            this.playpausebtn.Size = new System.Drawing.Size(75, 32);
            this.playpausebtn.TabIndex = 4;
            this.playpausebtn.UseVisualStyleBackColor = false;
            this.playpausebtn.Click += new System.EventHandler(this.playpausebtn_Click);
            this.playpausebtn.MouseHover += new System.EventHandler(this.playpausebtn_MouseHover);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.nextbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextbtn.BackgroundImage")));
            this.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextbtn.Location = new System.Drawing.Point(361, 389);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(75, 32);
            this.nextbtn.TabIndex = 5;
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationlabel.Location = new System.Drawing.Point(3, 3);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(43, 15);
            this.durationlabel.TabIndex = 7;
            this.durationlabel.Text = "00:00";
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(12, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(192, 21);
            this.panel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Musiclist";
            // 
            // play
            // 
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play.Location = new System.Drawing.Point(516, 13);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 32);
            this.play.TabIndex = 10;
            this.play.UseVisualStyleBackColor = true;
            this.play.Visible = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause.BackgroundImage")));
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pause.Location = new System.Drawing.Point(516, 51);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 32);
            this.pause.TabIndex = 11;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // playtimer
            // 
            this.playtimer.Tick += new System.EventHandler(this.playtimer_Tick);
            // 
            // fulldurationlabel
            // 
            this.fulldurationlabel.AutoSize = true;
            this.fulldurationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulldurationlabel.Location = new System.Drawing.Point(258, 3);
            this.fulldurationlabel.Name = "fulldurationlabel";
            this.fulldurationlabel.Size = new System.Drawing.Size(43, 15);
            this.fulldurationlabel.TabIndex = 12;
            this.fulldurationlabel.Text = "00:00";
            this.fulldurationlabel.Click += new System.EventHandler(this.fulldurationlabel_Click);
            // 
            // progpanel
            // 
            this.progpanel.BackColor = System.Drawing.Color.DarkGray;
            this.progpanel.Controls.Add(this.progressBar1);
            this.progpanel.Controls.Add(this.durationlabel);
            this.progpanel.Controls.Add(this.fulldurationlabel);
            this.progpanel.Location = new System.Drawing.Point(204, 360);
            this.progpanel.Name = "progpanel";
            this.progpanel.Size = new System.Drawing.Size(298, 23);
            this.progpanel.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.playbuttondisplay);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(12, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 26);
            this.panel2.TabIndex = 15;
            // 
            // playbuttondisplay
            // 
            this.playbuttondisplay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.playbuttondisplay.Location = new System.Drawing.Point(189, 3);
            this.playbuttondisplay.Name = "playbuttondisplay";
            this.playbuttondisplay.Size = new System.Drawing.Size(301, 30);
            this.playbuttondisplay.TabIndex = 16;
            this.playbuttondisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playbuttondisplay.UseVisualStyleBackColor = false;
            this.playbuttondisplay.Click += new System.EventHandler(this.playbuttondisplay_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // volumee
            // 
            this.volumee.Location = new System.Drawing.Point(528, 394);
            this.volumee.Maximum = 100;
            this.volumee.Name = "volumee";
            this.volumee.Size = new System.Drawing.Size(104, 45);
            this.volumee.TabIndex = 17;
            this.volumee.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(538, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Volume";
            // 
            // vollbl
            // 
            this.vollbl.AutoSize = true;
            this.vollbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vollbl.ForeColor = System.Drawing.Color.MintCream;
            this.vollbl.Location = new System.Drawing.Point(594, 423);
            this.vollbl.Name = "vollbl";
            this.vollbl.Size = new System.Drawing.Size(31, 16);
            this.vollbl.TabIndex = 19;
            this.vollbl.Text = "100";
            // 
            // mute_unmute
            // 
            this.mute_unmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mute_unmute.Location = new System.Drawing.Point(438, 395);
            this.mute_unmute.Name = "mute_unmute";
            this.mute_unmute.Size = new System.Drawing.Size(29, 23);
            this.mute_unmute.TabIndex = 21;
            this.mute_unmute.UseVisualStyleBackColor = true;
            this.mute_unmute.Click += new System.EventHandler(this.mute_unmute_Click);
            // 
            // mute
            // 
            this.mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mute.BackgroundImage")));
            this.mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mute.Location = new System.Drawing.Point(586, 13);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(48, 23);
            this.mute.TabIndex = 22;
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Visible = false;
            // 
            // unmute
            // 
            this.unmute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unmute.BackgroundImage")));
            this.unmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.unmute.Location = new System.Drawing.Point(586, 32);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(48, 23);
            this.unmute.TabIndex = 23;
            this.unmute.UseVisualStyleBackColor = true;
            this.unmute.Visible = false;
            // 
            // replayon
            // 
            this.replayon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replayon.BackgroundImage")));
            this.replayon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replayon.Location = new System.Drawing.Point(597, 51);
            this.replayon.Name = "replayon";
            this.replayon.Size = new System.Drawing.Size(48, 23);
            this.replayon.TabIndex = 24;
            this.replayon.UseVisualStyleBackColor = true;
            this.replayon.Visible = false;
            // 
            // replayoff
            // 
            this.replayoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replayoff.BackgroundImage")));
            this.replayoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replayoff.Location = new System.Drawing.Point(597, 71);
            this.replayoff.Name = "replayoff";
            this.replayoff.Size = new System.Drawing.Size(48, 23);
            this.replayoff.TabIndex = 25;
            this.replayoff.UseVisualStyleBackColor = true;
            this.replayoff.Visible = false;
            // 
            // replayonoff
            // 
            this.replayonoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replayonoff.Location = new System.Drawing.Point(469, 395);
            this.replayonoff.Name = "replayonoff";
            this.replayonoff.Size = new System.Drawing.Size(29, 23);
            this.replayonoff.TabIndex = 26;
            this.replayonoff.UseVisualStyleBackColor = true;
            this.replayonoff.Click += new System.EventHandler(this.replayonoff_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(501, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicpic
            // 
            this.musicpic.BackColor = System.Drawing.Color.Peru;
            this.musicpic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicpic.BackgroundImage")));
            this.musicpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musicpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musicpic.Location = new System.Drawing.Point(204, 172);
            this.musicpic.Name = "musicpic";
            this.musicpic.Size = new System.Drawing.Size(298, 188);
            this.musicpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.musicpic.TabIndex = 30;
            this.musicpic.TabStop = false;
            this.musicpic.Click += new System.EventHandler(this.musicpic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(210, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 32);
            this.panel1.TabIndex = 13;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.AliceBlue;
            this.Author.Location = new System.Drawing.Point(15, 9);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(35, 13);
            this.Author.TabIndex = 32;
            this.Author.Text = "label3";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.AliceBlue;
            this.year.Location = new System.Drawing.Point(277, 7);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(35, 13);
            this.year.TabIndex = 33;
            this.year.Text = "label3";
            this.year.Click += new System.EventHandler(this.year_Click);
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(204, 51);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(298, 197);
            this.axWindowsMediaPlayer3.TabIndex = 20;
            this.axWindowsMediaPlayer3.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer3_PlayStateChange);
            this.axWindowsMediaPlayer3.Enter += new System.EventHandler(this.axWindowsMediaPlayer3_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // autoplaynext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.playpausebtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.musicpic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replayonoff);
            this.Controls.Add(this.replayoff);
            this.Controls.Add(this.replayon);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.mute_unmute);
            this.Controls.Add(this.vollbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progpanel);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.musiclistbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autoplaynext";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.progpanel.ResumeLayout(false);
            this.progpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox musiclistbox;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button playpausebtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label durationlabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Timer playtimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label fulldurationlabel;
        private System.Windows.Forms.Panel progpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button playbuttondisplay;
        //private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TrackBar volumee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vollbl;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Button mute_unmute;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Button unmute;
        private System.Windows.Forms.Button replayon;
        private System.Windows.Forms.Button replayoff;
        private System.Windows.Forms.Button replayonoff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox musicpic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

