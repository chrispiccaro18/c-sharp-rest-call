using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace rest_call
{
  public class StarshipProcessor
  {
    public static async Task<StarshipModel> LoadStarship(int starshipNumber = 15)
    {
      string url = $"https://swapi.co/api/starships/{starshipNumber}/";
    
      using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
      {
        if (response.IsSuccessStatusCode)
        {
          StarshipModel starship = await response.Content.ReadAsAsync<StarshipModel>();

          return starship;
        }
        else
        {
          throw new Exception(response.ReasonPhrase);
        }
      }

    }

  }
}
