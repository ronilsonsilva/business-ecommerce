using SCommerce.Application.Interfaces.CadastroBase;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.CadastroBase
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        public CidadeAppService(IServiceBase<Cidade> serviceBase) : base(serviceBase)
        {
        }
    }
}
