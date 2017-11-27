using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class Scheduler : IJobScheduler
    {
        public string JobName => Action;

        protected string Action;
        protected List<Keeper> Keepers;

        public Scheduler(IEnumerable<Keeper> keepers)
        {
            Keepers = keepers.ToList();
        }

        public void AssignJobs()
        {
            Keepers.ForEach(k => k.GetResponsibleAnimals().ToList().ForEach(a => PerformJob(k, a)));
        }

        public virtual void PerformJob(Keeper keeper, Animal animal)
        {
            return;
        }
    }
}
