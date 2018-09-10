using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_EMPLOYEE")]
    public class Employee : User
    {

        [Required]
        [Column("CD_COMPANY")]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Required]
        [Column("DS_ROLE")]
        [StringLength(50)]
        public String Role { get; set; }

        [Required]
        [Column("DS_SECTOR")]
        [StringLength(50)]
        public String Sector { get; set; }

        [Column("CD_MANAGER")]
        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }


    }
}