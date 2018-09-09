﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmorAPI.Models
{
    [Table("T_ALM_USER")]
    public class Usuario
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Column("CD_USER")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("DS_USERNAME")]
        public String Username { get; set; }
        [Required]
        [StringLength(40)]
        [Column("DS_PASSWORD")]
        public String Password { get; set; }
        [Required]
        [StringLength(80)]
        [Column("NM_USER")]
        public String Name { get; set; }
        [Required]
        [StringLength(60)]
        [Column("DS_EMAIL")]
        public String Email { get; set; }
    }
}