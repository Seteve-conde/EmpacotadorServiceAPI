using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmpacotadorServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IEmpacotamentoService _empacotamentoService;

        public PedidosController(IEmpacotamentoService empacotamentoService)
        {
            _empacotamentoService = empacotamentoService;
        }

        [HttpPost("embalar")]
        [Authorize]
        public async Task<IActionResult> Embalar([FromBody] PedidoEntradaWrapperDTO pedidosWrapper)
        {
            try
            {
                var resultado = await _empacotamentoService.EmpacotarAsync(pedidosWrapper);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro interno no servidor.", detail = ex.Message });
            }
        }
    }
}
