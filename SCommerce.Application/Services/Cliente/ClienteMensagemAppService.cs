using SCommerce.Application.Interfaces.Cliente;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Cliente
{
    public class ClienteMensagemAppService : AppServiceBase<ClienteMensagem>, IClienteMensagemAppService
    {
        public ClienteMensagemAppService(IServiceBase<ClienteMensagem> serviceBase) : base(serviceBase)
        {
        }
    }
}
