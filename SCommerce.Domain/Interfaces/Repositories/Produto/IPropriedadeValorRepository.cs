using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Produto
{
    public interface IPropriedadeValorRepository : IRepositoryBase<PropriedadeValor>
    {
        ICollection<PropriedadeValor> GetByPropriedade(Guid idPropriedade);
        Propriedade GetPropriedade(Guid idPropriedadeValor);
    }
}
