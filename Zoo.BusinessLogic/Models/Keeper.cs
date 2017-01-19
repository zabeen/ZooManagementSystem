using System.Collections.Generic;
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

    public IEnumerable<Animal> GetResponsibleAnimals()
    {
      return animals;
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(Rabbit rabbit)
    {
      rabbit.Groom();
    }
  }
}