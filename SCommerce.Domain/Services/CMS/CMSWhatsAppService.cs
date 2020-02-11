using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSWhatsAppService : ServiceBase<CMSWhatsApp>, ICMSWhatsAppService
    {
        public CMSWhatsAppService(IRepositoryBase<CMSWhatsApp> repository) : base(repository)
        {
        }
    }
}
