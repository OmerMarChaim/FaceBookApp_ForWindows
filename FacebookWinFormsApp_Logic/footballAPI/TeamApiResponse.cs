namespace FacebookWinFormsApp_Logic
{
    /// <summary>
    /// Naming in this class is according to the JSON that we get from the api.
    /// </summary>
    public class TeamApiResponse
    {
        public string get { get; set; }

        public Parameters parameters { get; set; }

        public object[] errors { get; set; }

        public int results { get; set; }

        public Paging paging { get; set; }

        public Response[] response { get; set; }
    }

    public class Parameters
    {
        public string id { get; set; }
    }

    public class Paging
    {
        public int current { get; set; }

        public int total { get; set; }
    }

    public class Response
    {
        public Team team { get; set; }

        public Venue venue { get; set; }
    }

    public class Team
    {
        public int id { get; set; }

        public string name { get; set; }

        public string country { get; set; }

        public int founded { get; set; }

        public bool national { get; set; }

        public string logo { get; set; }
    }

    public class Venue
    {
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public int capacity { get; set; }

        public string surface { get; set; }

        public string image { get; set; }
    }
}