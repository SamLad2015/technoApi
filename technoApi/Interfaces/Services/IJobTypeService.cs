using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IJobTypeService
    {
        IEnumerable<JobType> GetAllJobTypes();
    }
}