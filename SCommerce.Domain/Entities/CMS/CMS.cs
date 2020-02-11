using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMS : Base
    {
        public CMS(Guid ID)
            : base(ID)
        {

        }
       
        //public Guid CMSCategoriaId { get; set; }
        public CMSCategoria CMSCategoria { get;  set; }
        public int Posicao { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Indexado { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public ICollection<CadastroBase.Loja> Lojas { get;  set; }
    }
}
