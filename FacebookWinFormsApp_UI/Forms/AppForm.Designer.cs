namespace BasicFacebookFeatures.Forms
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFootball = new System.Windows.Forms.Button();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.buttonChooseAlbum = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 18);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 29;
            this.listBoxPosts.Location = new System.Drawing.Point(348, 114);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(493, 178);
            this.listBoxPosts.TabIndex = 56;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(39, 100);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(219, 192);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 63;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(93, 68);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(109, 22);
            this.labelUserName.TabIndex = 64;
            this.labelUserName.Text = "User Name";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(39, 368);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(286, 264);
            this.listBoxAlbums.TabIndex = 65;
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFavoriteTeams.DisplayMember = "name";
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 20;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(398, 368);
            this.listBoxFavoriteTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(380, 264);
            this.listBoxFavoriteTeams.TabIndex = 66;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(822, 368);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(382, 264);
            this.listBoxGroups.TabIndex = 67;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1128, 15);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 42);
            this.buttonRefresh.TabIndex = 69;
            this.buttonRefresh.Text = "Click to fetch";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonClickToFetch_Click);
            // 
            // buttonFootball
            // 
            this.buttonFootball.Location = new System.Drawing.Point(490, 643);
            this.buttonFootball.Name = "buttonFootball";
            this.buttonFootball.Size = new System.Drawing.Size(177, 43);
            this.buttonFootball.TabIndex = 70;
            this.buttonFootball.Text = "Explore Teams";
            this.buttonFootball.UseVisualStyleBackColor = true;
            this.buttonFootball.Click += new System.EventHandler(this.buttonFootball_Click);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbums.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAlbums.Location = new System.Drawing.Point(106, 315);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(137, 46);
            this.labelAlbums.TabIndex = 71;
            this.labelAlbums.Text = "ALBUMS";
            this.labelAlbums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.BackColor = System.Drawing.Color.Transparent;
            this.labelTeams.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeams.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTeams.Location = new System.Drawing.Point(519, 315);
            this.labelTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(117, 46);
            this.labelTeams.TabIndex = 72;
            this.labelTeams.Text = "TEAMS";
            this.labelTeams.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.BackColor = System.Drawing.Color.Transparent;
            this.labelGroups.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroups.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelGroups.Location = new System.Drawing.Point(946, 315);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(135, 46);
            this.labelGroups.TabIndex = 73;
            this.labelGroups.Text = "GROUPS";
            this.labelGroups.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonChooseAlbum
            // 
            this.buttonChooseAlbum.Location = new System.Drawing.Point(116, 643);
            this.buttonChooseAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChooseAlbum.Name = "buttonChooseAlbum";
            this.buttonChooseAlbum.Size = new System.Drawing.Size(142, 35);
            this.buttonChooseAlbum.TabIndex = 74;
            this.buttonChooseAlbum.Text = "Choose album";
            this.buttonChooseAlbum.UseVisualStyleBackColor = true;
            this.buttonChooseAlbum.Click += new System.EventHandler(this.buttonChooseAlbum_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.BackColor = System.Drawing.Color.Transparent;
            this.labelPosts.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPosts.Location = new System.Drawing.Point(519, 62);
            this.labelPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(87, 46);
            this.labelPosts.TabIndex = 75;
            this.labelPosts.Text = "Posts";
            this.labelPosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1263, 749);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.buttonChooseAlbum);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelTeams);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.buttonFootball);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFootball;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Button buttonChooseAlbum;
        private System.Windows.Forms.Label labelPosts;
    }
}

