using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CadastroBase
{
    public class ContatoTelefoneService : ServiceBase<ContatoTelefone>, IContatoTelefoneService
    {
        public ContatoTelefoneService(IRepositoryBase<ContatoTelefone> repository) : base(repository)
        {
        }
    }
}
