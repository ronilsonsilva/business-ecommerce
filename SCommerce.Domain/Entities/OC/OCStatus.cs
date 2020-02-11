using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.OC
{
    public class OCStatus : Base
    {
        public OCStatus(Guid ID)
            : base(ID)
        {

        }
        
        public Boolean Faturado { get;  set; }
        public Boolean EnviarEmail { get;  set; }
        public Boolean NaoRemovivel { get;  set; }
        public Boolean Oculto { get;  set; }
        public Boolean Logable { get;  set; }
        public Boolean Entregado { get;  set; }
        public Boolean Enviado { get;  set; }
        public Boolean Pago { get;  set; }
        public Boolean Deletado { get;  set; }
        public Boolean Cancelado { get;  set; }
        public String ModuloNome { get;  set; }
        public String Cor { get;  set; }

        public ICollection<OC> OCs { get; set; }
    }
}
