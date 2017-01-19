using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal
  {
    private DateTime lastGroomed;

    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
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