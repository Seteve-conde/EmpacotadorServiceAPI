using System.Text.Json.Serialization;

namespace Application.DTOs
{
    public class PedidoSaidaDTO
    {
        [JsonPropertyName("pedido_id")]
        public string PedidoId { get; set; } = string.Empty;

        public List<CaixaSaidaDTO>? Caixas { get; set; }
    }
}
