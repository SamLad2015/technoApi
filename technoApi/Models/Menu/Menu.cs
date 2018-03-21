using technoApi.Models.Config;

namespace technoApi.Models.Menu
{
    public class Menu: IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public int ParentMenuId { get; set; }
        public string FontAwesomeFont { get; set; }
    }
}