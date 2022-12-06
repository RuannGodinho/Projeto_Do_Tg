using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Context;
using Projeto_Do_Tg.Enums;

namespace MVC.Controllers
{    public class CarrinhoController : Controller
    {
        private readonly AgendaContext _context;

        public CarrinhoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Carrinho.ToList();

            if(result.Count > 0)
                return View(result);

            return View();
        }

        public IActionResult SalvarNoCarrinho(int idProduto, int tipoTabela, int qtdProdutos)
        {
            if(tipoTabela == (int)ETipoTabela.Porta)
            {
                var porta = _context.Portas.Where(_ => _.Id == idProduto).FirstOrDefault();

                var carrinho = new Models.Carrinho{
                    nomePedido = porta.Nome,
                    descricao = porta.Descricao,
                    qtdPedido = qtdProdutos,
                    precoPedido = porta.Valor,
                    idUsuario = 232
                };

                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            if(tipoTabela == (int)ETipoTabela.Guarnicao)
            {
                var guarnicao = _context.Guarnicao.Where(_ => _.Id == idProduto).FirstOrDefault();

                var carrinho = new Models.Carrinho{
                    nomePedido = guarnicao.Nome,
                    descricao = guarnicao.Descricao,
                    qtdPedido = qtdProdutos,
                    precoPedido = guarnicao.Preco,
                    idUsuario = 232
                };

                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            if(tipoTabela == (int)ETipoTabela.Janela)
            {
                var janela = _context.Janelas.Where(_ => _.Id == idProduto).FirstOrDefault();

                var carrinho = new Models.Carrinho{
                    nomePedido = janela.Nome,
                    descricao = janela.Descricao,
                    qtdPedido = qtdProdutos,
                    precoPedido = janela.Valor,
                    idUsuario = 232
                };

                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            if(tipoTabela == (int)ETipoTabela.Fechadura)
            {
                var fechadura = _context.Fechaduras.Where(_ => _.Id == idProduto).FirstOrDefault();

                var carrinho = new Models.Carrinho{
                    nomePedido = fechadura.Nome,
                    descricao = fechadura.Descricao,
                    qtdPedido = qtdProdutos,
                    precoPedido = fechadura.Valor,
                    idUsuario = 232
                };

                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            if(tipoTabela == (int)ETipoTabela.Outros)
            {
                var outros = _context.Outros.Where(_ => _.Id == idProduto).FirstOrDefault();

                var carrinho = new Models.Carrinho{
                    nomePedido = outros.Nome,
                    descricao = outros.Descricao,
                    qtdPedido = qtdProdutos,
                    precoPedido = outros.Valor,
                    idUsuario = 232
                };

                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            

            return View();
        }

        public IActionResult Deletar(int idProduto)
        {
            var carrinho = _context.Carrinho.Where(_ => _.Id == idProduto);

            if(carrinho != null)
            {
                _context.Carrinho.RemoveRange(carrinho);
                _context.SaveChanges();
            }

            else
                throw new InvalidOperationException("Não foi possivel deletar o produto");
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Comprar(int totalPagar)
        {
            var pedido = new Models.Carrinho{
                qtdPedido = totalPagar
            };

            return View(pedido);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}