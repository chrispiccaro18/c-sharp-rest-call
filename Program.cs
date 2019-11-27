using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace rest_call
{
    class Program
    {
        // static HttpClient client = new HttpClient();
        static HttpClient client = ApiHelper.ApiClient;

        static void Main()
        {
            ApiHelper.InitializeClient();
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            try
            {
                SWApi swapi = new SWApi();

                StarshipModel starship = null;
                starship = await swapi.GetStarshipAsync(15, client);
                starship.ShowStarship();

                StarshipsModel starships = null;
                starships = await swapi.GetStarshipsAsync(client);
                starships.ShowStarships();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Console.ReadLine();
        }
    }
}
