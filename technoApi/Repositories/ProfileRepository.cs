using System.Collections.Generic;
using System.Linq;
using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class ProfileRepository: EntityBaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}