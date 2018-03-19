using technoApi.Models.Config;

namespace technoApi.Models.Menu
{
    public class Menu: IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public int FontAwesomeFontId { get; set; }
        public int ParentMenuId { get; set; }
        public Menu ParentMenu { get; set; }
        public Menu[] ChildMenus { get; set; }
        public FontAwesomeFont FontASF { get; set; }
    }
}