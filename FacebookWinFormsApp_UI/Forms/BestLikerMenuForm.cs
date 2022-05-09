using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class BestLikerMenuForm : Form
    {
        private readonly AlbumProxy r_AlbumProxy;
        private readonly CommandClient r_CommandClient;

        public BestLikerMenuForm(AlbumProxy i_AlbumProxy)
        {
            r_AlbumProxy = i_AlbumProxy;
            r_CommandClient = new CommandClient(r_AlbumProxy);

            InitializeComponent();
            fetchMenu();
        }

        private void fetchMenu()
        {
            MenuItemsListBox.DisplayMember = "Text";
            foreach(MenuItem menuItem in r_CommandClient.Menu)
            {
                MenuItemsListBox.Items.Add(menuItem);
            }
        }

        private void MenuItemButton_Click(object sender, EventArgs e)
        {
            object selectItem = MenuItemsListBox.SelectedItem;
            (selectItem as MenuItem).Selected();
            List<User> bestLikers = new List<User>();
            try
            {
                bestLikers = r_AlbumProxy.bestLikers;
            }
            catch(Exception)
            {
                MessageBox.Show(@"We faced a problem with connect the likes system , please try later ");
            }
            finally
            {
                this.Hide();
                BestLikerForm bestNewFriend = FormFactory.CreateBestLikerForm(bestLikers);
                bestNewFriend.ShowDialog();
            }
        }
    }
}