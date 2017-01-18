using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
  public class FeedingScheduler
  {
    public void AssignFeedingJobs(IEnumerable<Keeper> keepers, IEnumerable<Lion> animals)
    {
      foreach (var keeper in keepers)
      {
        foreach (var animal in keeper.GetResponsibleAnimals())
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