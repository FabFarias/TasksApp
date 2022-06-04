using DashboardApp.Models.Assignments;

namespace DashboardApp.DTOs
{
    public class ListAssignmentDTO
    {
        public DateTime StarDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Assignment> Itens { get; set; }
    }
}
