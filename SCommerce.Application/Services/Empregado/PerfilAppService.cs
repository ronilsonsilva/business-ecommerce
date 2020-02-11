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
    public class PerfilAppService : AppServiceBase<Perfil>, IPerfilAppService
    {
        public PerfilAppService(IServiceBase<Perfil> serviceBase) : base(serviceBase)
        {
        }
    }
}
