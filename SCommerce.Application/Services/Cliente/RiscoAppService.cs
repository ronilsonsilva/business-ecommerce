using SCommerce.Application.Interfaces.Cliente;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Repositories.Cliente;
using SCommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Cliente
{
    public class RiscoAppService : AppServiceBase<Risco>, IRiscoAppService
    {
        public RiscoAppService(IServiceBase<Risco> serviceBase) : base(serviceBase)
        {
        }
    }
}
