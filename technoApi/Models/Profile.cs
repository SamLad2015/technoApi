using Newtonsoft.Json;
namespace technoApi.Models
{
    public class Profile: IEntityBase
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public int JobTypeId { get; set; }
        public int JobTitleId { get; set; }
        public Title Title { get; set; }
        public JobType JobType { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}