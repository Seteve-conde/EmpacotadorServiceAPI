using Domain.Models;
using Application.Interfaces;


namespace Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EmpacotamentoDbContext _context;

        public PedidoRepository(EmpacotamentoDbContext context)
        {
            _context = context;
        }

        public async Task SalvarPedidoAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
