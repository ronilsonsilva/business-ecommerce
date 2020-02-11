using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Cliente
{
    public class ClienteService : ServiceBase<Entities.Cliente.Cliente>, IClienteService
    {
        public ClienteService(IRepositoryBase<Entities.Cliente.Cliente> repository) : base(repository)
        {
        }
    }
}
