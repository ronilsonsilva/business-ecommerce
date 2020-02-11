using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface IContatoLojaEnderecoRepository : IRepositoryBase<ContatoLojaEndereco>
    {
        ICollection<ContatoLojaEndereco> GetPorLoja(Guid idLoja);
    }
}
