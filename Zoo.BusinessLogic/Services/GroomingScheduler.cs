using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class GroomingScheduler : Scheduler
    {
        public GroomingScheduler(IEnumerable<Keeper> keepers) : base(keepers)
        {
            Action = "Grooming";
        }

        public override void PerformJob(Keeper keeper, Animal animal)
        {
            var groomableAnimal = animal as AnimalThatCanBeGroomed;

            if (groomableAnimal != null)
                keeper.GroomAnimal(groomableAnimal);
        }
    }
}