//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraProdutoRegraGrupoMap : IEntityTypeConfiguration<CarrinhoRegraProdutoRegraGrupo>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraProdutoRegraGrupo> builder)
//        {
//            builder.ToTable("CarrinhoRegraProdutoRegraGrupo");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.ProdutoRegraGrupo).WithMany().HasForeignKey("ProdutoRegraGrupoId").IsRequired();
//        }
//    }
//}
