namespace Domain.Models
{
    public class Produto
    {
        public string ProdutoId { get; private set; } = string.Empty;
        public Dimensao? Dimensao { get; private set; }

        private Produto() { }

        public Produto(string produtoId, Dimensao dimensao)
        {
            ProdutoId = produtoId;
            Dimensao = dimensao;
        }
    }
}
