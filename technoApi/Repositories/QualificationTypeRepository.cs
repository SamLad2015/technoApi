using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class QualificationTypeRepository: EntityBaseRepository<QualificationType>, IQualificationTypeRepository
    {
        public QualificationTypeRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}