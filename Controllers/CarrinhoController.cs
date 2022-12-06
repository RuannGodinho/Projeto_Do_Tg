using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Context;
using Microsoft.Extensions.Logging;

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
            var Itens = _context.Carrinho.ToList();
            return View(Itens);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Carrinho carrinho)
        {
            if(ModelState.IsValid)
            {
                _context.Carrinho.Add(carrinho);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(carrinho);
        }

        public IActionResult Editar(long id)
        {
            var carrinho = _context.Carrinho.Find(id);

            if(carrinho == null)
                return RedirectToAction(nameof(Index));
            
            return View(carrinho);
        }

        [HttpPost]
        public IActionResult Alterar(Carrinho carrinho)
        {
            var carrinhoBanco = _context.Carrinho.Find(carrinho.Id);

            carrinhoBanco.nomePedido = carrinho.nomePedido;
            carrinhoBanco.descricao = carrinho.descricao;
            carrinhoBanco.qtdPedido = carrinho.qtdPedido;
            carrinhoBanco.precoPedido = carrinho.precoPedido;

            _context.Carrinho.Update(carrinhoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Cancelar(long id)
        {
            var carrinho = _context.Carrinho.Find(id);

            if(carrinho == null)
                return RedirectToAction(nameof(Index));
            
            return View(carrinho);
        }

        [HttpPost]
        public IActionResult Deletar(long id)
        {
            var carrinhoBanco = _context.Carrinho.Find(id);

            _context.Carrinho.Remove(carrinhoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}