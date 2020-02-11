using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fabricante
{
    public class FabricanteProdutoMap : IEntityTypeConfiguration<FabricanteProduto>
    {
        public void Configure(EntityTypeBuilder<FabricanteProduto> builder)
        {
            builder.ToTable("FabricanteProduto");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Fabricante).WithMany(x => x.FabricanteProduto).HasForeignKey(x => x.IdFabricante);
            builder.HasOne(x => x.Produto).WithMany(x => x.FabricanteProdutos).HasForeignKey(x => x.IdProduto);
        }
    }
}
