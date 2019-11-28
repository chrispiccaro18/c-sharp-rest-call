using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace rest_call
{
    class Program
    {
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
                starship = await swapi.GetStarshipAsync(client, 15);
                starship.ShowStarship();

                StarshipsModel starshipList = new StarshipsModel();
                starshipList.starships = await swapi.GetAllStarshipsAsync(client);
                starshipList.SortStarshipsAlphabetically();
                starshipList.starships.ForEach(starship => starship.ShowStarship());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Console.ReadLine();
        }
    }
}
