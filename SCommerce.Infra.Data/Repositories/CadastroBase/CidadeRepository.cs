using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        ScContext Db = new ScContext();
        public ICollection<Cidade> GetCidades(Guid idProvincia)
        {
            try
            {
                return Db.Cidade.Where(x => x.IdProvincia == idProvincia).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
