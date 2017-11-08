using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using System.Linq;

namespace Zoo.BusinessLogic.Services
{
    public abstract class Scheduler : IJobScheduler
    {     
        public string JobName { get { return _jobName; } }

        protected string _jobName;
        protected List<Keeper> _keepers;

        public Scheduler(IEnumerable<Keeper> keepers)
        {
            _keepers = keepers.ToList();
        }

        public abstract void AssignJobs();
    }
}
