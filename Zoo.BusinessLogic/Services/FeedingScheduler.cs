using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class FeedingScheduler : Scheduler
    {
        public FeedingScheduler(IEnumerable<Keeper> keepers) : base(keepers)
        {
            Action = "Feeding";
        }

        public override void PerformJob(Keeper keeper, Animal animal)
        {
            if (animal.IsHungry())
                keeper.FeedAnimal(animal);
        }
    }
}