//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class ProdutoAtributoCombinacaoMap : IEntityTypeConfiguration<ProdutoAtributoCombinacao>
//    {
//        public void Configure(EntityTypeBuilder<ProdutoAtributoCombinacao> builder)
//        {
//            builder.ToTable("ProdutoAtributoCombinacao");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.ProdutoAtributo).WithMany().HasForeignKey("IdProdutoAtributo");
//            builder.HasOne(x => x.Atributo).WithMany().HasForeignKey("IdAtributo");
//        }
//    }
//}
