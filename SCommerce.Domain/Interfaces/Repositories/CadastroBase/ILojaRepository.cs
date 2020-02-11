using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface ILojaRepository : IRepositoryBase<Loja>
    {
        void UpdateLoja(Loja loja);
        void SalvarLoja(Loja loja);
    }
}
