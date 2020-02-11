using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Empregado
{
    public class EmpregadoLoja : Base
    {
        public EmpregadoLoja(Guid ID)
            : base(ID)
        {

        }
        

        public Guid IdEmpregado { get; set; }
        public Guid IdLoja { get; set; }
        public Empregado Empregado { get;  set; }
        public CadastroBase.Loja Loja { get;  set; }
    }
}
