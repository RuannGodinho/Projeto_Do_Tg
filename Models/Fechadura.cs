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
        public int Acabamento { get; set; }
        public string TipoComodo { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public bool EmCarrinho { get; set; }
    }
}