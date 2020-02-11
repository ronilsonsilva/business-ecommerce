using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class PedidosViewModel
    {
        public List<OCViewModel> OCs { get; set; }
        public OCViewModel OC { get; set; }
    }
}
