using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Empregado
{
    public class EmpregadoEnderecoMap : IEntityTypeConfiguration<EmpregadoEndereco>
    {
        public void Configure(EntityTypeBuilder<EmpregadoEndereco> builder)
        {
            builder.ToTable("EmpregadoEndereco");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Empregado).WithMany().HasForeignKey("IdEmpregado").IsRequired();
            builder.HasOne(x => x.Endereco).WithMany().HasForeignKey("IdEndereco").IsRequired();
        }
    }
}
