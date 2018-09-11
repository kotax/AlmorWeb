using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_ACHIEVEMENT")]
    public class Achievement
    {
        [Key]
        [Column("CD_ACHIEVEMENT")]
        public int AchievementId { get; set; }
        
        [Required]
        [Column("DS_ACHIEVEMENT")]
        [StringLength(250)]
        public String Description { get; set; }

        [Required]
        [Column("DS_CATEGORY")]
        [StringLength(20)]
        public String Category { get; set; }

        //public IList<UserAchievement> UserAchievements { get; set; }

    }
}