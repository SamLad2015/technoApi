using AutoMapper;
using technoApi.Models;

namespace technoApi.ViewModels.Mappings
{
    public class DomainToViewModelMappingProfile : AutoMapper.Profile
    {
        protected override void Configure()
        {
            Mapper.Cre<User, UserViewModel>().ForMember(vm => vm.ProfileName,
                map => map.MapFrom(u => u.Profile.FirstName + '' + u.Profile.Lastname));   
        }
    }
}    