using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CMS
{
    public class CMSEnderecoLojaService : ServiceBase<CMSEnderecoLoja>, ICMSEnderecoLojaService
    {
        public CMSEnderecoLojaService(IRepositoryBase<CMSEnderecoLoja> repository) : base(repository)
        {
        }
    }
}
