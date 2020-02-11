using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class BaseViewModels
    {
        [Key]
        [Display(Name = "Identificador")]
        public Guid ID { get; set; }
    }
}
