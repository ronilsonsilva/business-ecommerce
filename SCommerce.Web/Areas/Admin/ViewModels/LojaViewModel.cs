using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class LojaViewModel : BaseViewModels
    {

        [Display(Name = "Nome da Loja Matriz")]
        public Guid LojaMatriz { get; set; }

        [Display(Name = "Matriz")]
        public Boolean Matriz { get; set; }

        [Display(Name = "Nome da Loja")]
        public String Nome { get; set; }

        [Display(Name = "Razão Social")]
        public String RazaoSocial { get; set; }

        [Display(Name = "CNPJ")]
        public String CNPJ { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public String InscricaoEstadual { get; set; }

        [Display(Name = "Ativa")]
        public Boolean Ativa { get; set; }

        [Display(Name = "Deletada")]
        public Boolean Deletada { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime Cadatro { get; set; }

        [Display(Name = "Atualizada em")]
        public DateTime Atualizado { get; set; }

        public String submit { get; set; }

        public CMSWhatsAppViewModel CMSWhatsApp { get; set; }


        public ICollection<ContatoLojaViewModel> ContatoLojas { get; set; }
        public ContatoLojaViewModel ContatoLoja { get; set; }
        public ContatoLojaViewModel ContatoLojaViewModel { get; set; }
        public ICollection<LojaDepartamentoViewModel> LojaDepartamentos { get; set; }
        public LojaDepartamentoViewModel LojaDepartamentoViewModel { get; set; }
        public ICollection<LojaImagensViewModel> LojaImagens { get; set; }
        public LojaImagensViewModel LojaImagensViewModel { get; set; }
        public ICollection<CategoriaLojaViewModel> CategoriaLojas { get; set; }
        public CategoriaLojaViewModel CategoriaLojaViewModel { get; set; }
        public ICollection<CMSLojaViewModel> CMSLojas { get; set; }
        public CMSLojaViewModel CMSLojaViewModel { get; set; }
        public ICollection<CMSRedeSocialViewModel> CMSRedeSocials { get; set; }
        public CMSRedeSocialViewModel CMSRedeSocialViewModel { get; set; }

        public static LojaViewModel Mapear(Domain.Entities.CadastroBase.Loja loja)
        {
            var saida = new LojaViewModel();
            if (loja != null)
            {
                saida = new LojaViewModel()
                {
                    Ativa = loja.Ativa,
                    Atualizado = loja.Atualizado,
                    Cadatro = loja.Cadatro,
                    //CategoriaLojas = loja.CategoriaLojas,

                    //CMSRedeSocials = loja.CMSRedeSocials,
                    CNPJ = loja.CNPJ,
                    //ContatoLojas = loja.ContatoLojas,
                    Deletada = loja.Deletada,
                    ID = loja.ID,
                    InscricaoEstadual = loja.InscricaoEstadual,
                    //LojaDepartamentos = loja.LojaDepartamentos,
                    //LojaImagens = loja.LojaImagens,
                    LojaMatriz = loja.LojaMatriz,
                    Matriz = loja.Matriz,
                    Nome = loja.Nome,
                    RazaoSocial = loja.RazaoSocial
                };
                saida.CMSLojas = CMSLojaViewModel.Mapear(loja.CMSLojas);
            }
            if (saida.CMSLojas == null)
            {
                saida.CMSLojas = new Collection<CMSLojaViewModel>();
            }
            return saida;
        }

        public static Collection<LojaViewModel> Mapear(List<Domain.Entities.CadastroBase.Loja> lojas)
        {
            var saida = new Collection<LojaViewModel>();
            if (lojas != null)
            {
                foreach (var item in lojas)
                {
                    saida.Add(LojaViewModel.Mapear(item));
                }
            }
            return saida;
        }


        public static Loja Mapear(LojaViewModel loja)
        {
            var saida = new Loja(Guid.Empty);
            if (loja != null)
            {
                saida = new Loja(Guid.Empty)
                {
                    Ativa = loja.Ativa,
                    Atualizado = loja.Atualizado,
                    Cadatro = loja.Cadatro,
                    //CategoriaLojas = loja.CategoriaLojas,

                    //CMSRedeSocials = loja.CMSRedeSocials,
                    CNPJ = loja.CNPJ,
                    //ContatoLojas = loja.ContatoLojas,
                    Deletada = loja.Deletada,
                    ID = loja.ID,
                    InscricaoEstadual = loja.InscricaoEstadual,
                    //LojaDepartamentos = loja.LojaDepartamentos,
                    //LojaImagens = loja.LojaImagens,
                    LojaMatriz = loja.LojaMatriz,
                    Matriz = loja.Matriz,
                    Nome = loja.Nome,
                    RazaoSocial = loja.RazaoSocial
                };
                saida.CMSLojas = CMSLojaViewModel.Mapear(loja.CMSLojas);
            }
            if (saida.CMSLojas == null)
            {
                saida.CMSLojas = new Collection<CMSLoja>();
            }
            return saida;
        }

        public static Collection<Loja> Mapear(List<LojaViewModel> lojas)
        {
            var saida = new Collection<Loja>();
            if (lojas != null)
            {
                foreach (var item in lojas)
                {
                    saida.Add(LojaViewModel.Mapear(item));
                }
            }
            return saida;
        }
        //public ICollection<ProdutoLoja> ProdutoLojas { get; set; }
        //public ICollection<Carrinho.Carrinho> Carrinhos { get; set; }
        //public ICollection<OC> OCs { get; set; }
        //public ICollection<TransportadoraLoja> TransportadoraLojas { get; set; }
        //public ICollection<FornecedorLoja> FornecedorLojas { get; set; }
        //public ICollection<FabricanteLoja> FabricanteLojas { get; set; }
        //public ICollection<EmpregadoLoja> EmpregadoLojas { get; set; }


    }
}
