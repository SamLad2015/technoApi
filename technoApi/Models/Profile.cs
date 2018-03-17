using Newtonsoft.Json;
namespace technoApi.Models
{
    public class Profile: IEntityBase
    {
        public int Id { get; set; }
        public long TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public long JobTypeId { get; set; }
        public long JobTitleId { get; set; }
    }
}