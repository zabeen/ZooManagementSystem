using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public interface IJobScheduler
    {
        string JobName { get; }
        void AssignJobs();
        void PerformJob(Keeper keeper, Animal animal);
    }
}
