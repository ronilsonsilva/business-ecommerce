using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories.Cliente;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories.Cliente
{
    public class ClienteRepository : RepositoryBase<Domain.Entities.Cliente.Cliente>, IClienteRepository
    {

        public bool ExisteEmail(string email)
        {
            try
            {
                return Db.Cliente.Where(x => x.Email.Equals(email)).Count() > 0;
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public bool ExisteUsuario(string usuario)
        {
            try
            {
                return Db.Cliente.Where(x => x.Usuario.Equals(usuario)).Count() > 0;
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public Domain.Entities.Cliente.Cliente GetCliente(Guid idCliente)
        {
            try
            {
                var cliente = Db.Cliente.Where(x => x.ID == idCliente)
                    .Include(x => x.Enderecos)
                    .Include(x => x.ContatoTelefones)
                    .Include(x => x.OCs)
                    .Include(x => x.Carrinhos).FirstOrDefault();
                if (cliente != null)
                {
                    foreach (var item in cliente.Enderecos)
                    {
                        item.Cidade = Db.Cidade.Where(x => x.ID == item.IdCidade).Include(x => x.Provincia.Pais).FirstOrDefault();
                    }
                }
                return cliente;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<Domain.Entities.Cliente.Cliente> GetClientes()
        {
            try
            {
                var clientes = Db.Cliente.Include(x =>x.Enderecos)
                    .Include(x => x.ContatoTelefones)
                    .Include(x => x.OCs)
                    .Include(x => x.Carrinhos).ToList();
                if (clientes != null)
                {
                    foreach (var item in clientes)
                    {
                        foreach (var cidade in item.Enderecos)
                        {
                            cidade.Cidade = Db.Cidade.Where(x => x.ID == cidade.IdCidade).Include(x => x.Provincia.Pais).FirstOrDefault();
                        }
                    }
                }
                return clientes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public Domain.Entities.Cliente.Cliente Login(string usuario, string senha)
        {
            try
            {
                return Db.Cliente.Where(x => x.Email.Equals(usuario) && x.Senha.Equals(senha)).FirstOrDefault();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
