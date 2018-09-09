using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_USER_ACHIEVEMENT")]
    public class UserAchievement
    {
       
       // public int Achivement { get; set;}

        [Key]
        [Column("CD_ACHIEVEMENT", Order = 0)]
        public int AchivementId { get; set; }

       
        //public User User { get; set; }

        [Key]
        [Column("CD_USER", Order = 1)]
        public int UserId { get; set; }

        [Key]
        [Column("DT_ACHIEVED", Order = 2)]
        public DateTime DtAchived{ get; set;}

    }
}