using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
  public class Keeper
  {
    private List<Animal> animals;

    public Keeper(IEnumerable<Animal> animals)
    {
      this.animals = new List<Animal>(animals);
    }

    public IEnumerable<TAnimal> GetResponsibleAnimals<TAnimal>()
    {
      return animals.OfType<TAnimal>();
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(ICanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }
  }
}