using System.Collections.Generic;
using FacebookWinFormsApp_Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public static class FormFactory
    {
        internal static AppForm CreateAppForm(User i_LoggedInUser)
        {
            return new AppForm(i_LoggedInUser);
        }

        internal static FootballForm CreateFootballForm(Response i_DataOfTheTeamWanted)
        {
            return new FootballForm(i_DataOfTheTeamWanted);
        }

        internal static FootballTeamQuestionForm CreateFootballTeamQuestionForm()
        {
            return new FootballTeamQuestionForm();
        }

        internal static LoginForm CreateLoginForm()
        {
            return new LoginForm();
        }

        internal static BestLikerForm CreateBestLikerForm(List<User> i_BestLikers)
        {
            return new BestLikerForm(i_BestLikers);
        }

        internal static AlbumPhotosForm CreateAlbumPhotosForm(object i_SelectedItem)
        {
            return new AlbumPhotosForm(i_SelectedItem as Album);
        }

        internal static BestLikerMenuForm createBestLikerMenuForm(AlbumProxy i_AlbumProxy)
        {
            return new BestLikerMenuForm(i_AlbumProxy);
        }
    }
}