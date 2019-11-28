using System;
using System.Collections.Generic;

namespace rest_call
{
public class StarshipsResultModel
{
    public int Count { get; set; }
    public string Next { get; set; }
    public object Previous { get; set; }
    public List<StarshipModel> Results { get; set; }
    public void ShowStarships()
    {
        this.Results.ForEach((starship) => Console.WriteLine(starship.Name));
    }
}

}
