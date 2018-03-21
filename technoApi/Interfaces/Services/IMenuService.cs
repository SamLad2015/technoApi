using System.Collections.Generic;
using technoApi.Models.Menu;
using technoApi.Models.User;

namespace technoApi.Interfaces.Services
{
    public interface IMenuService
    {
        IEnumerable<Menu> GetAllMenus();
 }
}