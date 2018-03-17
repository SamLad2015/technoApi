using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IProfileRepository _profileRepository;

        public UserService(IUserRepository userRepository, IProfileRepository profileRepository)
        {
            _userRepository = userRepository;
            _profileRepository = profileRepository;
        }
        
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int userId)
        {
            User _user = _userRepository.GetSingle(u => u.Id == userId);
            _user.Profile = _profileRepository.GetSingle(p => p.Id == _user.ProfileId);
            return _user;
        }
    }
}