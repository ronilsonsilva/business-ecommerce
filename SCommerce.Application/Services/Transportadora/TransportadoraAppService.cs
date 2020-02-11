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
    public class TransportadoraAppService : AppServiceBase<Domain.Entities.Transportadora.Transportadora>, ITransportadoraAppService
    {
        public TransportadoraAppService(IServiceBase<Domain.Entities.Transportadora.Transportadora> serviceBase) : base(serviceBase)
        {
        }
    }
}
