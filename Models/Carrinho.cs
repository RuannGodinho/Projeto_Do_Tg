using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Carrinho
    {
        public Nullable<long> Id {get; set;}
        public string nomePedido {get; set;}
        public string descricao {get; set;}
        public int qtdPedido {get; set;}
        public double precoPedido {get; set;}
        public long idUsuario {get; set;}
    }
}