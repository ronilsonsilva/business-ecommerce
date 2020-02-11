
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class LojaViewModel : BaseViewModels
    {
        [Display(Name = "Loja Padrão da Categoria")]
        public Guid LojaMatriz { get; set; }

        [Display(Name = "É Matriz?")]
        public Boolean Matriz { get; set; }

        [Display(Name = "Nome Fantasia")]
        [Required]
        public String Nome { get; set; }

        [Display(Name = "Razão Social")]
        public String RazaoSocial { get; set; }

        [Display(Name = "CNPJ")]
        public String CNPJ { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public String InscricaoEstadual { get; set; }

        [Display(Name = "Grupo da Loja")]
        public LojaGrupoViewModel LojaGrupo { get; set; }

        [Display(Name = "Ativa?")]
        public Boolean Ativa { get; set; }

        [Display(Name = "Exibir como excluida?")]
        public Boolean Deletada { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadatro { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizado { get; set; }

        //[Display(Name = "Contatos")]
        //public ICollection<ContatoLojaViewModel> ContatoLojas { get; set; }

        //[Display(Name = "Departamentos")]
        //public ICollection<LojaDepartamentoViewModel> LojaDepartamentos { get; set; }

        //[Display(Name = "Imagens")]
        //public ICollection<LojaImagensViewModel> LojaImagens { get; set; }

        //[Display(Name = "Grupos da Loja")]
        //public ICollection<LojaGrupoLojaViewModel> LojaGrupoLojas { get; set; }


        public static LojaViewModel Mapear(Loja loja)
        {
            try
            {
                var saida = new LojaViewModel();
                if (loja != null)
                {
                    saida = new LojaViewModel()
                    {
                        Ativa = loja.Ativa,
                        Atualizado = loja.Atualizado,
                        Cadatro = loja.Cadatro,
                        CNPJ = loja.CNPJ,
                        Deletada = loja.Deletada,
                        ID = loja.ID,
                        InscricaoEstadual = loja.InscricaoEstadual,
                        Nome = loja.Nome,
                        RazaoSocial = loja.RazaoSocial
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<LojaViewModel> Mapear(ICollection<Loja> lojas)
        {
            try
            {
                var saida = new Collection<LojaViewModel>();
                if (lojas != null)
                {
                    foreach (var item in lojas)
                    {
                        var loja = Mapear(item);
                        saida.Add(loja);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
