using System;
using System.Collections.Generic;

namespace rest_call.Models
{
  public class StarshipsModel
  {
    public List<StarshipModel> starships { get; set; }

    public List<StarshipModel> SortStarshipsAlphabetically()
    {
      this.starships.Sort(delegate(StarshipModel x, StarshipModel y)
        {
            if (x.Name == null && y.Name == null) return 0;
            else if (x.Name == null) return -1;
            else if (y.Name == null) return 1;
            else return x.Name.CompareTo(y.Name);
        });

      return starships;
    }
  }
}
