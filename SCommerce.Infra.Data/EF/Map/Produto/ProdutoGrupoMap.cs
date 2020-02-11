using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoGrupoMap : IEntityTypeConfiguration<ProdutoGrupo>
    {
        public void Configure(EntityTypeBuilder<ProdutoGrupo> builder)
        {
            builder.ToTable("ProdutoGrupo");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoGrupos).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.Grupo).WithMany(x => x.ProdutoGrupos).HasForeignKey(x => x.IdProduto);
        }
    }
}
