
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class FaixaDePesoMap : IEntityTypeConfiguration<FaixaDePeso>
    {
        public void Configure(EntityTypeBuilder<FaixaDePeso> builder)
        {
            builder.ToTable("FaixaDePeso");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.FaixaDePeso).HasForeignKey(x => x.IdTransportadora);
        }
    }
}
