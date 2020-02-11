using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class TransportadoraLojaMap : IEntityTypeConfiguration<TransportadoraLoja>
    {
        public void Configure(EntityTypeBuilder<TransportadoraLoja> builder)
        {
            builder.ToTable("TransportadoraLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.TransportadoraLoja).HasForeignKey(x => x.IdTransportadora);
            builder.HasOne(x => x.Loja).WithMany(x => x.TransportadoraLojas).HasForeignKey(x => x.IdLoja);
        }
    }
}
