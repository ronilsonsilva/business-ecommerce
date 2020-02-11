using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class LojaDepartamentoMap : IEntityTypeConfiguration<LojaDepartamento>
    {
        public void Configure(EntityTypeBuilder<LojaDepartamento> builder)
        {
            builder.ToTable("LojaDepartamento");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Departamento).WithMany(x => x.LojaDepartamentos).HasForeignKey(x => x.IdDepartamento);
            builder.HasOne(x => x.Loja).WithMany(x => x.LojaDepartamentos).HasForeignKey(x => x.IdLoja);
        }
    }
}
