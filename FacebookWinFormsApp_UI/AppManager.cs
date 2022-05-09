using System;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Forms;
using FacebookWinFormsApp_Logic;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class AppManager
    {
        private readonly User r_LoggedInUser;
        public AppManager(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            FootballApiFacade.m_DidntFindTeamNotifier += new Action(didntFindYourTeams);
            FootballApiFacade.m_FindTeamNotifier += new Action<Response>(showFootballTeam);
            AppForm appForm = FormFactory.CreateAppForm(r_LoggedInUser);
            appForm.ShowDialog();
        }

        private static void showFootballTeam(Response i_Team)
        {
            FootballForm footballForm = FormFactory.CreateFootballForm(i_Team);
            footballForm.ShowDialog();
        }

        private static void didntFindYourTeams()
        {
            AppForm.ShowDidntFindYourTeams();
        }

        internal static async void CheckUserTeamName(User i_LoggedInUser)
        {
            List<string> userTeamsName = new List<string>();

            foreach(Page team in i_LoggedInUser.FavofriteTeams)
            {
                userTeamsName.Add(team.Name);
            }

            await FootballApiFacade.CheckUserTeamByNameAsync(userTeamsName);
        }

        internal static async void ChosenFromUserTeamName(string i_TeamName)
        {
            await FootballApiFacade.CheckUserQuestionTeamNameAsync(i_TeamName);
        }

        internal static void ShowNewQuestionForm()
        {
            FootballTeamQuestionForm questionForm = FormFactory.CreateFootballTeamQuestionForm();
            questionForm.ShowDialog();
        }
    }
}