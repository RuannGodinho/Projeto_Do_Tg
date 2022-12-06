using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Context
{
    public class AgendaContext : DbContext
    {

        public AgendaContext(DbContextOptions<AgendaContext> options ) : base(options)
        {

        }
        public DbSet<Contato> Contatos{get;set;}   
        public DbSet<Porta> Portas{get;set;}  
        public DbSet<Janela> Janelas{get;set;}
        public DbSet<Fechadura> Fechaduras{get;set;}
        public DbSet<Usuario> Usuario{get;set;}
        public DbSet<Carrinho> Carrinho{get;set;}
        public DbSet<Guarnicao> Guarnicao{get;set;}
        public DbSet<Outros> Outros{get;set;}
    }
}