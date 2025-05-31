using Application.DTOs;
using Application.Exception;
using Application.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class EmpacotamentoService : IEmpacotamentoService
    {
        private readonly List<Caixa> _caixasDisponiveis;
        private readonly IPedidoRepository _pedidoRepository;

        public EmpacotamentoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;

            _caixasDisponiveis = new List<Caixa>
            {
                new Caixa("Caixa 1", new Dimensao(10, 10, 10)),
                new Caixa("Caixa 2", new Dimensao(30, 30, 30)),
                new Caixa("Caixa 3", new Dimensao(50, 50, 50))
            };
        }

        public async Task<ResultadoEmpacotamentoDTO> EmpacotarAsync(PedidoEntradaWrapperDTO pedidosDto)
        {
            var resultado = new ResultadoEmpacotamentoDTO();

            foreach (var pedidoDto in pedidosDto.Pedidos!)
            {
                try
                {
                    var produtos = pedidoDto.Produtos!
                        .Select(p => new Produto(
                            p.ProdutoId!,
                            new Dimensao(p.Dimensoes!.Altura, p.Dimensoes.Largura, p.Dimensoes.Comprimento)))
                        .ToList();

                    var pedido = new Pedido(produtos);
                    var caixasResposta = new List<CaixaSaidaDTO>();

                    foreach (var produto in pedido.Produtos!)
                    {
                        var caixa = _caixasDisponiveis.FirstOrDefault(c => c.Comporta(produto));

                        if (caixa == null)
                        {
                            throw new ProdutoNaoComportaException(
                                $"Produto '{produto.ProdutoId}' com dimensões {produto.Dimensao!.Altura}x{produto.Dimensao.Largura}x{produto.Dimensao.Comprimento} excede as capacidades das caixas disponíveis.");
                        }

                        var caixaExistente = caixasResposta.FirstOrDefault(c => c.CaixaId == caixa.Nome);

                        if (caixaExistente == null)
                        {
                            caixasResposta.Add(new CaixaSaidaDTO
                            {
                                CaixaId = caixa.Nome,
                                Produtos = new List<string> { produto.ProdutoId }
                            });
                        }
                        else
                        {
                            caixaExistente.Produtos!.Add(produto.ProdutoId);
                        }
                    }
                    
                    await _pedidoRepository.SalvarPedidoAsync(pedido);
                    
                    resultado.PedidosProcessados.Add(new PedidoSaidaDTO
                    {
                        PedidoId = pedido.Id.ToString(),
                        Caixas = caixasResposta
                    });
                }
                catch (ProdutoNaoComportaException ex)
                {                   
                    resultado.PedidosNaoProcessados.Add($"Pedido {pedidoDto.PedidoId}: {ex.Message}");
                }
            }

            return resultado;
        }
    }
}
