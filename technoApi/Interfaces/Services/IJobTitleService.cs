using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IJobTitleService
    {
        IEnumerable<JobTitle> GetAllJobTitles();
    }
}