
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ClienteContatoTelefoneViewModel : BaseViewModels
    {
        [Display(Name = "Nome Cliente")]
        public Guid ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }

        [Display(Name = "Telefone")]
        public Guid ContatoTelefoneId { get; set; }
        public ContatoTelefoneViewModel ContatoTelefone { get; set; }
        
    }
}
