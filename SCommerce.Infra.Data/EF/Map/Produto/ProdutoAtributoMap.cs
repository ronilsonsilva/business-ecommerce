//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Produto;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Produto
//{
//    public class ProdutoAtributoMap : IEntityTypeConfiguration<ProdutoAtributo>
//    {
//        public void Configure(EntityTypeBuilder<ProdutoAtributo> builder)
//        {
//            builder.ToTable("ProdutoAtributo");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Produto).WithMany().HasForeignKey("IdProduto");
//        }
//    }
//}
