using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSService : ServiceBase<Entities.CMS.CMS>, ICMSService
    {
        public CMSService(IRepositoryBase<Entities.CMS.CMS> repository) : base(repository)
        {
        }
    }
}
