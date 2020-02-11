using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSLojaService : ServiceBase<CMSLoja>, ICMSLojaService
    {
        public CMSLojaService(IRepositoryBase<CMSLoja> repository) : base(repository)
        {
        }
    }
}
