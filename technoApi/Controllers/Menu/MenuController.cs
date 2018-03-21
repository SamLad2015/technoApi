using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Models.Article;
using technoApi.Models.Menu;
using technoApi.Repositories;
using technoApi.ViewModels;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        } 
        
        public IActionResult Get()
        {
            var menuVms = Mapper.Map<IEnumerable<Menu>, 
                IEnumerable<MenuViewModel>>(_menuService.GetAllMenus());
            return new OkObjectResult(menuVms);
        }
    }
}