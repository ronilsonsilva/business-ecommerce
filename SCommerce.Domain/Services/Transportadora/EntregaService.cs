using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Transportadora
{
    public class EntregaService : ServiceBase<Entrega>, IEntregaService
    {
        public EntregaService(IRepositoryBase<Entrega> repository) : base(repository)
        {
        }
    }
}
