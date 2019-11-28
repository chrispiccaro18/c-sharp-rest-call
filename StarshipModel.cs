using System;
using System.Text.RegularExpressions;

namespace rest_call
{
  public class StarshipModel
  {
    public string Name { get; set; }
    public string Model { get; set; }
    public string Starship_Class { get; set; }
    public string Manufacturer { get; set; }
    public string Cost_In_Credits { get; set; }
    public string Length { get; set; }
    public string Crew { get; set; }
    public string Passengers { get; set; }
    public string Max_Atmosphering_Speed { get; set; }
    public string Hyperdrive_Rating { get; set; }
    public string MGLT { get; set; }
    public string Cargo_Capacity { get; set; }
    public string Consumables { get; set; }
    public string Url { get; set; }

    public void ShowStarship()
    {
      Console.WriteLine($"Name: {this.Name} | Class: " +
          $"{this.Starship_Class}");
    }

    public int ShowStarshipNumber()
    {
      return Int32.Parse(Regex.Match(this.Url, @"\d+").Value);
    }
  }
}
