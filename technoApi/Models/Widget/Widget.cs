using System.Collections.Generic;
using technoApi.Models.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace technoApi.Models.Widget
{
    public class Widget: IEntityBase
    {
        [Column("widgetId")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public int WidgetClassId { get; set; }
        public int WidgetSizeId { get; set; }
        public int ? ArticleId { get; set; }
        [Column("ParentWidgetId")]
        public int ParentId { get; set; }
        public WidgetClass WidgetClass { get; set; }
        public WidgetSize WidgetSize { get; set; }
        public Article.Article Article { get; set; }
        public IEnumerable<Widget> ChildWidgets { get; set; }
    }
}