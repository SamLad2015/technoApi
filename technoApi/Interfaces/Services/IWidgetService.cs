using System.Collections.Generic;
using technoApi.Models.Widget;

namespace technoApi.Interfaces.Services
{
    public interface IWidgetService
    {
        IEnumerable<Widget> GetWidgets(int parentId, bool? isTree);
        Widget GetWidget(int id);
    }
}