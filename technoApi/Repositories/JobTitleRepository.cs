using System.Collections.Generic;
using System.Linq;
using technoApi.Models;

namespace technoApi.Repositories
{
    public class JobTitleRepository: EntityBaseRepository<JobTitle>, IJobTitleRepository
    {
        public JobTitleRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}