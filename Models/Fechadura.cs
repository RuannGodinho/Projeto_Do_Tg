using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Fechadura
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Medida { get; set; }
        public string Cor {get; set;}
        public string TipoComodo { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string UrlFoto { get; set;}
    }
}