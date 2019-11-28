using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace rest_call.Services
{
  public static class ApiHelper
  {
    public static HttpClient ApiClient { get; set; }
    public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            // ApiClient.BaseAddress = new Uri("https://swapi.co/api/starships");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
  }
}
