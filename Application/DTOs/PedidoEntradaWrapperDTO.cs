using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class PedidoEntradaWrapperDTO
    {
        [Required]
        public List<PedidoEntradaDTO>? Pedidos { get; set; }
    }
}
