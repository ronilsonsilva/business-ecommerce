using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.CadastroBase
{
    public class LojaDepartamentoService : ServiceBase<LojaDepartamento>, ILojaDepartamentoService
    {
        public LojaDepartamentoService(IRepositoryBase<LojaDepartamento> repository) : base(repository)
        {
        }
    }
}
