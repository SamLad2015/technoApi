using System.Collections.Generic;
using technoApi.Models.Widget;

namespace technoApi.Interfaces.Services
{
    public interface IWidgetService
    {
        IEnumerable<Widget> GetAllWidgets(int parentId);
        Widget GetWidget(int id);
    }
}