using System;

namespace Application.Exception
{
    public class ProdutoNaoComportaException : System.Exception
    {
        public ProdutoNaoComportaException(string message) : base(message)
        {
        }
    }
}
