using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class JobHistoryRepository: EntityBaseRepository<JobHistory>, IJobHistoryRepository
    {
        public JobHistoryRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}