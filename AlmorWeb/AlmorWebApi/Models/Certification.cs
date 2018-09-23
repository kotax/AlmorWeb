using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_CERTIFICATION")]
    public class Certification
    {

        [Key]
        [Column("CD_CERTIFICATION")]
        public int CertificationId { get; set; }

        [Required]
        [Column("DS_CERTIFICATION")]
        [StringLength(20)]
        public String Description { get; set; }

        [Required]
        [Column("VL_MIN_STRESS")]
        public int MinStress { get; set; }

        [Required]
        [Column("VL_MIN_POSTURE")]
        public int MinPosture { get; set; }

        public IList<CompanyCertification> CompanyCertifications { get; set; }

    }
}