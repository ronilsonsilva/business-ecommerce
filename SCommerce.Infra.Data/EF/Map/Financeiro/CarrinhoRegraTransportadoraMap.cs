//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraTransportadoraMap : IEntityTypeConfiguration<CarrinhoRegraTransportadora>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraTransportadora> builder)
//        {
//            builder.ToTable("CarrinhoRegraTransportadora");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.Transportadora).WithMany().HasForeignKey("TransportadoraId").IsRequired();
//        }
//    }
//}
