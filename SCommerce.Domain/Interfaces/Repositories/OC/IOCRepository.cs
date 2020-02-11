using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.OC
{
    public interface IOCRepository :IRepositoryBase<Entities.OC.OC>
    {
        ICollection<Entities.OC.OC> GetOCs();
        ICollection<Entities.OC.OC> GetOCsDoCliente(Guid idCliente);
        Entities.OC.OC GetOC(Guid idOC);
    }
}
