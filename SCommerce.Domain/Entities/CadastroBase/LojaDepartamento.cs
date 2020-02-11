using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class LojaDepartamento : Base
    {
        public LojaDepartamento(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdLoja { get; set; }
        public Loja Loja { get;  set; }
        public Guid IdDepartamento { get; set; }
        public Departamento Departamento { get;  set; }
    }
}
