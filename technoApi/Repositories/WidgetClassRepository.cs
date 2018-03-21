using technoApi.Models;
using technoApi.Models.Config;
using technoApi.Models.Widget;

namespace technoApi.Repositories
{
    public class WidgetClassRepository: EntityBaseRepository<WidgetClass>, IWidgetClassRepository
    {
        public WidgetClassRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}