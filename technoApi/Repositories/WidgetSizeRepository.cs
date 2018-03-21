using technoApi.Models;
using technoApi.Models.Config;
using technoApi.Models.Widget;

namespace technoApi.Repositories
{
    public class WidgetSizeRepository: EntityBaseRepository<WidgetSize>, IWidgetSizeRepository
    {
        public WidgetSizeRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}