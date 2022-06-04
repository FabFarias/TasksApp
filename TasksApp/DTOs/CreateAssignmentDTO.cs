using System.ComponentModel.DataAnnotations;

namespace DashboardApp.DTOs
{
    public class CreateAssignmentDTO
    {
        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Data é obrigatória.")]
        public DateTime Data { get; set; }
    }
}
