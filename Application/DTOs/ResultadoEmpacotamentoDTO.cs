using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ResultadoEmpacotamentoDTO
    {
        public List<PedidoSaidaDTO> PedidosProcessados { get; set; } = new();
        public List<string> PedidosNaoProcessados { get; set; } = new();
    }
}
