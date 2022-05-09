
namespace BasicFacebookFeatures.Forms
{
    partial class ChooseTeamForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxTeamsToChoose = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(424, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBoxTeamsToChoose
            // 
            this.listBoxTeamsToChoose.FormattingEnabled = true;
            this.listBoxTeamsToChoose.Items.AddRange(new object[] {
            "Top Teams",
            "Premier League",
            "MLS",
            "Liga MX",
            "La Liga",
            "Serie A",
            "Bundesliga",
            "Ligue 1"});
            this.listBoxTeamsToChoose.Location = new System.Drawing.Point(61, 87);
            this.listBoxTeamsToChoose.Name = "listBoxTeamsToChoose";
            this.listBoxTeamsToChoose.Size = new System.Drawing.Size(268, 95);
            this.listBoxTeamsToChoose.TabIndex = 1;
            //this.listBoxTeamsToChoose.SelectedIndexChanged = updateComponents
            // 
            // ChooseTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 297);
            this.Controls.Add(this.listBoxTeamsToChoose);
            this.Controls.Add(this.listBox1);
            this.Name = "ChooseTeamForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxTeamsToChoose;
    }
}