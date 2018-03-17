using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.ViewModels;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        // GET
        [HttpGet]
        public IActionResult GetUsers()
        {
            IEnumerable<UserViewModel> _usersVM = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userService.GetAllUsers());
            return new OkObjectResult(_usersVM);
        }
        
        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult Get(int id)
        {
            User _user = _userService.GetUserById(id);
            UserViewModel _userVM = Mapper.Map<User, UserViewModel>(_user);
            return new OkObjectResult(_userVM);
        }
    }
}