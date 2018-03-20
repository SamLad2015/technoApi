using System.Collections.Generic;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class QualificationTypeService: IQualificationTypeService
    {
        private readonly IQualificationTypeRepository _qualificationTypeRepository;

        public QualificationTypeService(IQualificationTypeRepository qualificationTypeRepository)
        {
            _qualificationTypeRepository = qualificationTypeRepository;
        }

        public IEnumerable<QualificationType> GetQualificationTypes()
        {
            return _qualificationTypeRepository.GetAll();
        }

        public QualificationType GetQualificationType(int qualificationId)
        {
            return _qualificationTypeRepository.GetSingle(qualificationId);
        }
    }
}