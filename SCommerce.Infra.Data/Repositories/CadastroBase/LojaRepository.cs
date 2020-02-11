using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Infra.Data.EF;

namespace SCommerce.Infra.Data.Repositories.CadastroBase
{
    public class LojaRepository : RepositoryBase<Loja>, ILojaRepository
    {
        ScContext Db = new ScContext();

        public void SalvarLoja(Loja loja)
        {
            try
            {
                Db.Attach(loja).State = EntityState.Added;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            };
        }

        public void UpdateLoja(Loja loja)
        {
            try
            {
                Db.Attach<Loja>(loja).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
