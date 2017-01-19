using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
  public class GroomingScheduler
  {
    private static GroomingScheduler instance;

    public static GroomingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new GroomingScheduler();
        }

        return instance;
      }
    }

    private GroomingScheduler()
    {
    }

    public void AssignGroomingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
    {
      foreach (var keeper in keepers)
      {
        foreach (var animal in keeper.GetResponsibleAnimals())
        {
          var rabbit = animal as Rabbit;

          if (rabbit != null)
          {
            keeper.GroomAnimal(rabbit);
          }
        }
      }
    }
  }
}