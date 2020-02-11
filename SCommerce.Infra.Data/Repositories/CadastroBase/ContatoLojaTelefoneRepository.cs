using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoLojaTelefoneRepository : RepositoryBase<ContatoLojaTelefone>, IContatoLojaTelefoneRepository
    {
        public ICollection<ContatoLojaTelefone> GetPorLoja(Guid idLoja)
        {
            try
            {
                return Db.ContatoLojaTelefone.Where(x => x.IdContatoLoja == idLoja).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
