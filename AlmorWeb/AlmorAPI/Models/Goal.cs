using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    
    [Table("T_ALM_GOAL")]
    public class Goal
    {
        [Key]
        [Column("CD_GOAL")]
        public int GoalId { get; set; }
       
        [Required]
        [Column("NM_GOAL")]
        [StringLength(60)]
        public String Name { get; set; }
        [Required]
        [Column("VL_GOAL")]
        public int Value { get; set; }

        public List<UserGoal> UserGoals { get; set; }

    }
}