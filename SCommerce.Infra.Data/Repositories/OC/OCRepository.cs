using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories.OC;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories.OC
{
    public class OCRepository : RepositoryBase<Domain.Entities.OC.OC>, IOCRepository
    {
        public Domain.Entities.OC.OC GetOC(Guid idOC)
        {
            try
            {
                var oc = Db.OC.Where(x => x.ID == idOC)
                    .Include(x => x.Cliente)
                    .Include(x => x.ClienteProcessos)
                    .Include(x => x.OCStatus)
                    .Include(x => x.MetodoPagamento)
                    .Include(x => x.OCDetalhes)
                    .Include(x => x.OCFaturas)
                    .Include(x => x.OCMensagens).FirstOrDefault();
                return oc;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ICollection<Domain.Entities.OC.OC> GetOCs()
        {
            try
            {
                var Ocs = Db.OC
                    .Include(x => x.Cliente)
                    .Include(x => x.ClienteProcessos)
                    .Include(x => x.OCStatus)
                    .Include(x => x.MetodoPagamento)
                    .Include(x => x.OCDetalhes)
                    .Include(x => x.OCFaturas)
                    .Include(x => x.OCMensagens).ToList();
                return Ocs;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ICollection<Domain.Entities.OC.OC> GetOCsDoCliente(Guid idCliente)
        {
            try
            {
                var Ocs = Db.OC.Where(x => x.IdCliente == idCliente)
                    .Include(x => x.Cliente)
                    .Include(x => x.ClienteProcessos)
                    .Include(x => x.OCStatus)
                    .Include(x => x.MetodoPagamento)
                    .Include(x => x.OCDetalhes)
                    .Include(x => x.OCFaturas)
                    .Include(x => x.OCMensagens).ToListAsync();
                return Ocs.Result;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
