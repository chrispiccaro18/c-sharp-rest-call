using System;

namespace rest_call
{
  public class StarshipModel
  {
    public string Name { get; set; }
    public string Starship_Class { get; set; }

    public void ShowStarship()
    {
        Console.WriteLine($"Name: {this.Name} | Class: " +
            $"{this.Starship_Class}");
    }
  }
}
