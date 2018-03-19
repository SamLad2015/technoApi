using technoApi.Models.Config;

namespace technoApi.Models.Widget
{
    public class Widget: IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int WidgetClassId { get; set; }
        public int WidgetSizeId { get; set; }
        public int ArticleId { get; set; }
        public WidgetClass WidgetClass { get; set; }
        public WidgetSize WidgetSize { get; set; }
        public Widget[] ChildWidgets { get; set; }
        public Article.Article Article { get; set; }
    }
}