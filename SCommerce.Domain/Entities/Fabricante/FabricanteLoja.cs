using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Fabricante
{
    public class FabricanteLoja : Base
    {
        public FabricanteLoja(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdLoja { get; set; }
        public Guid IdFabricante { get; set; }
        public CadastroBase.Loja Loja { get;  set; }
        public Fabricante Fabricante { get;  set; }
    }
}
