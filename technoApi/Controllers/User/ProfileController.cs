using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using technoApi.Models;
using technoApi.Models.Context;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private readonly DataContext _dataContext;

        public ProfileController(DataContext dataContext)
        {
            _dataContext = dataContext;

            if (_dataContext.Profiles.Count() == 0)
            {
                _dataContext.Profiles.Add(new Profile
                {
                    Title = "Mr", 
                    FirstName = "Sam",
                    LastName = "Lad",
                    Address1 = "Apt 16",
                    Address2 = "2 Madison Walk",
                    City = "Birmingham",
                    County = "West Midlands",
                    PostCode = "B15 2GQ",
                    Email = "lad.sangram@gmail.com",
                    JobTitle = "Software Developer",
                    JobType = "Contract"
                });
                _dataContext.SaveChanges();
            }
        }
        
        // GET
        public IEnumerable<Profile> GetAllProfiles()
        {
            return _dataContext.Profiles.ToList();
        }

        [HttpGet("{id}", Name = "GetProfile")]
        public IActionResult GetById(long id)
        {
            var profile = _dataContext.Profiles.FirstOrDefault(p => p.Id == id);
            if (profile == null)
            {
                return NotFound();
            }
            return new ObjectResult(profile);
        }
    }
}