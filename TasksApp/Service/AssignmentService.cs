using DashboardApp.Infra.Database;
using DashboardApp.Models.Assignments;
using Microsoft.EntityFrameworkCore;

namespace DashboardApp.Service
{
    public class AssignmentService : IAssignmentService 
    {
        private readonly AssignmentContext _dbContext;

        public AssignmentService(AssignmentContext context)
        {
            _dbContext = context;
        }

        public async Task Create(DTOs.CreateAssignmentDTO createAssignment)
        {
            await _dbContext.Assignments.AddAsync(new Models.Assignments.Assignment()
            {
                Description = createAssignment.Description,
                Date = createAssignment.Date
            });
            await _dbContext.SaveChangesAsync();
        } 

        public async Task<List<Assignment>>FindBy(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new Exception("Data final deve ser maior que a data inicial.");

            var itens = await _dbContext.Assignments.Where(e => e.Date >= startDate && e.Date <= endDate).AsNoTracking()
                .ToListAsync();

            return itens;

        }
    } 
}
