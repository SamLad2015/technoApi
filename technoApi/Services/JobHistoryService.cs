using System.Collections.Generic;
using System.Linq;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class JobHistoryService: IJobHistoryService
    {
        private readonly IJobHistoryRepository _jobHistoryRepository;
        private readonly IJobTypeRepository _jobTypeRepository;

        public JobHistoryService(IJobHistoryRepository jobHistoryRepository, IJobTypeRepository jobTypeRepository)
        {
            _jobHistoryRepository = jobHistoryRepository;
            _jobTypeRepository = jobTypeRepository;
        }

        public IEnumerable<JobHistory> GetProfileJobHistory(int profileId)
        {
            var jobHistories = _jobHistoryRepository.FindBy(q => q.ProfileId == profileId).ToList();
            foreach (var jobHistory in jobHistories)
            {
                var jobType = _jobTypeRepository.GetSingle(jobHistory.JobTypeId);
                jobHistory.JobType = jobType;
            }
            return jobHistories;
        }

        public JobHistory GetJobHistory(int jobHistoryId)
        {
            var jobHistory = _jobHistoryRepository.GetSingle(jobHistoryId);
            jobHistory.JobType = _jobTypeRepository.GetSingle(jobHistory.JobTypeId);
            return jobHistory;
        }
    }
}