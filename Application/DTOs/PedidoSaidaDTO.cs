using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PedidoSaidaDTO
    {
        [JsonPropertyName("pedido_id")]
        public string PedidoId { get; set; } = string.Empty;

        public List<CaixaSaidaDTO>? Caixas { get; set; }
    }
}
