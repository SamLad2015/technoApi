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
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;

            if (_dataContext.Users.Count() == 0)
            {
                _dataContext.Users.Add(new User {UserName = "Sam", ProfileId = 1});
                _dataContext.SaveChanges();
            }
        }
        
        // GET
        public IEnumerable<User> GetAllUsers()
        {
            return _dataContext.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(long id)
        {
            var user = _dataContext.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return new ObjectResult(user);
        }
    }
}