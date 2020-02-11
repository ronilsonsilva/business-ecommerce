using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Fabricante
{
    public class FabricanteService : ServiceBase<Entities.Fabricante.Fabricante>, IFabricanteService
    {
        public FabricanteService(IRepositoryBase<Entities.Fabricante.Fabricante> repository) : base(repository)
        {
        }
    }
}
