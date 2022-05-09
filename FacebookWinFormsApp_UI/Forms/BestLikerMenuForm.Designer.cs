
namespace BasicFacebookFeatures.Forms
{
    partial class BestLikerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestLikerMenuForm));
            this.labelYourBestLikerIs = new System.Windows.Forms.Label();
            this.MenuItemsListBox = new System.Windows.Forms.ListBox();
            this.MenuItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelYourBestLikerIs
            // 
            this.labelYourBestLikerIs.AutoSize = true;
            this.labelYourBestLikerIs.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourBestLikerIs.Location = new System.Drawing.Point(67, 20);
            this.labelYourBestLikerIs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourBestLikerIs.Name = "labelYourBestLikerIs";
            this.labelYourBestLikerIs.Size = new System.Drawing.Size(499, 46);
            this.labelYourBestLikerIs.TabIndex = 1;
            this.labelYourBestLikerIs.Text = "Choose how to filter Your Best Liker:";
            // 
            // MenuItemsListBox
            // 
            this.MenuItemsListBox.FormattingEnabled = true;
            this.MenuItemsListBox.ItemHeight = 20;
            this.MenuItemsListBox.Location = new System.Drawing.Point(187, 104);
            this.MenuItemsListBox.Name = "MenuItemsListBox";
            this.MenuItemsListBox.Size = new System.Drawing.Size(379, 224);
            this.MenuItemsListBox.TabIndex = 2;
            // 
            // MenuItemButton
            // 
            this.MenuItemButton.Location = new System.Drawing.Point(276, 365);
            this.MenuItemButton.Name = "MenuItemButton";
            this.MenuItemButton.Size = new System.Drawing.Size(174, 69);
            this.MenuItemButton.TabIndex = 3;
            this.MenuItemButton.Text = "choose 1 and press";
            this.MenuItemButton.UseVisualStyleBackColor = true;
            this.MenuItemButton.Click += new System.EventHandler(this.MenuItemButton_Click);
            // 
            // BestLikerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(863, 506);
            this.Controls.Add(this.MenuItemButton);
            this.Controls.Add(this.MenuItemsListBox);
            this.Controls.Add(this.labelYourBestLikerIs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestLikerMenuForm";
            this.Text = "BestLikerMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourBestLikerIs;
        private System.Windows.Forms.ListBox MenuItemsListBox;
        private System.Windows.Forms.Button MenuItemButton;
    }
}