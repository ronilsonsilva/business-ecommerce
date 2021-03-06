﻿using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.OC
{
    public class OCDetalhesService : ServiceBase<OCDetalhes>, IOCDetalhesService
    {
        public OCDetalhesService(IRepositoryBase<OCDetalhes> repository) : base(repository)
        {
        }
    }
}
