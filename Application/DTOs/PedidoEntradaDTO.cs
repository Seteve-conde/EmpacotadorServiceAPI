using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.DTOs
{
    public class PedidoEntradaDTO
    {
        [Required]
        [JsonPropertyName("pedido_id")]
        public int PedidoId { get; set; }

        [Required]
        public List<ProdutoEntradaDTO>? Produtos { get; set; }
    }

}
