using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Empregado
{
    public class Modulo : Base
    {
        public Modulo(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdPai { get;  set; }
        public String Nome { get;  set; }
        public String Detalhes { get;  set; }
        public int Posicao { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean HideHostMode { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public ICollection<Acesso> Acessos { get; set; }
    }
}
