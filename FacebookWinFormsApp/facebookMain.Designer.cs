namespace BasicFacebookFeatures
{
    partial class facebookMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facebookMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.basicFeaturesPanel = new System.Windows.Forms.Panel();
            this.AlbumsPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PostsListBox = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.feature1 = new System.Windows.Forms.TabPage();
            this.GameFeaturePanel = new System.Windows.Forms.Panel();
            this.resultGameLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.resultGuessTheAnswerLabel = new System.Windows.Forms.Label();
            this.checkAnswerGameButton = new System.Windows.Forms.Button();
            this.ChooseYearComboBox = new System.Windows.Forms.ComboBox();
            this.guessPostLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.feature2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.feature2panel = new System.Windows.Forms.Panel();
            this.PastAlbumsPictureBox = new System.Windows.Forms.PictureBox();
            this.pastAlbumsLabel = new System.Windows.Forms.Label();
            this.pastAlbumsListBox = new System.Windows.Forms.ListBox();
            this.PastPostsLabel = new System.Windows.Forms.Label();
            this.pastPostsListBox = new System.Windows.Forms.ListBox();
            this.pastViewComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.basicFeaturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.feature1.SuspendLayout();
            this.GameFeaturePanel.SuspendLayout();
            this.feature2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.feature2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastAlbumsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.Location = new System.Drawing.Point(152, 12);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(310, 46);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.UseWaitCursor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(214, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(279, 46);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.UseWaitCursor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.feature1);
            this.tabControl1.Controls.Add(this.feature2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 749);
            this.tabControl1.TabIndex = 54;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.basicFeaturesPanel);
            this.tab1.Controls.Add(this.splitContainer1);
            this.tab1.Location = new System.Drawing.Point(4, 27);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1243, 718);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Basic Features";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.UseWaitCursor = true;
            // 
            // basicFeaturesPanel
            // 
            this.basicFeaturesPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.basicFeaturesPanel.Controls.Add(this.AlbumsPictureBox);
            this.basicFeaturesPanel.Controls.Add(this.label5);
            this.basicFeaturesPanel.Controls.Add(this.FriendsListBox);
            this.basicFeaturesPanel.Controls.Add(this.label4);
            this.basicFeaturesPanel.Controls.Add(this.label3);
            this.basicFeaturesPanel.Controls.Add(this.AlbumsListBox);
            this.basicFeaturesPanel.Controls.Add(this.label2);
            this.basicFeaturesPanel.Controls.Add(this.LikedPagesListBox);
            this.basicFeaturesPanel.Controls.Add(this.label1);
            this.basicFeaturesPanel.Controls.Add(this.PostsListBox);
            this.basicFeaturesPanel.Controls.Add(this.pictureBoxProfile);
            this.basicFeaturesPanel.Location = new System.Drawing.Point(9, 75);
            this.basicFeaturesPanel.Name = "basicFeaturesPanel";
            this.basicFeaturesPanel.Size = new System.Drawing.Size(1239, 631);
            this.basicFeaturesPanel.TabIndex = 57;
            this.basicFeaturesPanel.UseWaitCursor = true;
            // 
            // AlbumsPictureBox
            // 
            this.AlbumsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumsPictureBox.Location = new System.Drawing.Point(848, 402);
            this.AlbumsPictureBox.Name = "AlbumsPictureBox";
            this.AlbumsPictureBox.Size = new System.Drawing.Size(357, 212);
            this.AlbumsPictureBox.TabIndex = 65;
            this.AlbumsPictureBox.TabStop = false;
            this.AlbumsPictureBox.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Profile Picture";
            this.label5.UseWaitCursor = true;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 18;
            this.FriendsListBox.Location = new System.Drawing.Point(448, 402);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(365, 202);
            this.FriendsListBox.TabIndex = 63;
            this.FriendsListBox.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Friends";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Albums";
            this.label3.UseWaitCursor = true;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 18;
            this.AlbumsListBox.Location = new System.Drawing.Point(848, 78);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(357, 238);
            this.AlbumsListBox.TabIndex = 60;
            this.AlbumsListBox.UseWaitCursor = true;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Liked Pages";
            this.label2.UseWaitCursor = true;
            // 
            // LikedPagesListBox
            // 
            this.LikedPagesListBox.FormattingEnabled = true;
            this.LikedPagesListBox.ItemHeight = 18;
            this.LikedPagesListBox.Location = new System.Drawing.Point(51, 402);
            this.LikedPagesListBox.Name = "LikedPagesListBox";
            this.LikedPagesListBox.Size = new System.Drawing.Size(354, 202);
            this.LikedPagesListBox.TabIndex = 58;
            this.LikedPagesListBox.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Posts";
            this.label1.UseWaitCursor = true;
            // 
            // PostsListBox
            // 
            this.PostsListBox.FormattingEnabled = true;
            this.PostsListBox.ItemHeight = 18;
            this.PostsListBox.Location = new System.Drawing.Point(51, 78);
            this.PostsListBox.Name = "PostsListBox";
            this.PostsListBox.Size = new System.Drawing.Size(354, 238);
            this.PostsListBox.TabIndex = 56;
            this.PostsListBox.UseWaitCursor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProfile.Location = new System.Drawing.Point(448, 79);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(368, 237);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseWaitCursor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.buttonLogin);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.buttonLogout);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(1239, 69);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 56;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // feature1
            // 
            this.feature1.Controls.Add(this.GameFeaturePanel);
            this.feature1.Location = new System.Drawing.Point(4, 27);
            this.feature1.Name = "feature1";
            this.feature1.Padding = new System.Windows.Forms.Padding(3);
            this.feature1.Size = new System.Drawing.Size(1243, 718);
            this.feature1.TabIndex = 1;
            this.feature1.Text = "Game Feature";
            this.feature1.UseVisualStyleBackColor = true;
            // 
            // GameFeaturePanel
            // 
            this.GameFeaturePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.GameFeaturePanel.Controls.Add(this.resultGameLabel);
            this.GameFeaturePanel.Controls.Add(this.startGameButton);
            this.GameFeaturePanel.Controls.Add(this.resultGuessTheAnswerLabel);
            this.GameFeaturePanel.Controls.Add(this.checkAnswerGameButton);
            this.GameFeaturePanel.Controls.Add(this.ChooseYearComboBox);
            this.GameFeaturePanel.Controls.Add(this.guessPostLabel);
            this.GameFeaturePanel.Controls.Add(this.label6);
            this.GameFeaturePanel.Location = new System.Drawing.Point(8, 8);
            this.GameFeaturePanel.Name = "GameFeaturePanel";
            this.GameFeaturePanel.Size = new System.Drawing.Size(1240, 707);
            this.GameFeaturePanel.TabIndex = 0;
            // 
            // resultGameLabel
            // 
            this.resultGameLabel.AutoSize = true;
            this.resultGameLabel.Location = new System.Drawing.Point(894, 297);
            this.resultGameLabel.Name = "resultGameLabel";
            this.resultGameLabel.Size = new System.Drawing.Size(0, 18);
            this.resultGameLabel.TabIndex = 6;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Gainsboro;
            this.startGameButton.Location = new System.Drawing.Point(548, 407);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(109, 57);
            this.startGameButton.TabIndex = 5;
            this.startGameButton.Text = "Start";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // resultGuessTheAnswerLabel
            // 
            this.resultGuessTheAnswerLabel.AllowDrop = true;
            this.resultGuessTheAnswerLabel.AutoSize = true;
            this.resultGuessTheAnswerLabel.Location = new System.Drawing.Point(714, 407);
            this.resultGuessTheAnswerLabel.Name = "resultGuessTheAnswerLabel";
            this.resultGuessTheAnswerLabel.Size = new System.Drawing.Size(0, 18);
            this.resultGuessTheAnswerLabel.TabIndex = 4;
            // 
            // checkAnswerGameButton
            // 
            this.checkAnswerGameButton.BackColor = System.Drawing.Color.Gainsboro;
            this.checkAnswerGameButton.Location = new System.Drawing.Point(673, 285);
            this.checkAnswerGameButton.Name = "checkAnswerGameButton";
            this.checkAnswerGameButton.Size = new System.Drawing.Size(167, 38);
            this.checkAnswerGameButton.TabIndex = 3;
            this.checkAnswerGameButton.Text = "Check answer";
            this.checkAnswerGameButton.UseVisualStyleBackColor = false;
            this.checkAnswerGameButton.Click += new System.EventHandler(this.CheckAnswerGuessPostYear_Click);
            // 
            // ChooseYearComboBox
            // 
            this.ChooseYearComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChooseYearComboBox.FormattingEnabled = true;
            this.ChooseYearComboBox.Location = new System.Drawing.Point(371, 285);
            this.ChooseYearComboBox.Name = "ChooseYearComboBox";
            this.ChooseYearComboBox.Size = new System.Drawing.Size(182, 26);
            this.ChooseYearComboBox.TabIndex = 2;
            this.ChooseYearComboBox.Text = "Choose Year";
            this.ChooseYearComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guessPostLabel
            // 
            this.guessPostLabel.AutoSize = true;
            this.guessPostLabel.Location = new System.Drawing.Point(423, 175);
            this.guessPostLabel.Name = "guessPostLabel";
            this.guessPostLabel.Size = new System.Drawing.Size(0, 18);
            this.guessPostLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Guess the year the post was uploaded:";
            // 
            // feature2
            // 
            this.feature2.Controls.Add(this.panel3);
            this.feature2.Location = new System.Drawing.Point(4, 27);
            this.feature2.Name = "feature2";
            this.feature2.Padding = new System.Windows.Forms.Padding(3);
            this.feature2.Size = new System.Drawing.Size(1243, 718);
            this.feature2.TabIndex = 2;
            this.feature2.Text = "A View To The Past";
            this.feature2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.feature2panel);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 704);
            this.panel3.TabIndex = 0;
            // 
            // feature2panel
            // 
            this.feature2panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.feature2panel.Controls.Add(this.errorMessage);
            this.feature2panel.Controls.Add(this.PastAlbumsPictureBox);
            this.feature2panel.Controls.Add(this.pastAlbumsLabel);
            this.feature2panel.Controls.Add(this.pastAlbumsListBox);
            this.feature2panel.Controls.Add(this.PastPostsLabel);
            this.feature2panel.Controls.Add(this.pastPostsListBox);
            this.feature2panel.Controls.Add(this.pastViewComboBox);
            this.feature2panel.Controls.Add(this.label7);
            this.feature2panel.Location = new System.Drawing.Point(0, 0);
            this.feature2panel.Name = "feature2panel";
            this.feature2panel.Size = new System.Drawing.Size(1239, 704);
            this.feature2panel.TabIndex = 0;
            // 
            // PastAlbumsPictureBox
            // 
            this.PastAlbumsPictureBox.Location = new System.Drawing.Point(691, 453);
            this.PastAlbumsPictureBox.Name = "PastAlbumsPictureBox";
            this.PastAlbumsPictureBox.Size = new System.Drawing.Size(374, 219);
            this.PastAlbumsPictureBox.TabIndex = 4;
            this.PastAlbumsPictureBox.TabStop = false;
            // 
            // pastAlbumsLabel
            // 
            this.pastAlbumsLabel.AutoSize = true;
            this.pastAlbumsLabel.Location = new System.Drawing.Point(868, 131);
            this.pastAlbumsLabel.Name = "pastAlbumsLabel";
            this.pastAlbumsLabel.Size = new System.Drawing.Size(57, 18);
            this.pastAlbumsLabel.TabIndex = 3;
            this.pastAlbumsLabel.Text = "Albums";
            // 
            // pastAlbumsListBox
            // 
            this.pastAlbumsListBox.FormattingEnabled = true;
            this.pastAlbumsListBox.ItemHeight = 18;
            this.pastAlbumsListBox.Location = new System.Drawing.Point(691, 171);
            this.pastAlbumsListBox.Name = "pastAlbumsListBox";
            this.pastAlbumsListBox.Size = new System.Drawing.Size(374, 256);
            this.pastAlbumsListBox.TabIndex = 1;
            this.pastAlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.pastAlbumsListBox_SelectedIndexChanged);
            // 
            // PastPostsLabel
            // 
            this.PastPostsLabel.AutoSize = true;
            this.PastPostsLabel.Location = new System.Drawing.Point(340, 131);
            this.PastPostsLabel.Name = "PastPostsLabel";
            this.PastPostsLabel.Size = new System.Drawing.Size(47, 18);
            this.PastPostsLabel.TabIndex = 2;
            this.PastPostsLabel.Text = "Posts";
            // 
            // pastPostsListBox
            // 
            this.pastPostsListBox.FormattingEnabled = true;
            this.pastPostsListBox.ItemHeight = 18;
            this.pastPostsListBox.Location = new System.Drawing.Point(167, 171);
            this.pastPostsListBox.Name = "pastPostsListBox";
            this.pastPostsListBox.Size = new System.Drawing.Size(366, 256);
            this.pastPostsListBox.TabIndex = 1;
            // 
            // pastViewComboBox
            // 
            this.pastViewComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pastViewComboBox.FormattingEnabled = true;
            this.pastViewComboBox.Location = new System.Drawing.Point(649, 49);
            this.pastViewComboBox.Name = "pastViewComboBox";
            this.pastViewComboBox.Size = new System.Drawing.Size(164, 26);
            this.pastViewComboBox.TabIndex = 1;
            this.pastViewComboBox.Text = "Choose Year";
            this.pastViewComboBox.SelectedIndexChanged += new System.EventHandler(this.pastViewComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select a year you want to go back to:";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(871, 61);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 18);
            this.errorMessage.TabIndex = 5;
            // 
            // facebookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "facebookMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facebook Interaction App";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.basicFeaturesPanel.ResumeLayout(false);
            this.basicFeaturesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.feature1.ResumeLayout(false);
            this.GameFeaturePanel.ResumeLayout(false);
            this.GameFeaturePanel.PerformLayout();
            this.feature2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.feature2panel.ResumeLayout(false);
            this.feature2panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastAlbumsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab1;
		private System.Windows.Forms.TabPage feature1;
        private System.Windows.Forms.TabPage feature2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel basicFeaturesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PostsListBox;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LikedPagesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox AlbumsPictureBox;
        private System.Windows.Forms.Panel GameFeaturePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ChooseYearComboBox;
        private System.Windows.Forms.Label guessPostLabel;
        private System.Windows.Forms.Button checkAnswerGameButton;
        private System.Windows.Forms.Label resultGuessTheAnswerLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label resultGameLabel;
        private System.Windows.Forms.Panel feature2panel;
        private System.Windows.Forms.ListBox pastPostsListBox;
        private System.Windows.Forms.ComboBox pastViewComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PastPostsLabel;
        private System.Windows.Forms.PictureBox PastAlbumsPictureBox;
        private System.Windows.Forms.Label pastAlbumsLabel;
        private System.Windows.Forms.ListBox pastAlbumsListBox;
        private System.Windows.Forms.Label errorMessage;
    }
}

