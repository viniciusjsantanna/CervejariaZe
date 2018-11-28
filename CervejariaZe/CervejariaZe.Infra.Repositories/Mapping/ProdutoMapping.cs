using CervejariaZe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CervejariaZe.Infra.Repositories.Mapping
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            this.ToTable("Produto");

            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nome).HasColumnName("Nome").IsRequired();
            this.Property(p => p.Marca).HasColumnName("Marca").IsRequired();
            this.Property(p => p.Tipo).HasColumnName("Tipo").IsRequired();
            this.Property(p => p.Codigo).HasColumnName("Codigo").IsRequired();
            this.Property(p => p.CaminhoImagem).HasColumnName("CaminhoImagem").IsRequired();

        }
    }
}