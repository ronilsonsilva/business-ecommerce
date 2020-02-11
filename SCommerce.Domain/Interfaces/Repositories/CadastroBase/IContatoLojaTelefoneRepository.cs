using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface IContatoLojaTelefoneRepository : IRepositoryBase<ContatoLojaTelefone>
    {
        ICollection<ContatoLojaTelefone> GetPorLoja(Guid idLoja);
    }
}
