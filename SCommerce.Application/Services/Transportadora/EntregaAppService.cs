using SCommerce.Application.Interfaces.Transportadora;
using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Transportadora
{
    public class EntregaAppService : AppServiceBase<Entrega>, IEntregaAppService
    {
        public EntregaAppService(IServiceBase<Entrega> serviceBase) : base(serviceBase)
        {
        }
    }
}
