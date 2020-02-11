//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class ProdutoAtributoLojaMap : IEntityTypeConfiguration<ProdutoAtributoLoja>
//    {
//        public void Configure(EntityTypeBuilder<ProdutoAtributoLoja> builder)
//        {
//            builder.ToTable("ProdutoAtributoLoja");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.ProdutoAtributo).WithMany().HasForeignKey("IdProdutoAtributo");
//            builder.HasOne(x => x.Loja).WithMany().HasForeignKey("IdLoja");
//        }
//    }
//}
