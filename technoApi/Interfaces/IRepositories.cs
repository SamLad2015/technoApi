using technoApi.Interfaces;
using technoApi.Models;

namespace technoApi.Repositories
{
    public interface IProfileRepository : IEntityBaseRepository<Profile> { }
    public interface IUserRepository : IEntityBaseRepository<User> { }
}