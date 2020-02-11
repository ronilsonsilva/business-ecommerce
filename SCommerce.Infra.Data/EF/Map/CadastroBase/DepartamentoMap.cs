using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class DepartamentoMap : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasMany(x => x.LojaDepartamentos).WithOne(x => x.Departamento).HasForeignKey(x => x.IdDepartamento);
        }
    }
}
