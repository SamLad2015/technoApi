namespace technoApi.Models
{
    public class Widget
    {
        public long Id { get; set; }
        public int Size { get; set; }
        public string WidgetClass { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Widget[] ChildWidgets { get; set; }
    }
}