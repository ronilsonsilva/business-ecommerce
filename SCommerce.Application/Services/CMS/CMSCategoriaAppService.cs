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
    public class CMSCategoriaAppService : AppServiceBase<CMSCategoria>, ICMSCategoriaAppService
    {
        public CMSCategoriaAppService(IServiceBase<CMSCategoria> serviceBase) : base(serviceBase)
        {
        }
    }
}
