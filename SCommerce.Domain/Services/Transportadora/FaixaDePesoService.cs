using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Transportadora
{
    public class FaixaDePesoService : ServiceBase<FaixaDePeso>, IFaixaDePesoService
    {
        public FaixaDePesoService(IRepositoryBase<FaixaDePeso> repository) : base(repository)
        {
        }
    }
}
