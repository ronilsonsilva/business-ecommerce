//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class GeneroMap : IEntityTypeConfiguration<Genero>
//    {
//        public void Configure(EntityTypeBuilder<Genero> builder)
//        {
//            builder.ToTable("Genero");
//            builder.HasKey(x => x.ID);
//            builder.Property(x => x.Nome).IsRequired();
//        }
//    }
//}
