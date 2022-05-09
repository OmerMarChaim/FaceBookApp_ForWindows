using FacebookWinFormsApp_Logic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FootballForm : Form
    {
        private readonly Venue r_VenueOfTeam;
        private readonly Team r_Team;

        public FootballForm(Response i_DataOfTheTeamWanted)
        {
            r_VenueOfTeam = i_DataOfTheTeamWanted.venue;
            r_Team = i_DataOfTheTeamWanted.team;
            InitializeComponent();
            updateComponents();
        }

        private void updateComponents()
        {
            this.labelStadiumName.Text = r_VenueOfTeam.name;
            this.labelSurface.Text = r_VenueOfTeam.surface;
            this.labelCapacity.Text = r_VenueOfTeam.capacity.ToString();
            this.labelCityName.Text = r_VenueOfTeam.city;
            this.labelAddress.Text = r_VenueOfTeam.address;
            this.pictureBox1VenuePic.ImageLocation = r_VenueOfTeam.image;
            this.labelTeamName.Text = r_Team.name;
            this.pictureBoxTeamLogo.ImageLocation = r_Team.logo;
        }
    }
}