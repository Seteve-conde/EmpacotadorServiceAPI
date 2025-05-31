using Domain.Models;

namespace Application.Interfaces
{
    public interface IPedidoRepository
    {
        Task SalvarPedidoAsync(Pedido pedido);
    }
}
