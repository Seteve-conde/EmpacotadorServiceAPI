using System.Text.Json.Serialization;

namespace Application.DTOs
{
    public class CaixaSaidaDTO
    {
        [JsonPropertyName("caixa_id")]
        public string CaixaId { get; set; } = string.Empty;

        public List<string>? Produtos { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Observacao { get; set; } = string.Empty;
    }
}
