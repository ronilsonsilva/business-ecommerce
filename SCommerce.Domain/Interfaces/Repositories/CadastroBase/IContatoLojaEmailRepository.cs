using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface IContatoLojaEmailRepository : IRepositoryBase<ContatoLojaEmail>
    {
        ICollection<ContatoLojaEmail> GetPorLoja(Guid idLoja);
    }
}
