using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.ConsoleApp
{
  public static class Program
  {
    public static void Main()
    {
      var animals = new Animal[]
      {
        new Lion(new DateTime(2010, 4, 28)),
        new Lion(new DateTime(2012, 5, 11)),
        new Rabbit(new DateTime(2014, 1, 1)) 
      };

      var keepers = new[]
      {
        new Keeper(animals)
      };

      var scheduler = FeedingScheduler.Instance;

      while (true)
      {
        Console.WriteLine("Feeding the animals...");
        scheduler.AssignFeedingJobs(keepers, animals);

        Console.WriteLine("Done. Results:");

        foreach (var animal in animals)
        {
          Console.WriteLine(animal);
        }

        Console.WriteLine();
        Thread.Sleep(1000);
      }

    }
  }
}
