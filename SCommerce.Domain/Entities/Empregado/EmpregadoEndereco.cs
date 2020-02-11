using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Empregado
{
    public class EmpregadoEndereco:Base
    {
        public EmpregadoEndereco(Guid ID)
            : base(ID)
        {

        }


        public Guid IdEmpregado { get; set; }
        public Guid IdEndereco { get; set; }
        public Empregado Empregado { get;  set; }
        public CadastroBase.Endereco Endereco { get;  set; }
    }
}
