using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class JobTypeService: IJobTypeService
    {
        private readonly IJobTypeRepository _jobTypeRepository;

        public JobTypeService(IJobTypeRepository jobTypeRepository)
        {
            _jobTypeRepository = jobTypeRepository;
        }
        
        public IEnumerable<JobType> GetAllJobTypes()
        {
            return _jobTypeRepository.GetAll();
        }

    }
}