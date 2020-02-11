using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.OC
{
    public class OCMensagemService : ServiceBase<OCMensagem>, IOCMensagemService
    {
        public OCMensagemService(IRepositoryBase<OCMensagem> repository) : base(repository)
        {
        }
    }
}
