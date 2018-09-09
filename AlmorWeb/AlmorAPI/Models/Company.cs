using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_COMPANY")]
    public class Company
    {
        [Key]
        [Column("CD_COMPANY")]
        public int CompanyId { get; set; }

        [Required]
        [Column("NM_COMPANY")]
        [StringLength(50)]
        public String Name{ get; set; }

        [Required]
        [Column("DS_EMAIL")]
        [StringLength(60)]
        public String Email { get; set; }

        
        [Column("NR_CNPJ")]
        [StringLength(14)]
        public String Cnpj { get; set; }
        
        [Column("DS_PHONE")]
        [StringLength(11)]
        public String Phone { get; set; }

        public IList<Employee> Employees { get; set;}
        public IList<CompanyCertification> CompanyCertifications { get; set; }
    }
}