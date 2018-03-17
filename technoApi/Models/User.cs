namespace technoApi.Models
{
    public class User: IEntityBase
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}