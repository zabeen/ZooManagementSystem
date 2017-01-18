using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion
  {
    private readonly DateTime dateOfBirth;
    private DateTime lastFed;

    public Lion(DateTime dateOfBirth)
    {
      this.dateOfBirth = dateOfBirth;
    }

    public TimeSpan Age
    {
      get { return DateTime.Today - dateOfBirth; }
    }

    public DateTime LastFed
    {
      get { return lastFed; }
    }

    public void Feed()
    {
      lastFed = DateTime.Now;
    }

    public bool IsHungry()
    {
      // Obviously a lion wouldn't get hungry in a matter of seconds. 
      // But it means we can see activity in real time when we run the code...
      return (DateTime.Now - lastFed).TotalSeconds > Config.FeedingFrequency;
    }
  }
}
