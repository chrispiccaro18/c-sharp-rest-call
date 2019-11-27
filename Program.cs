using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace rest_call
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void ShowStarship(StarshipModel starship)
        {
            Console.WriteLine($"Name: {starship.Name}\tClass: " +
                $"{starship.Starship_Class}");
        }

        static async Task<StarshipModel> GetStarshipAsync(string path = "")
        {
            StarshipModel starship = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                starship = await response.Content.ReadAsAsync<StarshipModel>();
            }
            return starship;
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://swapi.co/api/starships/15");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                StarshipModel starship = null;

                starship = await GetStarshipAsync();
                ShowStarship(starship);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
