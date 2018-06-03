using ControleChamadoSemRazor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleChamadoSemRazor.DAO
{
    public class ChamadoContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Chamado> Chamados { get; set; }

        //Mapeando a Chave Estrangeira Usuario
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chamado>().HasRequired(m => m.Usuario);
        }
    }
}