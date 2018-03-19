using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Controllers.User
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
            IEnumerable<UserViewModel> _usersVM = Mapper.Map<IEnumerable<Models.User.User>, IEnumerable<UserViewModel>>(_userService.GetAllUsers());
            return new OkObjectResult(_usersVM);
        }
        
        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult Get(int id)
        {
            Models.User.User user = _userService.GetUserById(id);
            UserViewModel userVM = Mapper.Map<Models.User.User, UserViewModel>(user);
            return new OkObjectResult(userVM);
        }
    }
}