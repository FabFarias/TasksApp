using DashboardApp.Models.Assignments;


namespace DashboardApp.Service
{
    public interface IAssignmentService
    {
        Task Create(DTOs.CreateAssignmentDTO createAssignment);

        Task<List<Assignment>> FindBy(DateTime startDate, DateTime endDate);
    }
}
