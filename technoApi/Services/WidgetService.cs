using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models.Article;
using technoApi.Models.Profile;
using technoApi.Models.Widget;
using technoApi.Repositories;
using technoApi.ViewModels;

namespace technoApi.Services
{
    public class WidgetService: IWidgetService
    {
        private readonly IWidgetRepository _widgetRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly IWidgetSizeRepository _widgetSizeRepository;
        private readonly IWidgetClassRepository _widgetClassRepository;

        public WidgetService(IWidgetRepository widgetRepository, IArticleRepository articleRepository,
            IWidgetSizeRepository widgetSizeRepository, IWidgetClassRepository widgetClassRepository)
        {
            _widgetRepository = widgetRepository;
            _articleRepository = articleRepository;
            _widgetSizeRepository = widgetSizeRepository;
            _widgetClassRepository = widgetClassRepository;
        }
        
        public IEnumerable<Widget> GetAllWidgets(int parentId)
        {
            var widgets = _widgetRepository.FindBy(w => w.ParentId == parentId && w.Id > 0).ToList();
            
            foreach (var widget in widgets)
            {
                if (widget.ArticleId.HasValue)
                {
                    widget.Article = _articleRepository.GetSingle(widget.ArticleId.Value);
                }

                widget.WidgetSize = _widgetSizeRepository.GetSingle(widget.WidgetSizeId);
                widget.WidgetClass = _widgetClassRepository.GetSingle(widget.WidgetClassId);
                widget.ChildWidgets = GetAllWidgets(widget.Id);
            }

            return widgets;
        }

        public Widget GetWidget(int id)
        {
            return _widgetRepository.GetSingle(id);
        }
    }
}