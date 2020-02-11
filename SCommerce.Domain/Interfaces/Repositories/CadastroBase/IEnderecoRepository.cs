using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.CadastroBase
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        void AdicionarEndereco(Endereco endereco);
        void UpdateEndereco(Endereco endereco);
        ICollection<Endereco> GetEnderecosCliente(Guid idCliente);
        Endereco GetEndereco(Guid idEndereco);
    }
}
