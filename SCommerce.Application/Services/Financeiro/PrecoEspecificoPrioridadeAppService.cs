using SCommerce.Application.Interfaces.Financeiro;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Financeiro
{
    public class PrecoEspecificoPrioridadeAppService : AppServiceBase<PrecoEspecificoPrioridade>, IPrecoEspecificoPrioridadeAppService
    {
        public PrecoEspecificoPrioridadeAppService(IServiceBase<PrecoEspecificoPrioridade> serviceBase) : base(serviceBase)
        {
        }
    }
}
