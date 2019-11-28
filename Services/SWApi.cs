using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using rest_call.Models;

namespace rest_call.Services
{
  public class SWApi
  {
    private static string BaseUri { get; set; } = "https://swapi.co/api/starships";
    public async Task<StarshipModel> GetStarshipAsync(HttpClient client, int starshipNumber)
    {
        StarshipModel starship = null;
        HttpResponseMessage response = await client.GetAsync($"{BaseUri}/{starshipNumber}");
        if (response.IsSuccessStatusCode)
        {
            starship = await response.Content.ReadAsAsync<StarshipModel>();
        }
        return starship;
    }
    public async Task<StarshipsResultModel> GetStarshipsAsync(HttpClient client, int page = 1)
    {
      StarshipsResultModel starships = null;
      HttpResponseMessage response = await client.GetAsync($"{BaseUri}/?page={page}");
          if (response.IsSuccessStatusCode)
          {
              starships = await response.Content.ReadAsAsync<StarshipsResultModel>();
          }
          return starships;
    }

    public async Task<List<StarshipModel>> GetAllStarshipsAsync(HttpClient client)
    {
      List<StarshipModel> allStarships = new List<StarshipModel>();

      StarshipsResultModel originalStarships = await GetStarshipsAsync(client);

      int pages = originalStarships.Count / originalStarships.Results.Count;
      if(originalStarships.Count % originalStarships.Results.Count != 0) pages++;

      originalStarships.Results.ForEach(starship => {
        allStarships.Add(starship);
      });

      for (int i = 2; i < pages + 1; i++)
      {
        StarshipsResultModel starships = await GetStarshipsAsync(client, i);
        starships.Results.ForEach(starship => {
          allStarships.Add(starship);
        });
      }

      return allStarships;
    }
  }
}
