using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class LojaGrupoViewModel : BaseViewModels
    {
        [Display(Name = "Nome")]
        [Required]
        public String Nome { get; set; }

        [Display(Name = "Compartilhar Clientes?")]
        public Boolean CompartilhaCliente { get; set; }

        [Display(Name = "Compatilhar OC?")]
        public Boolean CompartilhaOC { get; set; }

        [Display(Name = "Compatilhar Estoque?")]
        public Boolean CompartilhaEstoque { get; set; }

        [Display(Name = "Ativo?")]
        public Boolean Ativo { get; set; }

        [Display(Name = "Manter como excluído?")]
        public Boolean Deletado { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadatro { get; set; }

        [Display(Name = "Última atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizado { get; set; }

        [Display(Name = "Grupos da Loja")]
        public ICollection<LojaGrupoLojaViewModel> LojaGrupoLojas { get; set; }
    }
}
