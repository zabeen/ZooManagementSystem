using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public abstract class Animal : IAnimal
  {
    private readonly DateTime dateOfBirth;
    private DateTime lastFed;

    protected Animal(DateTime dateOfBirth)
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

    public virtual void Feed()
    {
      lastFed = DateTime.Now;
    }

    public bool IsHungry()
    {
      // Obviously an animal wouldn't get hungry in a matter of seconds. 
      // But it means we can see activity in real time when we run the code...
      return (DateTime.Now - lastFed).TotalSeconds > Config.FeedingFrequency;
    }

    public override string ToString()
    {
      return $"{GetType().Name}, last fed {lastFed}";
    }
  }
}