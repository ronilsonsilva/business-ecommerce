using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Produto
{
    public class PropriedadeValorService : ServiceBase<PropriedadeValor>, IPropriedadeValorService
    {
        public PropriedadeValorService(IRepositoryBase<PropriedadeValor> repository) : base(repository)
        {
        }
    }
}
