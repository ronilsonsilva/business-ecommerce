using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SCommerce.Web.Areas.Admin.ViewModels.FabricanteViewModels> FabricanteViewModels { get; set; }
    }
}
