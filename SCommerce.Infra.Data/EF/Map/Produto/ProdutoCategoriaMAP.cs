//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class ProdutoCategoriaMAP : IEntityTypeConfiguration<ProdutoCategoria>
//    {
//        public void Configure(EntityTypeBuilder<ProdutoCategoria> builder)
//        {
//            builder.ToTable("ProdutoCategoria");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Categoria).WithMany(x => x.ProdutoCategorias).HasForeignKey(x => x.IdCategoria);
//            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoCategorias).HasForeignKey(x => x.IdProduto);
//        }
//    }
//}
