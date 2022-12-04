using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Porta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Medida { get; set; }
        public string Cor { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public bool EmCarrinho  { get; set; }
        public string UrlFoto { get; set;}

    }
}