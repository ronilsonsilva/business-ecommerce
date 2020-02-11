using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface IContatoLojaRepository : IRepositoryBase<ContatoLoja>
    {
        void AdicionarContatLoja(ContatoLoja contatoLoja);
        void UpdateContatoLoja(ContatoLoja contatoLoja);
        ContatoLoja GetContatoLojaPorLoja(Guid idLoja);
    }
}
