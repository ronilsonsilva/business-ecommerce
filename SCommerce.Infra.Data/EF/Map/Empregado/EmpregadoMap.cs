using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Empregado
{
    public class EmpregadoMap : IEntityTypeConfiguration<Domain.Entities.Empregado.Empregado>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Empregado.Empregado> builder)
        {
            builder.ToTable("Empregado");
            builder.HasKey(x => x.ID);
            //builder.HasOne(x => x.EmpregadoEndereco).WithMany().HasForeignKey("IdEmpregadoEndereco").IsRequired();
            //builder.HasOne(x => x.EmpregadoOC).WithMany().HasForeignKey("IdEmpregadoOC").IsRequired();
            //builder.HasOne(x => x.EmpregadoLoja).WithMany().HasForeignKey("IdEmpregadoLoja");
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Senha).IsRequired();
            builder.Property(x => x.Usuario).IsRequired();
        }
    }
}
