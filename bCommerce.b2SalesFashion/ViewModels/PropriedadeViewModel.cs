
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class PropriedadeViewModel : BaseViewModels
    {
        [Display(Name = "Propriedade Pai")]
        public Guid? IdPai { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Descrição")]
        public String Descricao { get; set; }


        [Display(Name = "Customizável")]
        public Boolean Customizavel { get; set; }

        [Display(Name = "Valor Único")]
        public Boolean ValorUnico { get; set; }

        public ICollection<PropriedadeValorViewModel> PropriedadeValors { get; set; }
        public ICollection<ProdutoPropriedadeViewModel> ProdutoPropriedades { get; set; }
    }
}
