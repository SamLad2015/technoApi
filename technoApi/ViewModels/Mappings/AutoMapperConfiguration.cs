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
                //user
                cfg.CreateMap<User.User, UserViewModel>().ForMember(vm => vm.ProfileName,
                        map => map.MapFrom(u => u.Profile.FirstName + ' ' + u.Profile.LastName));
                //profile
                cfg.CreateMap<Profile.Profile, ProfileViewModel>().ForMember(vm => vm.Title,
                    map => map.MapFrom(p => p.Title.TitleText)).ForMember(vm => vm.JobTitle,
                    map => map.MapFrom(p => p.JobTitle.JTitle)).ForMember(vm => vm.JobType,
                    map => map.MapFrom(p => p.JobType.JType));
                //qualification
                cfg.CreateMap<Profile.Qualification, QualificationViewModel>().ForMember(vm => vm.QualificationTypeName,
                    map => map.MapFrom(q => q.QualificationType.QualificationName));
                //qualification Type
                cfg.CreateMap<Profile.QualificationType, QualificationTypeViewModel>();
            });
        }
    }
}