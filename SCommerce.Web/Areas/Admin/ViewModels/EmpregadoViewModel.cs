using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class EmpregadoViewModel : BaseViewModels
    {
        //public Perfil Perfil { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Usuario")]
        public String Usuario { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }

        [Display(Name = "Ultima Conexão")]
        [DataType(DataType.Date)]
        public DateTime UltimaConexao { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Atualizado")]
        [DataType(DataType.Date)]
        public DateTime Atualizado { get; set; }

        public ICollection<EmpregadoEnderecoViewModel> EmpregadoEndereco { get; set; }
        //public ICollection<EmpregadoOC> EmpregadoOC { get; set; }
        //public ICollection<EmpregadoLoja> EmpregadoLojas { get; set; }
    }
}
