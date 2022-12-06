using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projeto_MVC_TG.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fechadura()
        {
            return View();
        }

        public IActionResult Janela()
        {
            return View();
        }

        public IActionResult Porta()
        {
            return View();
        }

        public IActionResult AdicionarPorta()
        {
            return View();
        }

        public IActionResult EditarPorta()
        {
            return View();
        }

        public IActionResult ExcluirPorta()
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