using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Empregado
{
    public class EmpregadoService : ServiceBase<Entities.Empregado.Empregado>, IEmpregadoService
    {
        public EmpregadoService(IRepositoryBase<Entities.Empregado.Empregado> repository) : base(repository)
        {
        }
    }
}
