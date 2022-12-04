using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Digite o Login")]
        public string email {get; set;}
        [Required(ErrorMessage = "Digite a senha")]
        public string senha {get; set;}
    }
}