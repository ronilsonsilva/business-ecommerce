//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class ProdutoAtributoImagemMap : IEntityTypeConfiguration<ProdutoAtributoImagem>
//    {
//        public void Configure(EntityTypeBuilder<ProdutoAtributoImagem> builder)
//        {
//            builder.ToTable("ProdutoAtributoImagem");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.ProdutoAtributo).WithMany().HasForeignKey("IdProdutoAtributo");
//        }
//    }
//}
