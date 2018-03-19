using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class JobTitleRepository: EntityBaseRepository<JobTitle>, IJobTitleRepository
    {
        public JobTitleRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}