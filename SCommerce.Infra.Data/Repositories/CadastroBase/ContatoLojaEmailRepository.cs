using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoLojaEmailRepository : RepositoryBase<ContatoLojaEmail>, IContatoLojaEmailRepository
    {
        ScContext Db = new ScContext();

        public ICollection<ContatoLojaEmail> GetPorLoja(Guid idLoja)
        {
            try
            {
                return Db.ContatoLojaEmail.Where(x => x.IdContatoLoja == idLoja).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
