using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using technoApi.Models;
using technoApi.Models.Context;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserContext _userContext;

        public UserController(UserContext userContext)
        {
            _userContext = userContext;

            if (_userContext.Users.Count() == 0)
            {
                _userContext.Users.Add(new User {UserName = "Sam", FirstName = "Sam", LastName = "Lad"});
                _userContext.SaveChanges();
            }
        }
        
        // GET
        public IEnumerable<User> GetAllUsers()
        {
            return _userContext.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(long id)
        {
            var user = _userContext.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return new ObjectResult(user);
        }
    }
}