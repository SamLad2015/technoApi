using technoApi.Models;
using technoApi.Models.Menu;

namespace technoApi.Repositories
{
    public class MenuRepository: EntityBaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}