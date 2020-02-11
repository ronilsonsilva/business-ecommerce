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
    public class CMSAppService : AppServiceBase<Domain.Entities.CMS.CMS>, ICMSAppService
    {
        public CMSAppService(IServiceBase<Domain.Entities.CMS.CMS> serviceBase) : base(serviceBase)
        {
        }
    }
}
