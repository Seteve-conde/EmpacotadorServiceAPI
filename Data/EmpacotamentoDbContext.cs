using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EmpacotamentoDbContext : DbContext
    {
        public EmpacotamentoDbContext(DbContextOptions<EmpacotamentoDbContext> options)
            : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Caixa> Caixas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }
    }
}
