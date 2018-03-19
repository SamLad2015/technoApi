using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class QualificationRepository: EntityBaseRepository<Qualification>, IQualificationRepository
    {
        public QualificationRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}