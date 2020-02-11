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
    public class DepartamentoAppService : AppServiceBase<Departamento>, IDepartamentoAppService
    {
        public DepartamentoAppService(IServiceBase<Departamento> serviceBase) : base(serviceBase)
        {
        }
    }
}
