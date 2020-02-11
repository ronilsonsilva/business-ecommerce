using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Empregado
{
    public class EmpregadoLojaMap : IEntityTypeConfiguration<EmpregadoLoja>
    {
        public void Configure(EntityTypeBuilder<EmpregadoLoja> builder)
        {
            builder.ToTable("EmpregadoLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Empregado).WithMany().HasForeignKey("IdEmpregado").IsRequired();
            builder.HasOne(x => x.Loja).WithMany().HasForeignKey("IdLoja").IsRequired();
        }
    }
}
