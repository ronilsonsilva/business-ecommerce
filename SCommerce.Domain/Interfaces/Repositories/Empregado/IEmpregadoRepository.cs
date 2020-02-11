using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Empregado
{
    public interface IEmpregadoRepository : IRepositoryBase<Entities.Empregado.Empregado>
    {
        Entities.Empregado.Empregado Login(String usuario, String senha);
    }
}
