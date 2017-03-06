using System;
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

    public IEnumerable<Animal> GetResponsibleAnimals(Type animalType)
    {
      return animals.Where(animal => animal.GetType().IsSubclassOf(animalType));
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(AnimalThatCanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }
  }
}