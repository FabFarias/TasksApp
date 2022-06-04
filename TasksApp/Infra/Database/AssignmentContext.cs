using DashboardApp.Models.Assignments;
using Microsoft.EntityFrameworkCore;

namespace DashboardApp.Infra.Database
{
    public class AssignmentContext : DbContext
    {

        public AssignmentContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AssignmentControl.db");
        }

        public DbSet<Assignment> Assignment { get; set; }
    }
}
