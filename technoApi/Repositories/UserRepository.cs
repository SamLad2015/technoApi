using System.Collections.Generic;
using System.Linq;
using technoApi.Models;

namespace technoApi.Repositories
{
    public class UserRepository: EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}