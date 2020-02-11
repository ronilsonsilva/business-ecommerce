using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoLojaRedeSocialRepository : RepositoryBase<ContatoLojaRedeSocial>, IContatoLojaRedeSocialRepository
    {
        public ICollection<ContatoLojaRedeSocial> GetPorLoja(Guid idLoja)
        {
            try
            {
                return Db.ContatoLojaRedeSocial.Where(x => x.ID == idLoja).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
