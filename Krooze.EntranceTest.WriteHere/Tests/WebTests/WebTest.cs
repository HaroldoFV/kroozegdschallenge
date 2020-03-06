using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Krooze.EntranceTest.WriteHere.Tests.WebTests
{
    public class WebTest
    {
        private static HttpClient _httpClient;
        public WebTest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public WebTest()
        {

        }
        private JObject movies = null;

        public JObject GetAllMovies()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the films object

            movies = Get();
            return movies;
        }


        public JObject Get()
        {
            using (var client = new HttpClient())
            {
           
                using (var response = client.GetAsync("https://swapi.co/api/films/").Result) //"https://swapi.co/api/films/"
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        var movies = JsonConvert.DeserializeObject<JObject>(result);
                        return movies;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public string GetDirector()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the name of person that directed the most star wars movies, based on the films object return

            movies = GetAllMovies();

            var result = movies["results"].Value<JArray>().FirstOrDefault();
            var director = result["director"].ToString();

            return director;
        }
    }
}
