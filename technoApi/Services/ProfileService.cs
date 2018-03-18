using System.Collections.Generic;
using System.Linq;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class ProfileService: IProfileService
    {
        private IProfileRepository _profileRepository;
        private ITitleRepository _titleRepository;
        private IJobTypeRepository _jobTypeRepository;
        private IJobTitleRepository _jobTitleRepository;

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

        public Profile GetProfileById(int profileId)
        {
            Profile _profile =  _profileRepository.GetSingle(p => p.Id == profileId);
            _profile.Title = _titleRepository.GetSingle(t => t.Id == _profile.TitleId);
            _profile.JobType = _jobTypeRepository.GetSingle(j => j.Id == _profile.JobTypeId);
            _profile.JobTitle = _jobTitleRepository.GetSingle(jt => jt.Id == _profile.JobTitleId);
            return _profile;
        }
    }
}