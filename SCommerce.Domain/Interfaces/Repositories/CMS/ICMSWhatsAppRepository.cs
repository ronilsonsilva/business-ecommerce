using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Domain.Interfaces.Repositories.CMS
{
    public interface ICMSWhatsAppRepository : IRepositoryBase<CMSWhatsApp>
    {
        void AdicionarNumero(CMSWhatsApp cMSWhatsApp);
        void AtualizarNumero(CMSWhatsApp cMSWhatsApp);
        Task<CMSWhatsApp> GetCMSWhatsApp();
        Task<CMSWhatsApp> GetCMSWhatsApp(Guid idCMSWhastApp);
    }
}
