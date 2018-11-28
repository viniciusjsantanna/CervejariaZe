using CervejariaZe.Infra.Repositories.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CervejariaZe.Infra.Repositories.Context
{
    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {
            Database.SetInitializer<Context>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}