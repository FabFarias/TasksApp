using System.ComponentModel.DataAnnotations;

namespace DashboardApp.DTOs
{
    public class CreateAssignmentDTO
    {
        public CreateAssignmentDTO()
        {
            Date = DateTime.Now;
        }

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Data é obrigatória.")]
        public DateTime Date { get; set; }
    }
}
