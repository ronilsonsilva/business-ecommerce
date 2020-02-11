
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class EnderecoViewModel : BaseViewModels
    {
        [Display(Name = "País")]
        public PaisViewModel Pais { get; set; }

        [Display(Name = "Estado")]
        public ProvinciaViewModel Provincia { get; set; }

        [Display(Name = "Alíase")]
        public String Aliase { get; set; }

        [Display(Name = "Logradouro")]
        public String Logradouro { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        public String Complemento { get; set; }


        [Display(Name = "Cidade")]
        public CidadeViewModel Cidade { get; set; }

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
                    Cidade = CidadeViewModel.Mapear(endereco.Cidade),
                    CodigoPostal = endereco.CodigoPostal,
                    Complemento = endereco.Complemento,
                    Deletado = endereco.Deletado,
                    ID = endereco.ID,
                    Logradouro = endereco.Logradouro,
                    Numero = endereco.Numero
                };
            }
            return saida;
        }

        public static ICollection<EnderecoViewModel> Mapear(ICollection<Endereco> enderecos)
        {
            var saida = new Collection<EnderecoViewModel>();
            if (enderecos != null)
            {
                foreach (var item in enderecos)
                {
                    var endereco = Mapear(item);
                    saida.Add(endereco);
                }
            }
            return saida;
        }
    }
}
