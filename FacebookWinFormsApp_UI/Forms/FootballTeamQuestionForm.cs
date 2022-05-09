using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FootballTeamQuestionForm : Form
    {
        public FootballTeamQuestionForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object i_Sender, EventArgs i_)
        {
            AppManager.ChosenFromUserTeamName(textBoxTeamName.Text);
            this.Hide();
        }
    }
}