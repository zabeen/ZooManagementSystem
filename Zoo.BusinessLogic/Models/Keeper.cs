using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
  public abstract class Keeper
  {
    public abstract IEnumerable<T> GetResponsibleAnimals<T>();

    public abstract void FeedAnimal(Animal animalToFeed);

    public abstract void GroomAnimal(ICanBeGroomed animalToGroom);
  }

  public class Keeper<TAnimal> : Keeper where TAnimal : IAnimal
  {
    private List<TAnimal> animals;

    public Keeper(IEnumerable<TAnimal> animals)
    {
      this.animals = new List<TAnimal>(animals);
    }

    public override IEnumerable<T> GetResponsibleAnimals<T>()
    {
      return animals.OfType<T>();
    }

    public override void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public override void GroomAnimal(ICanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }
  }
}