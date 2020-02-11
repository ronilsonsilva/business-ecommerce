using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ProdutoPropriedadeViewModel : BaseViewModels
    {
        public PropriedadeViewModel Propriedade { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
