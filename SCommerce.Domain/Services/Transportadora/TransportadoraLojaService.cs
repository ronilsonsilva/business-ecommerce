using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Transportadora
{
    public class TransportadoraLojaService : ServiceBase<TransportadoraLoja>, ITransportadoraLojaService
    {
        public TransportadoraLojaService(IRepositoryBase<TransportadoraLoja> repository) : base(repository)
        {
        }
    }
}
