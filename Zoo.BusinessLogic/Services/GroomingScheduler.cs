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

    public void AssignGroomingJobs(IEnumerable<IKeeper> keepers, IEnumerable<IAnimal> animals)
    {
      foreach (var keeper in keepers)
      {
        foreach (var animal in keeper.GetResponsibleAnimals<ICanBeGroomed>())
        {
          keeper.GroomAnimal(animal);
        }
      }
    }
  }
}