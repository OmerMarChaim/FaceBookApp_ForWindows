using FacebookWrapper.ObjectModel;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FacebookWinFormsApp_Logic
{
    public class FootballApiFacade
    {
        private const string k_BaseUrl = "https://v3.football.api-sports.io/";
        private const string k_TeamUrl = "teams?";
        public static event Action<Response> m_FindTeamNotifier;
        public static event  Action m_DidntFindTeamNotifier;
        
        private static async Task<Response> GetTeamByNameAsync(string i_FootballName)
        {
            string url = $"{k_BaseUrl}{k_TeamUrl}name={i_FootballName}";
            TeamApiResponse dataFromHttp = await FootballApiAccess.Get(url);
            return dataFromHttp.response[0];
        }
        public static async Task CheckUserTeamByNameAsync(List<string> userFavoriteTeams )
        {
            int counter = 0;
            foreach (string team in userFavoriteTeams)
            {
                try
                {
                    Response dataOfTheTeamWanted = await GetTeamByNameAsync(team);
                    // we are here if an object return from the HTTP request.
                    findTeamCheckAndNotify(dataOfTheTeamWanted);
                    break;

                }
                catch (Exception)
                {
                    // ignored
                }
                finally
                {
                    counter++;
                    if (counter == userFavoriteTeams.Count)
                    {
                        didntFindTeamNotify();
                    }
                }
            }
        }
        public static async Task CheckUserQuestionTeamNameAsync(string i_Name)
        {
            try
            {
             Response dataOfTheTeamWanted = await GetTeamByNameAsync(i_Name);
                // we are here if an object return from the HTTP request.
             findTeamCheckAndNotify(dataOfTheTeamWanted);
            }
            catch (Exception)
            {
                didntFindTeamNotify();
            }

        }
        private static void findTeamCheckAndNotify(Response i_TeamData)
        {
            if (m_FindTeamNotifier != null )
            {
                m_FindTeamNotifier.Invoke(i_TeamData);
            }
        }
        private static void didntFindTeamNotify()
        {
            if (m_DidntFindTeamNotifier != null)
            {
                m_DidntFindTeamNotifier.Invoke();
            }
        }
    }
}