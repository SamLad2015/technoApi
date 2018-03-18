using System.ComponentModel.DataAnnotations.Schema;

namespace technoApi.Models
{
    public class JobType: IEntityBase
    {
        public int Id { get; set; }
        [Column("jobType")]
        public string Type { get; set; }
    }
}