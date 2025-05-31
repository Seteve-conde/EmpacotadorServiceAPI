using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class DimensoesDTO
    {
        [Required]
        public double Altura { get; set; }

        [Required]
        public double Largura { get; set; }

        [Required]
        public double Comprimento { get; set; }
    }

}
