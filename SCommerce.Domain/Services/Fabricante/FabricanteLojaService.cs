using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Fabricante
{
    public class FabricanteLojaService : ServiceBase<FabricanteLoja>, IFabricanteLojaService
    {
        public FabricanteLojaService(IRepositoryBase<FabricanteLoja> repository) : base(repository)
        {
        }
    }
}
