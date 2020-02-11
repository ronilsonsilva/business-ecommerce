using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoLojaEnderecoRepository : RepositoryBase<ContatoLojaEndereco>, IContatoLojaEnderecoRepository
    {
        ScContext Db = new ScContext();

        public ICollection<ContatoLojaEndereco> GetPorLoja(Guid idLoja)
        {
            try
            {
                return Db.ContatoLojaEndereco.Where(x => x.IdContatoLoja == idLoja).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
