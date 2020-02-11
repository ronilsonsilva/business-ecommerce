using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ProvinciaRepository : RepositoryBase<Provincia>, IProvinciaRepository
    {
        ScContext Db = new ScContext();
        public ICollection<Provincia> GetProvincias(Guid idPais)
        {
            try
            {
                return Db.Provincia.Where(x => x.IdPais == idPais).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
