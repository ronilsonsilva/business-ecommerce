using System;
using System.Collections.Generic;
using SCommerce.Application.Interfaces;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Services;

namespace SCommerce.Application.Services.Cliente
{
    public class GrupoAppService : AppServiceBase<Domain.Entities.Cliente.Grupo>, Interfaces.Cliente.IGrupoAppService
    {
        public GrupoAppService(IServiceBase<Domain.Entities.Cliente.Grupo> serviceBase) : base(serviceBase)
        {
        }
    }
}
