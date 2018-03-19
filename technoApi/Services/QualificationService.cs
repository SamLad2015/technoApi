using System.Collections.Generic;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class QualificationService: IQualificationService
    {
        private readonly IQualificationRepository _qualificationRepository;

        public QualificationService(IQualificationRepository qualificationRepository)
        {
            _qualificationRepository = qualificationRepository;
        }

        public IEnumerable<Qualification> GetProfileQualifications(int profileId)
        {
            return _qualificationRepository.FindBy(q => q.ProfileId == profileId);
        }

        public Qualification GetQualification(int qualificationId)
        {
            return _qualificationRepository.GetSingle(q => q.Id == qualificationId);
        }
    }
}