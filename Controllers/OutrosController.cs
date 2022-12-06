using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class OutrosController : Controller
    {
        private readonly AgendaContext _context;

        public OutrosController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var outros = _context.Outros.ToList();
            return View(outros);
        }
    }
}