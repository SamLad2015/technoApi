using System;

namespace technoApi.Models.Profile
{
    public class JobHistory
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobTypeId { get; set; }
        public int ProfileId { get; set; }
        public JobType JobType { get; set; }
        public Profile Profile { get; set; }
    }
}