using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Departamento : Base
    {
        public Departamento(Guid ID)
            : base(ID)
        {

        }

        public String Nome { get; set; }
        public String NomeExibir { get; set; }
        public Guid IdPai { get; set; }
        public ICollection<LojaDepartamento> LojaDepartamentos { get; set; }
    }
}
