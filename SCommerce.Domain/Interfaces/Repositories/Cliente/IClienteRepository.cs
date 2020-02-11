using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Repositories.Cliente
{
    public interface IClienteRepository : IRepositoryBase<Entities.Cliente.Cliente>
    {
        Domain.Entities.Cliente.Cliente Login(string usuario, string senha);
        Boolean ExisteUsuario(String usuario);
        Boolean ExisteEmail(String email);
        Entities.Cliente.Cliente GetCliente(Guid idCliente);
        List<Entities.Cliente.Cliente> GetClientes();
    }
}
