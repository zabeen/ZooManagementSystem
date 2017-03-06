using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
  public class FeedingScheduler
  {
    private static FeedingScheduler instance;

    public static FeedingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new FeedingScheduler();
        }

        return instance;
      }
    }

    private FeedingScheduler()
    {
    }

    public void AssignFeedingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
    {
      foreach (var keeper in keepers)
      {
        foreach (var animal in keeper.GetResponsibleAnimals<Animal>())
        {
          if (animal.IsHungry())
          {
            keeper.FeedAnimal(animal);
          }
        }
      }
    }
  }
}