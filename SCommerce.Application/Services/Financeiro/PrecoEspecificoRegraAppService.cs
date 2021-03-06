﻿using SCommerce.Application.Interfaces.Financeiro;
using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using SCommerce.Domain.Interfaces.Services.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services.Financeiro
{
    public class PrecoEspecificoRegraAppService : AppServiceBase<PrecoEspecificoRegra>, IPrecoEspecificoRegraAppService
    {
        public PrecoEspecificoRegraAppService(IServiceBase<PrecoEspecificoRegra> serviceBase) : base(serviceBase)
        {
        }
    }
}
