using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_COMPANY_CERT")]
    public class CompanyCertification
    {
       
        //public Company Company { get; set; }

        [Key]
        [Column("CD_COMPANY", Order = 0)]
        public int CompanyId { get; set; }

        
       // public Certification Certification { get; set; }
        [Key]
        [Column("CD_CERTIFICATION", Order = 1)]
        public int CertificationId { get; set; }

        [Key]
        [Column("DT_CERTIFIED", Order = 2)]
        public DateTime DtCertified { get; set; }
    }
}