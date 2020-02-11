using SCommerce.Domain.Entities.Financeiro;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Financeiro
{
    public class MetodoPagamentoService : ServiceBase<MetodoPagamento>, IMetodoPagamentoService
    {
        public MetodoPagamentoService(IRepositoryBase<MetodoPagamento> repository) : base(repository)
        {
        }
    }
}
