using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Cliente
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        public ContatoService(IRepositoryBase<Contato> repository) : base(repository)
        {
        }
    }
}
