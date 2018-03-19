using System.ComponentModel.DataAnnotations.Schema;
namespace technoApi.Models.Profile
{
    public class JobTitle: IEntityBase
    {
        public int Id { get; set; }
        [Column("jobTitle")]
        public string Title { get; set; }
    }
}