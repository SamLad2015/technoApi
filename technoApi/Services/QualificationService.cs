using System.Collections.Generic;
using System.Linq;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class QualificationService: IQualificationService
    {
        private readonly IQualificationRepository _qualificationRepository;
        private readonly IQualificationTypeRepository _qualificationTypeRepository;

        public QualificationService(IQualificationRepository qualificationRepository, IQualificationTypeRepository qualificationTypeRepository)
        {
            _qualificationRepository = qualificationRepository;
            _qualificationTypeRepository = qualificationTypeRepository;
        }

        public IEnumerable<Qualification> GetProfileQualifications(int profileId)
        {
            var qualifications = _qualificationRepository.FindBy(q => q.ProfileId == profileId).ToList();
            foreach (var qualification in qualifications)
            {
                var qualificationType = _qualificationTypeRepository.GetSingle(qualification.QualificationTypeId);
                qualification.QualificationType = qualificationType;
            }
            return qualifications;
        }

        public Qualification GetQualification(int qualificationId)
        {
            var qualification = _qualificationRepository.GetSingle(qualificationId);
            qualification.QualificationType = _qualificationTypeRepository.GetSingle(qualification.QualificationTypeId);
            return qualification;
        }
    }
}