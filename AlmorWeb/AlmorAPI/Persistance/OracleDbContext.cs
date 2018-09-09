using AlmorAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlmorAPI.Persistance
{
    public class OracleDbContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        /*
        public OracleDbContext() : base("OracleDbConnectionString")
        {
           
            Database.SetInitializer<OracleDbContext>(null);
        }
        //*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RM78035");
        }
    }
}