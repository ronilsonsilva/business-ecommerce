using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.Empregado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.Empregado
{
    public class ModuloService : ServiceBase<Modulo>, IModuloService
    {
        public ModuloService(IRepositoryBase<Modulo> repository) : base(repository)
        {
        }
    }
}
