//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class CustomizacaoProdutoMap : IEntityTypeConfiguration<CustomizacaoProduto>
//    {
//        public void Configure(EntityTypeBuilder<CustomizacaoProduto> builder)
//        {
//            builder.ToTable("CustomizacaoProduto");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Customizacao).WithMany().HasForeignKey("IdCustomizacao");
//            builder.HasOne(x => x.Produto).WithMany().HasForeignKey("IdProduto").IsRequired();
//        }
//    }
//}
