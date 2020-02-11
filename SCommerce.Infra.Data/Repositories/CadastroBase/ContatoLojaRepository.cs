using System;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class ContatoLojaRepository : RepositoryBase<ContatoLoja>, IContatoLojaRepository
    {

        public void AdicionarContatLoja(ContatoLoja contatoLoja)
        { 
            try
            {
                Db.Attach(contatoLoja).State = EntityState.Added;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public ContatoLoja GetContatoLojaPorLoja(Guid idLoja)
        {
            try
            {
                var contatoLoja = Db.ContatoLoja.Where(x => x.IdLoja == idLoja).FirstOrDefault();
                if (contatoLoja != null)
                {
                    contatoLoja.ContatoLojaEmails = Db.ContatoLojaEmail.Include(x => x.ContatoEmail).ToList();
                    contatoLoja.ContatoLojaEnderecos = Db.ContatoLojaEndereco.Include(x => x.Endereco).ToList();
                    contatoLoja.ContatoLojaRedeSocials = Db.ContatoLojaRedeSocial.Include(x => x.ContatoRedeSocial).ToList();
                    contatoLoja.ContatoLojaTelefones = Db.ContatoLojaTelefone.Include(x => x.ContatoTelefone).ToList();
                }
                return contatoLoja;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void UpdateContatoLoja(ContatoLoja contatoLoja)
        {
            try
            {
                Db.Attach<ContatoLoja>(contatoLoja).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
