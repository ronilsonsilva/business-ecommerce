//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class CategoriaGrupoMap : IEntityTypeConfiguration<CategoriaGrupo>
//    {
//        public void Configure(EntityTypeBuilder<CategoriaGrupo> builder)
//        {
//            builder.ToTable("CategoriaGrupo");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Grupo).WithMany().HasForeignKey("IdGrupo");
//            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey("IdCategoria");
//        }
//    }
//}
