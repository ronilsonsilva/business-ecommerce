using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class FabricanteViewModels : BaseViewModels
    {
        [Display(Name = "Razão Social")]
        public String Nome { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Display(Name =  "Atualizado")]
        [DataType(DataType.DateTime)]
        public DateTime DataAtualizacao { get; set; }

        [Display(Name = "Ativo?")]
        public Boolean Ativo { get; set; }
        //public ICollection<FabricanteFornecedor> FabricanteFornecedor { get; set; }
        //public ICollection<FabricanteLoja> FabricanteLoja { get; set; }
        //public ICollection<FabricanteProduto> FabricanteProduto { get; set; }
    }
}
