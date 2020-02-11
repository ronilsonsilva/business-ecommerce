using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.OC
{
    public class OCRetornoStatus : Base
    {
        public OCRetornoStatus(Guid ID)
            : base(ID)
        {

        }
        
        public String Status { get;  set; }
        public String Cor { get;  set; }
    }
}
