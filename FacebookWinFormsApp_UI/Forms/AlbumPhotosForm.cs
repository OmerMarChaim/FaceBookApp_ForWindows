using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class AlbumPhotosForm : Form
    {
        private readonly string r_AlbumName;
        private readonly AlbumProxy r_AlbumProxy;

        public AlbumPhotosForm(Album i_Album)
        {
            r_AlbumProxy = AlbumProxy.GetNewAlbumProxy(i_Album);
            r_AlbumName = i_Album.Name;
            InitializeComponent();
            initPhotosFromAlbum();
        }

        private void initPhotosFromAlbum()
        {
            this.labelAlbumName.Text = r_AlbumName;
            int positionX = 40;
            int positionY = 70;
            int photosCounter = 0;
            foreach(Photo photo in r_AlbumProxy.m_Album.Photos)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.LoadAsync(photo.PictureThumbURL);
                pictureBox.Location = new System.Drawing.Point(positionX, positionY);
                pictureBox.Name = $"pictureBox{photosCounter.ToString()}";
                pictureBox.Size = new System.Drawing.Size(120, 110);

                r_AlbumProxy.FetchPhotosLikesFromAlbums(photo.LikedBy);

                this.Controls.Add(pictureBox);
                if(positionX > 500)
                {
                    positionX = 40;
                    positionY = positionY + 150;
                }
                else
                {
                    positionX = positionX + 155;
                }
            }
        }

        private void buttonFindTheBestLiker_Click(object i_Sender, EventArgs i_)
        {
            BestLikerMenuForm bestLikerMenuForm = FormFactory.createBestLikerMenuForm(r_AlbumProxy);
            bestLikerMenuForm.ShowDialog();
        }
    }
}