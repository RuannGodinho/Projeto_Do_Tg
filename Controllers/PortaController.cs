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

        public IActionResult Index()
        {
            var portas = _context.Portas.ToList();
            return View(portas);
        }
    }
}