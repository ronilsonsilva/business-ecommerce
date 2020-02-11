using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Empregado
{
    public class AcessoMap : IEntityTypeConfiguration<Acesso>
    {
        public void Configure(EntityTypeBuilder<Acesso> builder)
        {
            builder.ToTable("Acesso");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Modulo).WithMany(x => x.Acessos).HasForeignKey(x => x.IdModulo);
            builder.HasOne(x => x.Perfil).WithMany().HasForeignKey("IdPerfil").IsRequired();
            builder.Property(x => x.Nome).IsRequired();
        }
    }
}
