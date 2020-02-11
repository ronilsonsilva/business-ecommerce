using SCommerce.Application.Interfaces.Cliente;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Cliente
{
    public class ClienteAppService : AppServiceBase<Domain.Entities.Cliente.Cliente>, IClienteAppService
    {
        public ClienteAppService(Domain.Interfaces.Services.IServiceBase<Domain.Entities.Cliente.Cliente> serviceBase) : base(serviceBase)
        {
        }
    }
}
