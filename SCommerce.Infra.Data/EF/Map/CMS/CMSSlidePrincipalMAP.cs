using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CMS
{
    public class CMSSlidePrincipalMAP : IEntityTypeConfiguration<CMSSlidePrincipal>
    {
        public void Configure(EntityTypeBuilder<CMSSlidePrincipal> builder)
        {
            builder.ToTable("CMSSlidePrincipal");
            builder.HasKey(x => x.ID);
        }
    }
}
