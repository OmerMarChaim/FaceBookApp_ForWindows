using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures.Forms
{
    public partial class LoginForm : Form
    {
        LoginResult m_LoginResult;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object i_Sender, EventArgs i_)
        {
        }

        private void pictureBox1_Click(object i_Sender, EventArgs i_)
        {
            m_LoginResult = FacebookService.Login(
                "597054344674905",
                /// requested permissions:
                "email",
                "public_profile",
                "user_friends",
                "user_likes",
                "user_link",
                "user_photos",
                "user_posts",
                "groups_access_member_info",
                "publish_to_groups",
                "user_videos");

            if(!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                this.Hide();
                new AppManager(m_LoginResult.LoggedInUser);
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, @"Login Failed");
            }
        }
    }
}