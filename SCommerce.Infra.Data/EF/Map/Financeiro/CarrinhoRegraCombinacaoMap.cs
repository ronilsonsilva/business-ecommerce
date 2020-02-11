//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraCombinacaoMap : IEntityTypeConfiguration<CarrinhoRegraCombinacao>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraCombinacao> builder)
//        {
//            builder.ToTable("CarrinhoRegraCombinacao");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra1).WithMany().HasForeignKey("CarrinhoRegra1Id").IsRequired();
//            builder.HasOne(x => x.CarrinhoRegra2).WithMany().HasForeignKey("CarrinhoRegra2Id").IsRequired();
//        }
//    }
//}
