using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Projeto_Do_Tg.Views.Admin
{
    public class Porta : PageModel
    {
        private readonly ILogger<Porta> _logger;

        public Porta(ILogger<Porta> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}