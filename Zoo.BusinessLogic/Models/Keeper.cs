using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
  public interface IKeeper
  {
    IEnumerable<T> GetResponsibleAnimals<T>();

    void FeedAnimal(Animal animalToFeed);

    void GroomAnimal(ICanBeGroomed animalToGroom);
  }

  public interface IKeeper<in TAnimal> : IKeeper where TAnimal : IAnimal
  {
    void StartLookingAfter(TAnimal newAnimal);
  }

  public class Keeper<TAnimal> : IKeeper<TAnimal> where TAnimal : IAnimal
  { 
    private List<TAnimal> animals;

    public Keeper(IEnumerable<TAnimal> animals)
    {
      this.animals = new List<TAnimal>(animals);
    }

    public IEnumerable<T> GetResponsibleAnimals<T>()
    {
      return animals.OfType<T>();
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(ICanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }

    public void StartLookingAfter(TAnimal newAnimal)
    {
      animals.Add(newAnimal);
    }
  }
}