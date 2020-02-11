using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services.OC
{
    public class OCRetornoStatusService : ServiceBase<OCRetornoStatus>, IOCRetornoStatusService
    {
        public OCRetornoStatusService(IRepositoryBase<OCRetornoStatus> repository) : base(repository)
        {
        }
    }
}
