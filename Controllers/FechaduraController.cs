using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class FechaduraController : Controller
    {
        private readonly AgendaContext _context;

        public FechaduraController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var fechaduras = _context.Fechaduras.ToList();

            return View(fechaduras);
        }

        public IActionResult AdicionarFechadura(Fechadura fechadura)
        {
            if(ModelState.IsValid)
            {
                _context.Fechaduras.Add(fechadura);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        public IActionResult EditarFechadura(Fechadura fechadura)
        {
            var fechaduraBanco = _context.Fechaduras.Find(fechadura.Id);

            fechaduraBanco.Nome = fechadura.Nome;
            fechaduraBanco.Descricao = fechadura.Descricao;
            fechaduraBanco.Quantidade = fechadura.Quantidade;
            fechaduraBanco.Valor = fechadura.Valor;

            _context.Fechaduras.Update(fechaduraBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Excluir(int Id)
        {
            var fechaduraBanco = _context.Fechaduras.Find(Id);

            _context.Fechaduras.Remove(fechaduraBanco);
            _context.SaveChanges();

            return RedirectToAction("Fechadura", "Admin");
        }

    }
}