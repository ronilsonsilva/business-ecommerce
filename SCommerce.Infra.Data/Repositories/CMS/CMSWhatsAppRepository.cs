using Microsoft.EntityFrameworkCore;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Infra.Data.Repositories.CMS
{
    public class CMSWhatsAppRepository : RepositoryBase<CMSWhatsApp>, ICMSWhatsAppRepository
    {
        public void AdicionarNumero(CMSWhatsApp cMSWhatsApp)
        {
            try
            {
                Db.Attach(cMSWhatsApp).State = EntityState.Detached;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizarNumero(CMSWhatsApp cMSWhatsApp)
        {
            try
            {
                Db.Attach<CMSWhatsApp>(cMSWhatsApp).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Retorna o numero do WhatsApp
        /// </summary>
        /// <returns></returns>
        public Task<CMSWhatsApp> GetCMSWhatsApp()
        {
            try
            {
                var cmsWhatsApp = Db.CMSWhatsApps.Include(x => x.ContatoLojaTelefone.ContatoTelefone).FirstOrDefaultAsync();
                return cmsWhatsApp;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        /// <summary>
        /// Retorna o numero do WhatsApp
        /// </summary>
        /// <returns></returns>
        public Task<CMSWhatsApp> GetCMSWhatsApp(Guid idCMSWhastApp)
        {
            try
            {
                var cmsWhatsApp = Db.CMSWhatsApps
                    .Where(x => x.ID == idCMSWhastApp)
                    .Include(x => x.ContatoLojaTelefone.ContatoTelefone).FirstOrDefaultAsync();
                return cmsWhatsApp;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
