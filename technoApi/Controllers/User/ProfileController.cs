using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;
        
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        
        // GET
        [HttpGet]
        public List<Profile> GetProfiles()
        {
            return _profileService.GetAllProfiles().ToList();
        }
    }
}