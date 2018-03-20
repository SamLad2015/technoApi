using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IJobHistoryService
    {
        IEnumerable<JobHistory> GetProfileJobHistory(int profileId);
        JobHistory GetJobHistory(int jobHistoryId);
    }
}