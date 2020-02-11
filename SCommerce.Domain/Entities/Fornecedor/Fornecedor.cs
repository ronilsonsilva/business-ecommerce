using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Fornecedor
{
    public class Fornecedor : Base
    {
        public Fornecedor(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public DateTime DataAtualizacao { get;  set; }
        public Boolean Ativo { get;  set; }

        public ICollection<FornecedorLoja> FornecedorLoja { get;  set; }
        public ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public ICollection<Fabricante.FabricanteFornecedor> FabricanteFornecedors { get; set; }
    }
}
