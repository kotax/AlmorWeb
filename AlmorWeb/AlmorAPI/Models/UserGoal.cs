using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_USER_GOAL")]
    public class UserGoal
    {
        [Key]
        [Column("DT_GOAL_USER", Order = 0)]
        public DateTime DtGoalUser { get; set; }
        
       
        //public Goal Goal{ get; set; }

        [Key]
        [Column("CD_GOAL", Order = 1)]
        public int GoalId { get; set; }

        //public User User{ get; set; }

        [Key]
        [Column("CD_USER", Order = 2)]
        public int UserId { get; set; }

        [Required]
        [Column("VL_GOAL")]
        public int Value { get; set; }


    }
}