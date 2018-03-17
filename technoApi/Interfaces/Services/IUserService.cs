using System.Collections.Generic;
using technoApi.Models;

namespace technoApi.Interfaces.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}