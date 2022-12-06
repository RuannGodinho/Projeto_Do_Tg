using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Guarnicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public string Cor {get; set;}
        public string TipoAcabamento { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string UrlFoto { get; set;}
    }
}