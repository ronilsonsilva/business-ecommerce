using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class TransportadoraEnderecoMap : IEntityTypeConfiguration<TransportadoraEndereco>
    {
        public void Configure(EntityTypeBuilder<TransportadoraEndereco> builder)
        {
            builder.ToTable("TransportadoraEndereco");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.TransportadoraEndereco).HasForeignKey(x => x.IdTranportadora);
            builder.HasOne(x => x.Endereco).WithMany(x => x.TransportadoraEnderecos).HasForeignKey(x => x.IdEndereco);
        }
    }
}
