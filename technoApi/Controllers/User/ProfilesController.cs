using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.ViewModels;
using Profile = technoApi.Models.Profile;

namespace technoApi.Controllers
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
        public List<Profile> GetProfiles()
        {
            return _profileService.GetAllProfiles().ToList();
        }
        
        [HttpGet("{id}", Name = "GetProfile")]
        public IActionResult Get(int id)
        {
            Profile profile = _profileService.GetProfileById(id);
            ProfileViewModel profileVM = Mapper.Map<Profile, ProfileViewModel>(profile);
            return new OkObjectResult(profileVM);
        }
        
    }
}