using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using MVC.Models;
using MVC.Context;

namespace MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AgendaContext _context;

        public UsuarioController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Entrar(Login login)
        {
            if(ModelState.IsValid)
            {
                login.email = login.email.ToUpper();
                var user = _context.Usuario.Where(_ => _.email == login.email && _.senha == login.senha).FirstOrDefault();
                if(user != null)
                {
                    return RedirectToAction("Index","Home");
                }
                TempData["MensagemErro"] = $"Usuário e/ou senha inválido";
            }
            return View("Index");
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                usuario.email = usuario.email.ToUpper();
                usuario.nome  = usuario.nome.ToUpper();
                usuario.endereco = usuario.endereco.ToUpper();
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}