using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSSlidePrincipalService : ServiceBase<CMSSlidePrincipal>
    {
        public CMSSlidePrincipalService(IRepositoryBase<CMSSlidePrincipal> repository) : base(repository)
        {
        }
    }
}
