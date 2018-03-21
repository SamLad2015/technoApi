using technoApi.Models;
using technoApi.Models.Widget;

namespace technoApi.Repositories
{
    public class WidgetRepository: EntityBaseRepository<Widget>, IWidgetRepository
    {
        public WidgetRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}