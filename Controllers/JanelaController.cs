using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class JanelaController : Controller
    {

        private readonly AgendaContext _context;

        public JanelaController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var janelas = _context.Janelas.ToList();

            return View(janelas);
        }
        
    }
}