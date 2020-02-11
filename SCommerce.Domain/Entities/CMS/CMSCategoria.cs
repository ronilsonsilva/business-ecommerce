using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSCategoria : Base
    {
        public CMSCategoria(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public Guid IdPai { get;  set; }
        public int Posicao { get;  set; }
        public Boolean LevelDepth { get;  set; }
        public Boolean Ativo { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
    }
}
