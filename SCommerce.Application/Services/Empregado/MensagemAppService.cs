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
    public class MensagemAppService : AppServiceBase<Mensagem>, IMensagemAppService
    {
        public MensagemAppService(IServiceBase<Mensagem> serviceBase) : base(serviceBase)
        {
        }
    }
}
