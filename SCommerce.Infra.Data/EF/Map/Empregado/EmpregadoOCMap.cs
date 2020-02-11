using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Empregado
{
    public class EmpregadoOCMap : IEntityTypeConfiguration<EmpregadoOC>
    {
        public void Configure(EntityTypeBuilder<EmpregadoOC> builder)
        {
            builder.ToTable("EmpregadoOC");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Empregado).WithMany().HasForeignKey("IdEmpregado").IsRequired();
            builder.HasOne(x => x.OC).WithMany().HasForeignKey("IdOC").IsRequired();
        }
    }
}
