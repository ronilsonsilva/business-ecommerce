using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CMS
{
    public class CMSSlidePrincipal : Base
    {
        public CMSSlidePrincipal(Guid ID) : base(ID)
        {
        }

        public String ArquivoType { get; set; }
        public Byte[] ArquivoImage { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }
        public string TituloPrincipal { get; set; }
        public string Subtitulo { get; set; }
        public Boolean Produto { get; set; }
        public Boolean Categoria { get; set; }
        public Guid IdProduto { get; set; }
        public Guid IdCategoria { get; set; }
    }
}
