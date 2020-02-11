using SCommerce.Application.Interfaces.CMS;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.CMS
{
    public class CMSLojaAppService : AppServiceBase<CMSLoja>, ICMSLojaAppService
    {
        public CMSLojaAppService(IServiceBase<CMSLoja> serviceBase) : base(serviceBase)
        {
        }
    }
}
