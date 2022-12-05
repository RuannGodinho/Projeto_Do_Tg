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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}