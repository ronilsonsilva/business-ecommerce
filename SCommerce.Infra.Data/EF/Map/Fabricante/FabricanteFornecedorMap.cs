using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fabricante
{
    public class FabricanteFornecedorMap : IEntityTypeConfiguration<FabricanteFornecedor>
    {
        public void Configure(EntityTypeBuilder<FabricanteFornecedor> builder)
        {
            builder.ToTable("FabricanteFornecedor");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Fabricante).WithMany(x => x.FabricanteFornecedor).HasForeignKey(x => x.IdFabricante);
            builder.HasOne(x => x.Fornecedor).WithMany(x => x.FabricanteFornecedors).HasForeignKey(x => x.IdFornecedor);
        }
    }
}
