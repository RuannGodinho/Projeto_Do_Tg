using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Context;

namespace Projeto_MVC_TG.Controllers
{
    public class AdminController : Controller
    {
        private readonly AgendaContext _context;

        public AdminController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fechadura()
        {
            var Itens = _context.Fechaduras.ToList();
            return View(Itens);
        }

        public IActionResult Janela()
        {
            var Itens = _context.Janelas.ToList();
            return View(Itens);
        }

        public IActionResult Porta()
        {
            var Itens = _context.Portas.ToList();
            return View(Itens);
        }

        public IActionResult AdicionarPorta()
        {
            return View();
        }

        public IActionResult EditarPorta()
        {
            return View();
        }

        public IActionResult AdicionarFechadura()
        {
            return View();
        }

        public IActionResult AdicionarJanela()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}