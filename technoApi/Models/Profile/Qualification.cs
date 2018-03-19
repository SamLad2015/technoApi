using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace technoApi.Models.Profile
{
    public class Qualification
    {
        public int Id { get; set; }
        [Column("qualification")]
        public string Title { get; set; }
        public string Organisation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProfileId { get; set; }
        public int QualificationTypeId { get; set; }
        public Profile Profile { get; set; }
        public QualificationType QualificationType { get; set; }
    }
}