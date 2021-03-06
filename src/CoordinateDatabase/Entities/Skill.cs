﻿using System.ComponentModel.DataAnnotations;

namespace CoordinateDatabase.Entities
{
    public class Skill
    {

        [Key]
        public int SkillId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

    }
}
