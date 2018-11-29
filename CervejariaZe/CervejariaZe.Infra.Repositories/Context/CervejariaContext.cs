using CervejariaZe.Domain.Entities;
using CervejariaZe.Infra.Repositories.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CervejariaZe.Infra.Repositories.Context
{
    public class CervejariaContext : DbContext
    {
        public CervejariaContext() : base("name=ConnCervejaria"){
            Database.SetInitializer<CervejariaContext>(null);
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}