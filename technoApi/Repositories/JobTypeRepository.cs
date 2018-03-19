using System.Collections.Generic;
using System.Linq;
using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class JobTypeRepository: EntityBaseRepository<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}