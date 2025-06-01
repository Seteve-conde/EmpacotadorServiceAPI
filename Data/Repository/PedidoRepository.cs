using Domain.Models;
using Application.Interfaces;


namespace Data.Repository
{
    //Aqui mais um recurso do C# 12 o Primary Constructor
    public class PedidoRepository(EmpacotamentoDbContext context) : IPedidoRepository
    {
        private readonly EmpacotamentoDbContext _context = context;

        public async Task SalvarPedidoAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
