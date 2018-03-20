using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IQualificationTypeService
    {
        IEnumerable<QualificationType> GetQualificationTypes();
        QualificationType GetQualificationType(int qualificationId);
    }
}