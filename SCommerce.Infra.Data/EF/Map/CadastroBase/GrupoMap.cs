using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupo");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasMany(x => x.ProdutoGrupos).WithOne(x => x.Grupo).HasForeignKey(x => x.IdGrupo);
        }
    }
}
