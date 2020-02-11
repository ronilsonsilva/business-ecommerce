using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Produto
{
    public class Categoria : Base
    {
        public Categoria(Guid ID)
            : base(ID)
        {

        }
        public Guid IDCategoriaPai { get; set; }
        public string Nome { get; set; }
        public Boolean LevelDepth { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Root { get;  set; }
        public int NLeft { get;  set; }
        public int NRight { get;  set; }
        public int Posicao { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }

        public ICollection<Produto> Produtos { get; set; }
        public ICollection<CategoriaLoja> CategoriaLojas { get; set; }
    }
}
