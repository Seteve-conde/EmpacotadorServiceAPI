namespace Domain.Models
{
    public class Dimensao
    {
        public int Id { get; private set; }
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }

        private Dimensao() { }

        public Dimensao(double altura, double largura, double comprimento)
        {
            if (altura <= 0 || largura <= 0 || comprimento <= 0)
                throw new ArgumentException("Todas as dimensões devem ser maiores que zero.");

            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
    }
}
