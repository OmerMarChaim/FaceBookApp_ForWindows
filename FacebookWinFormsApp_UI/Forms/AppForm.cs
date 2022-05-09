using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class AppForm : Form
    {
        private readonly User r_LoggedInUser;
        private bool m_ThereIsFootballTeams;

        public AppForm(User i_LoggedInUser)
        {
            m_ThereIsFootballTeams = false;
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            updateComponents();

            FacebookService.s_CollectionLimit = 100;
        }

        private void updateComponents()
        {
            this.labelUserName.Text = r_LoggedInUser.Name;
        }

        private void fetchUserInfo()
        {
            try
            {
                fetchProfilePic();
                fetchAlbums();
                fetchPosts();
                fetchFavoriteTeams();
                fetchGroups();
            }
            catch(Exception e)
            {
                MessageBox.Show(
                    $@"We faced with exception, please try again. 
error: {e.Message} ");
            }
        }

        private void fetchGroups()
        {
            listBoxGroups.Invoke(
                new Action(
                    () =>
                        {
                            listBoxGroups.Items.Clear();
                            listBoxGroups.DisplayMember = "Name";
                        }));

            foreach(Group group in r_LoggedInUser.Groups)
            {
                listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
            }
        }

        private void fetchPosts()
        {
            //listBoxPosts.Items.Clear();

            foreach(Post post in r_LoggedInUser.Posts)
            {
                listBoxPosts.Invoke(
                    new Action(
                        () =>
                            {
                                if(post.Message != null)
                                {
                                    listBoxPosts.Items.Add(post.Message);
                                }
                                else if(post.Caption != null)
                                {
                                    listBoxPosts.Items.Add(post.Caption);
                                }
                                else
                                {
                                    listBoxPosts.Items.Add($"[{post.Type}]");
                                }
                            }));
            }
        }

        internal static void ShowDidntFindYourTeams()
        {
            MessageBox.Show(@"we could not find your team as they wright in the pages, please try to type.");
            AppManager.ShowNewQuestionForm();
        }

        internal static void ShowErorWithTeamName()
        {
            MessageBox.Show(
                @"we faced a problem with the football team name,
please enter again the name or choose another team.");
            AppManager.ShowNewQuestionForm();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(
                new Action(
                    () =>
                        {
                            listBoxAlbums.Items.Clear();
                            listBoxAlbums.DisplayMember = "Name";
                        }));

            foreach(Album album in r_LoggedInUser.Albums)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));

                if(listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show(@"There is no albums to fetch");
                }
            }
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.DisplayMember = "Name"));
            //listBoxFavoriteTeams.Items.Clear();
            if(r_LoggedInUser.FavofriteTeams != null)
            {
                m_ThereIsFootballTeams = true;
                foreach(Page team in r_LoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add(team)));
                }
            }
        }

        private void fetchProfilePic()
        {
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_)
        {
            FacebookService.LogoutWithUI();
        }

        private void buttonClickToFetch_Click(object i_Sender, EventArgs i_)
        {
            MessageBox.Show(@"We try to fetch your data, please wait.");
            new Thread(fetchUserInfo).Start();
        }

        private void buttonChooseAlbum_Click(object i_Sender, EventArgs i_)
        {
            AlbumPhotosForm photosForm = FormFactory.CreateAlbumPhotosForm(listBoxAlbums.SelectedItem);
            photosForm.ShowDialog();
        }

        private void buttonFootball_Click(object i_Sender, EventArgs i_)
        {
            if(m_ThereIsFootballTeams)
            {
                AppManager.CheckUserTeamName(r_LoggedInUser);
            }
            else
            {
                AppManager.ShowNewQuestionForm();
            }
        }
    }
}