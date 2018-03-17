using System.Collections.Generic;
using System.Linq;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class ProfileService: IProfileService
    {
        private IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }
        
        public IEnumerable<Profile> GetAllProfiles()
        {
            return _profileRepository.GetAll();
        }

        public Profile GetProfile(int profileId)
        {
            return _profileRepository.GetSingle(p => p.Id == profileId);
        }
    }
}