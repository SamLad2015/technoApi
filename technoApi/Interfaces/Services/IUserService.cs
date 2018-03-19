using System.Collections.Generic;
using technoApi.Models.User;

namespace technoApi.Interfaces.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}