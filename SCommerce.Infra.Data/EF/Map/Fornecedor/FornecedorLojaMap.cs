using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fornecedor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fornecedor
{
    public class FornecedorLojaMap : IEntityTypeConfiguration<FornecedorLoja>
    {
        public void Configure(EntityTypeBuilder<FornecedorLoja> builder)
        {
            builder.ToTable("FornecedorLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Fornecedor).WithMany(x => x.FornecedorLoja).HasForeignKey(x => x.IdFornecedor);
            builder.HasOne(x => x.Loja).WithMany(x => x.FornecedorLojas).HasForeignKey(x => x.IdLoja);
        }
    }
}
