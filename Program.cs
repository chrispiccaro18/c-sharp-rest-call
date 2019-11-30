using System;
using System.Net.Http;
using System.Threading.Tasks;
using rest_call.Services;
using rest_call.Models;

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
                StarshipImageService imageService = new StarshipImageService();

                StarshipModel starship = null;
                starship = await swapi.GetStarshipAsync(client, 12);
                starship.ShowStarship();
                string starshipImageUrl = await imageService.GetImageUrl(starship.Name);
                Console.WriteLine(starshipImageUrl);

                // StarshipsModel starshipList = new StarshipsModel();
                // starshipList.starships = await swapi.GetAllStarshipsAsync(client);
                // starshipList.SortStarshipsAlphabetically();
                // starshipList.starships.ForEach(starship => Console.WriteLine(starship.ShowStarshipNumber()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Console.ReadLine();
        }
    }
}
