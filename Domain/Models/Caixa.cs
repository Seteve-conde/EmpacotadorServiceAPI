namespace Domain.Models
{
    public class Caixa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public Dimensao? Dimensao { get; private set; }

        private Caixa() { }

        public Caixa(string nome, Dimensao dimensao)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Dimensao = dimensao ?? throw new ArgumentNullException(nameof(dimensao));
        }

        public bool Comporta(Produto produto)
        {
            return produto.Dimensao!.Altura <= Dimensao!.Altura &&
                   produto.Dimensao.Largura <= Dimensao!.Largura &&
                   produto.Dimensao.Comprimento <= Dimensao!.Comprimento;
        }
    }
}
