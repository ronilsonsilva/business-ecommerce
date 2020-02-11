
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class GrupoViewModel : BaseViewModels
    {
        [Display(Name = "Desconto")]
        public Decimal Desconto { get; set; }

        [Display(Name = "Exibir Método de Pagamento")]
        public Boolean ExibirMetodoPagamento { get; set; }

        [Display(Name = "Exibir Preço")]
        public Boolean ExibirPreco { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Atualizado")]
        [DataType(DataType.Date)]
        public DateTime DataAtualizacao { get; set; }
    }
}
