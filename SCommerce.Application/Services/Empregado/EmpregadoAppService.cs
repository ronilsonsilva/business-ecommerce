using SCommerce.Application.Interfaces.Empregado;
using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Empregado
{
    public class EmpregadoAppService : AppServiceBase<Domain.Entities.Empregado.Empregado>, IEmpregadoAppService
    {
        public EmpregadoAppService(IServiceBase<Domain.Entities.Empregado.Empregado> serviceBase) : base(serviceBase)
        {
        }
    }
}
