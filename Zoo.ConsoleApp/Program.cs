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
      var lions = new[]
      {
        new Lion(new DateTime(2010, 4, 28)),
        new Lion(new DateTime(2012, 5, 11))
      };

      var keepers = new[]
      {
        new Keeper(lions)
      };

      var scheduler = FeedingScheduler.Instance;

      while (true)
      {
        Console.WriteLine("Feeding the animals...");
        scheduler.AssignFeedingJobs(keepers, lions);

        Console.WriteLine("Done. Results:");

        foreach (var lion in lions)
        {
          Console.WriteLine($" Lion, last fed {lion.LastFed}");
        }

        Console.WriteLine();
        Thread.Sleep(1000);
      }

    }
  }
}
