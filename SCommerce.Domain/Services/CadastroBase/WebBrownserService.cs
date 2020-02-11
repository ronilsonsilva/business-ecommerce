using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CadastroBase
{
    public class WebBrownserService : ServiceBase<WebBrownser>, IWebBrownserService
    {
        public WebBrownserService(IRepositoryBase<WebBrownser> repository) : base(repository)
        {
        }
    }
}
