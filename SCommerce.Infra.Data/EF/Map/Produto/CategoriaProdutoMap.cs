//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class CategoriaProdutoMap : IEntityTypeConfiguration<CategoriaProduto>
//    {
//        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
//        {
//            builder.ToTable("CategoriaProduto");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Categoria).WithMany(x => x.CategoriaProdutos).HasForeignKey(x=>x.IdCategoria);
//            builder.HasOne(x => x.Produto).WithMany(x => x.Ca).HasForeignKey();
//        }
//    }
//}
