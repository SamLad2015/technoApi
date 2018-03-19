namespace technoApi.Models.Article
{
    public class Comment
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public Article Article { get; set; }
        public User.User User { get; set; }
    }
}