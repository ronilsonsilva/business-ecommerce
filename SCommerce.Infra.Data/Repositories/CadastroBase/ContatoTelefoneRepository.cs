using System;
using System.Collections.Generic;
using System.Linq;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoTelefoneRepository : RepositoryBase<ContatoTelefone>, IContatoTelefoneRepository
    {
        public ICollection<ContatoTelefone> GetContatoTelefonesCliente(Guid idCliente)
        {
            try
            {
                return Db.ContatoTelefone.Where(x => x.IdCliente == idCliente).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
