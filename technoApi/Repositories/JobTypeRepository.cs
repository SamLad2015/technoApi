using System.Collections.Generic;
using System.Linq;
using technoApi.Models;

namespace technoApi.Repositories
{
    public class JobTypeRepository: EntityBaseRepository<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}