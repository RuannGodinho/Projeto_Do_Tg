using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MVC.Models
{
    public class Sessao
    {
        private readonly IHttpContextAccessor _HttpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _HttpContext = httpContext;
        }

        public Usuario buscarSessao()
        {
            string sessaoUser = _HttpContext.HttpContext.Session.GetString("sessaoUser");
            if(string.IsNullOrEmpty(sessaoUser)) return null;
            return JsonConvert.DeserializeObject<Usuario>(sessaoUser);
        }

        public void CriarSessaoUser(Usuario usuario)
        {
            var valorSessao = JsonConvert.SerializeObject(usuario);
            _HttpContext.HttpContext.Session.SetString("sessaoUser", valorSessao);
        }

        public void RemoverSessaoUser()
        {
            _HttpContext.HttpContext.Session.Remove("sessaoUser");
        }
    }
}