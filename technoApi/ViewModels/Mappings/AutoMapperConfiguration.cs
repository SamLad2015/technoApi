using AutoMapper;
using User = technoApi.Models.User;
using Profile = technoApi.Models.Profile;

namespace technoApi.ViewModels.Mappings
{
    public class AutoMapperConfigurationProfile: AutoMapper.Profile
    {
        public AutoMapperConfigurationProfile()
            : this("MyProfile")
        {
        }
        protected AutoMapperConfigurationProfile(string profileName)
            : base(profileName)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User.User, UserViewModel>().ForMember(vm => vm.ProfileName,
                        map => map.MapFrom(u => u.Profile.FirstName + ' ' + u.Profile.LastName));
                cfg.CreateMap<Profile.Profile, ProfileViewModel>().ForMember(vm => vm.Title,
                    map => map.MapFrom(p => p.Title.UserTitle));
                cfg.CreateMap<Profile.Profile, ProfileViewModel>().ForMember(vm => vm.JobType,
                    map => map.MapFrom(p => p.JobType.Type));
                cfg.CreateMap<Profile.Profile, ProfileViewModel>().ForMember(vm => vm.JobTitle,
                    map => map.MapFrom(p => p.JobTitle.Title));
            });
        }
    }
}