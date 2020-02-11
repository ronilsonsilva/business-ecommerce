using SCommerce.Domain.Entities.Transportadora;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Transportadora
{
    public class FaixaDePrecoService : ServiceBase<FaixaDePreco>, IFaixaDePrecoService
    {
        public FaixaDePrecoService(IRepositoryBase<FaixaDePreco> repository) : base(repository)
        {
        }
    }
}
