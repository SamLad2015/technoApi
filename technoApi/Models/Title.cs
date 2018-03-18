﻿using System.ComponentModel.DataAnnotations.Schema;
namespace technoApi.Models
{
    public class Title: IEntityBase
    {
        public int Id { get; set; }
        [Column("title")]
        public string UserTitle { get; set; }
    }
}