using System.Collections.Generic;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
  public class Keeper
  {
    private List<Lion> animals;

    public Keeper(IEnumerable<Lion> animals)
    {
      this.animals = new List<Lion>(animals);
    }

    public IEnumerable<Lion> GetResponsibleAnimals()
    {
      return animals;
    }

    public void FeedAnimal(Lion animalToFeed)
    {
      animalToFeed.Feed();
    }
  }
}