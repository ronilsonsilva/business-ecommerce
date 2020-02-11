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
    public class TransportadoraGrupoAppService : AppServiceBase<TransportadoraGrupo>, ITransportadoraGrupoAppService
    {
        public TransportadoraGrupoAppService(IServiceBase<TransportadoraGrupo> serviceBase) : base(serviceBase)
        {
        }
    }
}
