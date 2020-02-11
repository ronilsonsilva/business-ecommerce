using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class EnderecoViewModel : BaseViewModels
    {
        [Display(Name = "País")]
        public PaisViewModel Pais { get; set; }

        [Display(Name = "País")]
        public Guid idPais { get; set; }

        [Display(Name = "Estado")]
        public ProvinciaViewModel Provincia { get; set; }

        [Display(Name = "Estado")]
        public Guid idProvincia { get; set; }

        [Display(Name = "Bairro")]
        public String Aliase { get; set; }

        [Display(Name = "Logradouro")]
        public String Logradouro { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        public String Complemento { get; set; }


        [Display(Name = "Cidade")]
        public CidadeViewModel Cidade { get; set; }

        [Display(Name = "Cidade")]
        public Guid idCidade { get; set; }

        [Display(Name = "CEP")]
        public String CodigoPostal { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Ùltima Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime Atualizado { get; set; }

        [Display(Name = "Ativo")]
        public Boolean Ativo { get; set; }

        [Display(Name = "Exibir Como Excluído")]
        public bool Deletado { get; set; }

        [Display(Name = "Endereços das Lojas")]
        public ICollection<ContatoLojaEnderecoViewModel> ContatoLojaEnderecos { get; set; }

        public static EnderecoViewModel Mapear(Endereco endereco)
        {
            var saida = new EnderecoViewModel();
            if (endereco != null)
            {
                saida = new EnderecoViewModel()
                {
                    Aliase = endereco.Aliase,
                    Ativo = endereco.Ativo,
                    Atualizado = endereco.Atualizado,
                    Cadastro = endereco.Cadastro,
                    Cidade = CidadeViewModel.Mapear(endereco?.Cidade),
                    CodigoPostal = endereco.CodigoPostal,
                    Complemento = endereco.Complemento,
                    Deletado = endereco.Deletado,
                    ID = endereco.ID,
                    idCidade = endereco.IdCidade,
                    Numero = endereco.Numero,
                    Logradouro = endereco.Logradouro,
                    //ContatoLojaEnderecos = ContatoLojaEnderecoViewModel.Mapear(endereco?.ContatoLojaEnderecos)
                };
            }
            
            return saida;
        }

        public static ICollection<EnderecoViewModel> Mapear(ICollection<Endereco> endereco)
        {
            var saida = new Collection<EnderecoViewModel>();
            if (endereco != null)
            {
                foreach (var item in endereco)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }

        public static Endereco Mapear(EnderecoViewModel endereco)
        {
            var saida = new Endereco(Guid.Empty);
            if (endereco != null)
            {
                saida = new Endereco(Guid.Empty)
                {
                    Aliase = endereco.Aliase,
                    Ativo = endereco.Ativo,
                    Atualizado = endereco.Atualizado,
                    Cadastro = endereco.Cadastro,
                    Cidade = CidadeViewModel.Mapear(endereco?.Cidade),
                    CodigoPostal = endereco.CodigoPostal,
                    Complemento = endereco.Complemento,
                    Deletado = endereco.Deletado,
                    ID = endereco.ID,
                    IdCidade = endereco.idCidade,
                    Numero = endereco.Numero,
                    Logradouro = endereco.Logradouro,
                    //ContatoLojaEnderecos = ContatoLojaEnderecoViewModel.Mapear(endereco?.ContatoLojaEnderecos)
                };
            }

            return saida;
        }

        public static ICollection<Endereco> Mapear(ICollection<EnderecoViewModel> endereco)
        {
            var saida = new Collection<Endereco>();
            if (endereco != null)
            {
                foreach (var item in endereco)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
