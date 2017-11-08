using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using System.Linq;

namespace Zoo.BusinessLogic.Services
{
    public class FeedingScheduler : Scheduler
    {
        public FeedingScheduler(IEnumerable<Keeper> keepers) : base(keepers)
        {
            _jobName = "Feeding";
        }

        public override void AssignJobs()
        {
            _keepers.ForEach(k => k.GetResponsibleAnimals().ToList().ForEach(a => KeeperFeedAnimal(k, a)));
        }

        private void KeeperFeedAnimal(Keeper keeper, Animal animal)
        {
            if (animal.IsHungry())
            {
                keeper.FeedAnimal(animal);
            }
        }
    }
}