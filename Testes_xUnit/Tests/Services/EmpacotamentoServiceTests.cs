using Xunit;
using Moq;
using Application.Services;
using Application.Interfaces;
using Application.DTOs;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Testes_xUnit.Tests.Services
{
    public class EmpacotamentoServiceTests
    {
        private readonly EmpacotamentoService _service;
        private readonly Mock<IPedidoRepository> _mockRepository;
        private readonly ITestOutputHelper _output;

        public EmpacotamentoServiceTests(ITestOutputHelper output)
        {
            _mockRepository = new Mock<IPedidoRepository>();
            _service = new EmpacotamentoService(_mockRepository.Object);
            _output = output;
        }

        [Fact]
        public async Task Empacotar_DeveEmpacotarPedidoComSucesso()
        {            
            var pedidoDto = new PedidoEntradaDTO
            {
                PedidoId = 123,
                Produtos = new List<ProdutoEntradaDTO>
                {
                    new ProdutoEntradaDTO
                    {
                        ProdutoId = "Produto1",
                        Dimensoes = new DimensoesDTO { Altura = 5, Largura = 5, Comprimento = 5 }
                    }
                }
            };

            var pedidosDto = new PedidoEntradaWrapperDTO
            {
                Pedidos = new List<PedidoEntradaDTO> { pedidoDto }
            };
         
            var resultado = await _service.Empacotar(pedidosDto);
            
            _output.WriteLine("Pedidos processados: " + resultado.PedidosProcessados.Count);
            _output.WriteLine("Pedidos não processados: " + resultado.PedidosNaoProcessados.Count);

            foreach (var proc in resultado.PedidosProcessados)
            {
                _output.WriteLine($"Pedido {proc.PedidoId} embalado em {proc.Caixas!.Count} caixa(s):");
                foreach (var box in proc.Caixas)
                {
                    _output.WriteLine($"- {box.CaixaId} com {box.Produtos!.Count} produto(s): {string.Join(", ", box.Produtos)}");
                }
            }

            foreach (var erro in resultado.PedidosNaoProcessados)
            {
                _output.WriteLine("Erro: " + erro);
            }
            
            Assert.Single(resultado.PedidosProcessados);
            Assert.Empty(resultado.PedidosNaoProcessados);

            var pedidoProcessado = resultado.PedidosProcessados[0];
            Assert.False(string.IsNullOrEmpty(pedidoProcessado.PedidoId));
            Assert.Single(pedidoProcessado.Caixas!);

            var caixa = pedidoProcessado.Caixas![0];
            Assert.Equal("Caixa 1", caixa.CaixaId);
            Assert.Single(caixa.Produtos!);
            Assert.Contains("Produto1", caixa.Produtos!);
        }
    }
}
