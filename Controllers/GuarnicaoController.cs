using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class GuarnicaoController : Controller
    {
        private readonly AgendaContext _context;

        public GuarnicaoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var guarnicoes = _context.Guarnicao.ToList();
            return View(guarnicoes);
        }
    }
}