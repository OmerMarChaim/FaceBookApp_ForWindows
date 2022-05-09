
namespace BasicFacebookFeatures.Forms
{
    partial class AlbumPhotosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumPhotosForm));
            this.labelYourPhotosFrom = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.buttonFindTheBestLiker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelYourPhotosFrom
            // 
            this.labelYourPhotosFrom.AutoSize = true;
            this.labelYourPhotosFrom.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourPhotosFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYourPhotosFrom.Location = new System.Drawing.Point(21, 23);
            this.labelYourPhotosFrom.Name = "labelYourPhotosFrom";
            this.labelYourPhotosFrom.Size = new System.Drawing.Size(218, 24);
            this.labelYourPhotosFrom.TabIndex = 0;
            this.labelYourPhotosFrom.Text = "Your Photos from";
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.Location = new System.Drawing.Point(243, 20);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(81, 29);
            this.labelAlbumName.TabIndex = 1;
            this.labelAlbumName.Text = "Album";
            // 
            // buttonFindTheBestLiker
            // 
            this.buttonFindTheBestLiker.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFindTheBestLiker.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindTheBestLiker.Location = new System.Drawing.Point(555, 12);
            this.buttonFindTheBestLiker.Name = "buttonFindTheBestLiker";
            this.buttonFindTheBestLiker.Size = new System.Drawing.Size(201, 45);
            this.buttonFindTheBestLiker.TabIndex = 2;
            this.buttonFindTheBestLiker.Text = "Click here to find out who gave you the most likes in this album";
            this.buttonFindTheBestLiker.UseVisualStyleBackColor = false;
            this.buttonFindTheBestLiker.Click += new System.EventHandler(this.buttonFindTheBestLiker_Click);
            // 
            // AlbumPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.buttonFindTheBestLiker);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.labelYourPhotosFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumPhotosForm";
            this.Text = "Album Photos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourPhotosFrom;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Button buttonFindTheBestLiker;
    }
}