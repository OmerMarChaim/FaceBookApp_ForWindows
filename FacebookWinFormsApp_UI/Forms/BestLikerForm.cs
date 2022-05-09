using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class BestLikerForm : Form
    {
        private List<User> m_BestLikers;

        public BestLikerForm(List<User> i_BestLikers)
        {
            m_BestLikers = i_BestLikers;
            InitializeComponent();
            newFetchBestLikers();
        }

        private void newFetchBestLikers()
        {
            if(m_BestLikers != null)
            {
                userBindingSource.DataSource = m_BestLikers;
            }
            else
            {
                MessageBox.Show(@"We faced with a problem with your likes");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}