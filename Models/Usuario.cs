using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Usuario
    {
        public Nullable<long> Id {get; set;}
        public string nome {get; set;}
        public string email {get; set;}
        public string endereco {get; set;}
        public string senha {get; set;}
        public bool? eAdmin {get;set;}
    }
}