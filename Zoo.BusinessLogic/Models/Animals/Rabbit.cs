using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : AnimalThatCanBeGroomed
  {
    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }
    public override void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Feed();
    }
  }
}