using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Cliente
{
    public class ClienteMensagemService : ServiceBase<ClienteMensagem>, IClienteMensagemService
    {
        public ClienteMensagemService(IRepositoryBase<ClienteMensagem> repository) : base(repository)
        {
        }
    }
}
