using CervejariaZe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CervejariaZe.Infra.Repositories.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            this.ToTable("Usuario");

            this.HasKey(u => u.Id);
            this.Property(u => u.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(u => u.Login).HasColumnName("Usuario").IsRequired();
            this.Property(u => u.Senha).HasColumnName("Senha").IsRequired();
            this.Property(u => u.Nome).HasColumnName("Nome").IsRequired();
        }
    }
}