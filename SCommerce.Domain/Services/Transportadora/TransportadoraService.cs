using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Transportadora
{
    public class TransportadoraService : ServiceBase<Entities.Transportadora.Transportadora>, ITransportadoraService
    {
        public TransportadoraService(IRepositoryBase<Entities.Transportadora.Transportadora> repository) : base(repository)
        {
        }
    }
}
