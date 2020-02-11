using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class LojaMap : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.ToTable("Loja");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasMany(x => x.ContatoLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.LojaDepartamentos).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.LojaImagens).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.CategoriaLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.ProdutoLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.Carrinhos).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.OCs).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.CMSLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.CMSRedeSocials).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.TransportadoraLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.FornecedorLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.FabricanteLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
            builder.HasMany(x => x.EmpregadoLojas).WithOne(x => x.Loja).HasForeignKey(x => x.IdLoja);
        }
    }
}
