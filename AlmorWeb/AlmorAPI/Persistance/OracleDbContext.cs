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

        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanyCertification> CompanyCertifications { get; set; }


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