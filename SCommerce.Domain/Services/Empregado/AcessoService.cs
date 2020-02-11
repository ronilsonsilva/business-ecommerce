using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Empregado
{
    public class AcessoService : ServiceBase<Acesso>, IAcessoService
    {
        public AcessoService(IRepositoryBase<Acesso> repository) : base(repository)
        {
        }
    }
}
