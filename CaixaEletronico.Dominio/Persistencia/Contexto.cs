using CaixaEletronico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Dominio.Persistencia
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }




    }
}
