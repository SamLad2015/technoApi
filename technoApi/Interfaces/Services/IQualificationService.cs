using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IQualificationService
    {
        IEnumerable<Qualification> GetProfileQualifications(int profileId);
        Qualification GetQualification(int qualificationId);
    }
}