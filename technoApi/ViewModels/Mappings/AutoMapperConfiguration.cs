using AutoMapper;
using technoApi.Models;
using Profile = AutoMapper.Profile;

namespace technoApi.ViewModels.Mappings
{
    public class AutoMapperConfigurationProfile: Profile
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
                cfg.CreateMap<User, UserViewModel>()
                    .ForMember(vm => vm.ProfileName,
                        map => map.MapFrom(u => u.Profile.FirstName + ' ' + u.Profile.LastName));
            });
        }
    }
}