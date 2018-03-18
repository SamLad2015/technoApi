using System.Collections.Generic;
using technoApi.Models;

namespace technoApi.Interfaces.Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile GetProfileById(int profileId);
    }
}