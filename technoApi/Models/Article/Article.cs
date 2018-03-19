namespace technoApi.Models.Article
{
    public class Article: IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public Comment[] Comments { get; set; }
    }
}