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
            CreateMap<User, UserViewModel>()
                .ForMember(vm => vm.ProfileName,
                    map => map.MapFrom(u => u.Profile.FirstName + ' ' + u.Profile.FirstName));
        }
    }
}