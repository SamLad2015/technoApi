using System.Collections.Generic;
using System.Linq;
using technoApi.Interfaces.Services;
using technoApi.Models.Profile;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class ProfileService: IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        private readonly ITitleRepository _titleRepository;
        private readonly IJobTypeRepository _jobTypeRepository;
        private readonly IJobTitleRepository _jobTitleRepository;

        public ProfileService(IProfileRepository profileRepository, ITitleRepository titleRepository,
            IJobTypeRepository jobTypeRepository, IJobTitleRepository jobTitleRepository)
        {
            _profileRepository = profileRepository;
            _titleRepository = titleRepository;
            _jobTypeRepository = jobTypeRepository;
            _jobTitleRepository = jobTitleRepository;
        }
        
        public IEnumerable<Profile> GetAllProfiles()
        {
            return _profileRepository.GetAll();
        }

        public Profile GetBasicProfileById(int profileId)
        {
            var profile =  _profileRepository.GetSingle(p => p.Id == profileId);
            profile.Title = _titleRepository.GetSingle(t => t.Id == profile.TitleId);
            profile.JobType = _jobTypeRepository.GetSingle(j => j.Id == profile.JobTypeId);
            profile.JobTitle = _jobTitleRepository.GetSingle(jt => jt.Id == profile.JobTitleId);
            return profile;
        }
    }
}