using CervejariaZe.Domain.Entities;
using CervejariaZe.Infra.Repositories.Mapping;
using System.Data.Entity;

namespace CervejariaZe.Infra.Repositories.Context
{
    public class CervejariaContext : DbContext
    {
        public CervejariaContext() : base("name=ConnCervejaria")
        {
            Database.SetInitializer<CervejariaContext>(null);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adicionando Mapeamento das entidades ao contexto
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}