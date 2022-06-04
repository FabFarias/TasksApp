using DashboardApp.Models.Assignments;
using Microsoft.EntityFrameworkCore;

namespace DashboardApp.Infra.Database
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        public AssignmentContext(DbSet<Assignment> assignments)
        {
            Assignments = assignments;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source = AssignmentControl.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().HasNoKey();
        }
    }
}
