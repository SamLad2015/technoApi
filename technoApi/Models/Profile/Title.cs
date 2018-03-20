using System.ComponentModel.DataAnnotations.Schema;
namespace technoApi.Models.Profile
{
    public class Title: IEntityBase
    {
        public int Id { get; set; }
        [Column("title")]
        public string TitleText { get; set; }
    }
}