using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models.Menu;
using technoApi.Models.User;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class MenuService: IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        
        public IEnumerable<Menu> GetAllMenus()
        {
            return _menuRepository.FindBy(m => m.Id > 0);
        }
    }
}