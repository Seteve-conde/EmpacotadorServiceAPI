using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ResultadoEmpacotamentoDTO
    {
        //Aqui resolvi colocar exemplos de Semântica e Eficiência conforme a versão do C#
        public List<PedidoSaidaDTO> PedidosProcessados { get; set; } = []; //[]: mais novo, mais conciso, C# 12+.
        public List<string> PedidosNaoProcessados { get; set; } = new(); //new(): mais antigo, mais comum, C# 9+.
    }
}
