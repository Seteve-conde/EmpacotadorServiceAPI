namespace Domain.Models
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public List<Produto>? Produtos { get; private set; }

        private Pedido() { }

        public Pedido(List<Produto> produtos)
        {
            Id = Guid.NewGuid();
            Produtos = produtos ?? throw new ArgumentNullException(nameof(produtos));
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
                throw new ArgumentNullException(nameof(produto));

            Produtos!.Add(produto);
        }
    }
}



