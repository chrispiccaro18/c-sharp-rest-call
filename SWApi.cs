using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace rest_call
{
  public class SWApi
  {
    private static string BaseUri { get; set; } = "https://swapi.co/api/starships";
    public async Task<StarshipModel> GetStarshipAsync(int starshipNumber, HttpClient client)
    {
        StarshipModel starship = null;
        HttpResponseMessage response = await client.GetAsync($"{BaseUri}/{starshipNumber}");
        if (response.IsSuccessStatusCode)
        {
            starship = await response.Content.ReadAsAsync<StarshipModel>();
        }
        return starship;
    }
  public async Task<StarshipsModel> GetStarshipsAsync(HttpClient client)
  {
    StarshipsModel starships = null;
    HttpResponseMessage response = await client.GetAsync(BaseUri);
        if (response.IsSuccessStatusCode)
        {
            starships = await response.Content.ReadAsAsync<StarshipsModel>();
        }
        return starships;
  }
  }
}
