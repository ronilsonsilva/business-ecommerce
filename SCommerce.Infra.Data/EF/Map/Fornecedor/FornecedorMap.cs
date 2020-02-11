using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fornecedor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fornecedor
{
    public class FornecedorMap : IEntityTypeConfiguration<Domain.Entities.Fornecedor.Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Fornecedor.Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.FabricanteFornecedors).WithOne(x => x.Fornecedor).HasForeignKey(x => x.IdFornecedor);
            builder.HasMany(x => x.FornecedorLoja).WithOne(x => x.Fornecedor).HasForeignKey(x => x.IdFornecedor);
            builder.HasMany(x => x.ProdutoFornecedors).WithOne(x => x.Fornecedor).HasForeignKey(x => x.IdFornecedor);
        }
    }
}
