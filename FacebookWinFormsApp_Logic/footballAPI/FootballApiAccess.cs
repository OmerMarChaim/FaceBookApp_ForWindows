using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookWinFormsApp_Logic
{
    internal static class FootballApiAccess
    {
        private static readonly System.Net.Http.HttpClient sr_Client = new System.Net.Http.HttpClient();
        private const string k_XKey = "90cba930a70fcf9b691e460af39b92c8";
        private const string k_ApiHost = "v3.football.api-sports.io";

        internal static async Task<TeamApiResponse> Get(string i_Url)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                                                 {
                                                     Method = HttpMethod.Get,
                                                     RequestUri = new Uri(i_Url),
                                                     Headers =
                                                         {
                                                             {"x-rapidapi-host", $"{k_ApiHost}"},
                                                             {"x-rapidapi-key", $"{k_XKey}"},
                                                         },
                                                 };

                HttpResponseMessage response = await sr_Client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                TeamApiResponse teamApi = JsonConvert.DeserializeObject<TeamApiResponse>(
                    responseBody,
                    new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});

                return teamApi;
            }
            catch(Exception e)
            {
                throw new Exception($"we faced exception {e.Message} in FootballAPi", e.InnerException);
            }
        }
    }
}