using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories.OC;

namespace SCommerce.Infra.Data.Repositories.OC
{
    public class OCDetalhesRepository : RepositoryBase<OCDetalhes>, IOCDetalhesRepository
    {
        public OCDetalhes GetOCDetalhes(Guid idOCDetalhes)
        {
            try
            {
                var ocDetalhes = Db.OCDetalhes.Where(x => x.ID == idOCDetalhes)
                    .Include(x => x.OC)
                    .Include(x => x.Produto)
                    .FirstOrDefault();
                return ocDetalhes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
