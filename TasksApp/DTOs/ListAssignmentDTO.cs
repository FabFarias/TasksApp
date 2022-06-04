using DashboardApp.Models.Assignments;

namespace DashboardApp.DTOs
{
    public class ListAssignmentDTO
    {
        public ListAssignmentDTO()
        {
            StartDate = DateTime.UtcNow.AddDays(-7);
            EndDate = DateTime.UtcNow.AddDays(15);
            Itens = new List<Assignment>();
        }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Assignment> Itens { get; set; }
    }
}
