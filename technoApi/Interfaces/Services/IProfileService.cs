using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile GetBasicProfileById(int profileId);
    }
}