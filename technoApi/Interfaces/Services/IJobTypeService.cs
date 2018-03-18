using System.Collections.Generic;
using technoApi.Models;

namespace technoApi.Interfaces.Services
{
    public interface IJobTypeService
    {
        IEnumerable<JobType> GetAllJobTypes();
    }
}