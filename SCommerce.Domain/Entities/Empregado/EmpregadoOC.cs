using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.OC;

namespace SCommerce.Domain.Entities.Empregado
{
    public class EmpregadoOC : Base
    {
        public EmpregadoOC(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdEmpregado { get; set; }
        public Guid IdOC { get; set; }
        public Empregado Empregado { get;  set; }
        public OC.OC OC { get;  set; }
    }
}
