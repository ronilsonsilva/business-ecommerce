using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSRedeSocialService : ServiceBase<CMSRedeSocial>, ICMSRedeSocialService
    {
        public CMSRedeSocialService(IRepositoryBase<CMSRedeSocial> repository) : base(repository)
        {
        }
    }
}
