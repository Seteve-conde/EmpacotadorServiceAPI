using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.DTOs
{
    public class ProdutoEntradaDTO
    {
        [Required]
        [JsonPropertyName("produto_id")]
        public string ProdutoId { get; set; } = string.Empty;

        [Required]
        public DimensoesDTO? Dimensoes { get; set; }
    }

}
