using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {

        public void AdicionarEndereco(Endereco endereco)
        {
            try
            {
                Db.Attach(endereco).State = EntityState.Added;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public Endereco GetEndereco(Guid idEndereco)
        {
            try
            {
                return Db.Endereco.Where(x => x.ID == idEndereco).Include(x => x.Cidade.Provincia.Pais).FirstOrDefault();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ICollection<Endereco> GetEnderecosCliente(Guid idCliente)
        {
            try
            {
                return Db.Endereco.Where(x => x.IdCliente == idCliente).Include(x => x.Cidade.Provincia.Pais).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        
        public void UpdateEndereco(Endereco endereco)
        {
            try
            {
                Db.Attach<Endereco>(endereco).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
