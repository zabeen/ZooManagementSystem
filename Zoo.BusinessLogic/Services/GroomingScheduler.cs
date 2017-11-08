using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using System.Linq;

namespace Zoo.BusinessLogic.Services
{
    public class GroomingScheduler : Scheduler
    {
        public GroomingScheduler(IEnumerable<Keeper> keepers) : base(keepers)
        {
            _jobName = "Grooming";
        }

        public override void AssignJobs()
        {
            _keepers.ForEach(k => k.GetResponsibleAnimals().ToList().ForEach(a => KeeperGroomAnimal(k, a)));
        }

        private void KeeperGroomAnimal(Keeper keeper, Animal animal)
        {
            var groomableAnimal = animal as AnimalThatCanBeGroomed;

            if (groomableAnimal != null)
            {
                keeper.GroomAnimal(groomableAnimal);
            }
        }
    }
}