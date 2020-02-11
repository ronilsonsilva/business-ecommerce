//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraLojaMap : IEntityTypeConfiguration<CarrinhoRegraLoja>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraLoja> builder)
//        {
//            builder.ToTable("CarrinhoRegraLoja");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.Loja).WithMany().HasForeignKey("LojaId").IsRequired();
//        }
//    }
//}
