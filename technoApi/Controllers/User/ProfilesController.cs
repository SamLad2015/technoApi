using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Controllers.User
{
    [Route("api/[controller]")]
    public class ProfilesController : Controller
    {
        private readonly IProfileService _profileService;
        
        public ProfilesController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        
        // GET
        [HttpGet]
        public List<Models.Profile.Profile> GetProfiles()
        {
            return _profileService.GetAllProfiles().ToList();
        }
        
        [HttpGet("{id}", Name = "GetProfile")]
        public IActionResult Get(int id)
        {
            var profileVm = Mapper.Map<Models.Profile.Profile, ProfileViewModel>(_profileService.GetBasicProfileById(id));
            return new OkObjectResult(profileVm);
        }
    }
}