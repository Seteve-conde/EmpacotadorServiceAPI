using Application.DTOs;

namespace Application.Interfaces
{
    public interface IEmpacotamentoService
    {
        Task<ResultadoEmpacotamentoDTO> Empacotar(PedidoEntradaWrapperDTO pedidosDto);
    }
}
