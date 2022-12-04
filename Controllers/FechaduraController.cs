using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Context;

namespace MVC.Controllers
{
    [Route("[controller]")]
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

    }
}