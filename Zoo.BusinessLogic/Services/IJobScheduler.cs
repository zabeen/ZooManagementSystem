using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Services
{
    public interface IJobScheduler
    {
        string JobName { get; }
        void AssignJobs();
    }
}
