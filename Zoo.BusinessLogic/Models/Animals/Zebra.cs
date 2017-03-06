using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : Animal, ICanBeGroomed
  {
    private DateTime lastGroomed;

    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

    public void Groom()
    {
      lastGroomed = DateTime.Now;
    }

    public override string ToString()
    {
      return base.ToString() + $"; Last Groomed {lastGroomed}";
    }
  }
}