//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraProdutoRegraMap : IEntityTypeConfiguration<CarrinhoRegraProdutoRegra>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraProdutoRegra> builder)
//        {
//            builder.ToTable("CarrinhoRegraProdutoRegra");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.ProdutoRegra).WithMany().HasForeignKey("ProdutoRegraId").IsRequired();
//        }
//    }
//}
