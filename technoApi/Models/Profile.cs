using Newtonsoft.Json;
namespace technoApi.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string JobType { get; set; }
        public string JobTitle { get; set; }
        
        [JsonIgnore]
        public AppDb Db { get; set; }

        public Profile(AppDb db=null)
        {
            Db = db;
        }
    }
}