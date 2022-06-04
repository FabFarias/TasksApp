using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DashboardApp.Models.Assignments
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [MaxLength (200)]
        public string? Description { get; set; }

        public DateTime Date { get; set; }

    }
}
