using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Loja : Base
    {
        public Loja(Guid ID)
            : base(ID)
        {

        }
        
        public Guid LojaMatriz { get;  set; }
        public Boolean Matriz { get;  set; }
        public String Nome { get;  set; }
        public String RazaoSocial { get;  set; }
        public String CNPJ { get;  set; }
        public String InscricaoEstadual { get;  set; }
        
        public Boolean Ativa { get; set; }
        public Boolean Deletada { get;  set; }
        public DateTime Cadatro { get;  set; }
        public DateTime Atualizado { get;  set; }

        public ICollection<ContatoLoja> ContatoLojas { get;  set; }
        public ICollection<LojaDepartamento> LojaDepartamentos { get;  set; }
        public ICollection<LojaImagens> LojaImagens { get;  set; }
        
        public ICollection<CategoriaLoja> CategoriaLojas { get; set; }
        public ICollection<ProdutoLoja> ProdutoLojas { get; set; }
        public ICollection<Carrinho.Carrinho> Carrinhos { get; set; }
        public ICollection<OC.OC> OCs { get; set; }
        public ICollection<CMS.CMSLoja> CMSLojas { get; set; }
        public ICollection<CMS.CMSRedeSocial> CMSRedeSocials { get; set; }
        public ICollection<Transportadora.TransportadoraLoja> TransportadoraLojas { get; set; }
        public ICollection<Fornecedor.FornecedorLoja> FornecedorLojas { get; set; }
        public ICollection<Fabricante.FabricanteLoja> FabricanteLojas { get; set; }
        public ICollection<Empregado.EmpregadoLoja> EmpregadoLojas { get; set; }
    }
}
