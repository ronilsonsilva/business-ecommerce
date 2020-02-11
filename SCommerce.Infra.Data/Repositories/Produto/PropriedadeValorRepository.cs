using System;
using System.Linq;
using System.Collections.Generic;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.Produto
{
    public class PropriedadeValorRepository : RepositoryBase<PropriedadeValor>, IPropriedadeValorRepository
    {
        protected ScContext Db = new ScContext();

        public ICollection<PropriedadeValor> GetByPropriedade(Guid idPropriedade)
        {
            return Db.PropriedadeValor.Where(x => x.Propriedade.ID == idPropriedade).ToList();
        }

        public Propriedade GetPropriedade(Guid idPropriedadeValor)
        {
            var propriedade = Db.PropriedadeValor.Where(x => x.ID == idPropriedadeValor).Select(x => x.Propriedade).FirstOrDefault();
            return propriedade;
        }
    }
}
