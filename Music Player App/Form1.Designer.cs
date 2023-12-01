
namespace Music_Player_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCross = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSong = new System.Windows.Forms.ListBox();
            this.btnSltSong = new System.Windows.Forms.Button();
            this.wmpMusic1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.kittyBox = new System.Windows.Forms.PictureBox();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.picCross);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 48);
            this.panel1.TabIndex = 0;
            // 
            // picCross
            // 
            this.picCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCross.Image = global::Music_Player_App.Properties.Resources.icons8_cross_50;
            this.picCross.Location = new System.Drawing.Point(791, 5);
            this.picCross.Name = "picCross";
            this.picCross.Size = new System.Drawing.Size(39, 36);
            this.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCross.TabIndex = 1;
            this.picCross.TabStop = false;
            this.picCross.Click += new System.EventHandler(this.picCross_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(5, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(50, 28);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "MPB!";
            // 
            // listBoxSong
            // 
            this.listBoxSong.FormattingEnabled = true;
            this.listBoxSong.Location = new System.Drawing.Point(12, 54);
            this.listBoxSong.Name = "listBoxSong";
            this.listBoxSong.Size = new System.Drawing.Size(298, 459);
            this.listBoxSong.TabIndex = 2;
            this.listBoxSong.SelectedIndexChanged += new System.EventHandler(this.listBoxSong_SelectedIndexChanged);
            // 
            // btnSltSong
            // 
            this.btnSltSong.BackColor = System.Drawing.Color.Purple;
            this.btnSltSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSltSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSltSong.ForeColor = System.Drawing.Color.White;
            this.btnSltSong.Location = new System.Drawing.Point(316, 490);
            this.btnSltSong.Name = "btnSltSong";
            this.btnSltSong.Size = new System.Drawing.Size(75, 23);
            this.btnSltSong.TabIndex = 3;
            this.btnSltSong.Text = "Select....";
            this.btnSltSong.UseVisualStyleBackColor = false;
            this.btnSltSong.Click += new System.EventHandler(this.btnSltSong_Click);
            // 
            // wmpMusic1
            // 
            this.wmpMusic1.Enabled = true;
            this.wmpMusic1.Location = new System.Drawing.Point(397, 54);
            this.wmpMusic1.Name = "wmpMusic1";
            this.wmpMusic1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusic1.OcxState")));
            this.wmpMusic1.Size = new System.Drawing.Size(433, 459);
            this.wmpMusic1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(739, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "thanks for using :)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(316, 461);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "CLEAR!";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // kittyBox
            // 
            this.kittyBox.Image = global::Music_Player_App.Properties.Resources.dancing_cat;
            this.kittyBox.Location = new System.Drawing.Point(316, 80);
            this.kittyBox.Name = "kittyBox";
            this.kittyBox.Size = new System.Drawing.Size(75, 58);
            this.kittyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kittyBox.TabIndex = 7;
            this.kittyBox.TabStop = false;
            this.kittyBox.Click += new System.EventHandler(this.kittyBox_Click);
            // 
            // logo1
            // 
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo1.Image = global::Music_Player_App.Properties.Resources.Music_Player_Basic_Logo;
            this.logo1.Location = new System.Drawing.Point(316, 54);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(20, 20);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1.TabIndex = 2;
            this.logo1.TabStop = false;
            this.logo1.Click += new System.EventHandler(this.logo1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 542);
            this.Controls.Add(this.kittyBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.wmpMusic1);
            this.Controls.Add(this.btnSltSong);
            this.Controls.Add(this.listBoxSong);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kittyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picCross;
        private System.Windows.Forms.ListBox listBoxSong;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Button btnSltSong;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox kittyBox;
    }
}

