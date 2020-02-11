using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Financeiro
{
    public class MoedaService : ServiceBase<Moeda>, IMoedaService
    {
        public MoedaService(IRepositoryBase<Moeda> repository) : base(repository)
        {
        }
    }
}
