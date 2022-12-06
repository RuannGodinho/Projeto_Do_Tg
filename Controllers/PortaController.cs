using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class PortaController : Controller
    {
        private readonly AgendaContext _context;

        public PortaController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarPorta(Porta porta)
        {
            if(ModelState.IsValid)
            {
                _context.Portas.Add(porta);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Editar(long id)
        {
            var porta = _context.Portas.Find(id);

            if(porta == null)
                return RedirectToAction(nameof(Index));
            
            return View(porta);
        }

        [HttpPost]
        public IActionResult EditarPorta(Porta porta)
        {
            var portaBanco = _context.Portas.Find(porta.Id);

            portaBanco.Nome = porta.Nome;
            portaBanco.Descricao = porta.Descricao;
            portaBanco.Quantidade = porta.Quantidade;
            portaBanco.Preco = porta.Preco;

            _context.Portas.Update(portaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Excluir(int Id)
        {
            var portaBanco = _context.Portas.Find(Id);

            _context.Portas.Remove(portaBanco);
            _context.SaveChanges();

            return RedirectToAction("Fechadura", "Admin");
        }
        public IActionResult Index()
        {
            var portas = _context.Portas.ToList();
            return View(portas);
        }
    }
}