
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ClienteViewModel : BaseViewModels
    {
        [Display(Name = "Loja")]
        public Guid LojaId { get; set; }

        [Display(Name = "Gênero")]
        public Guid GeneroId { get; set; }

        //public Risco Risco { get; set; }


        //public String Companhia { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }


        [Display(Name = "Confirmar senha")]
        [DataType(DataType.Password)]
        public String Senha1 { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Receber NewsLetter")]
        public Boolean NewsLetter { get; set; }

        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public String Website { get; set; }


        //public int PermissoesPendente { get; set; }


        //public Boolean ExibirPrecosPublicos { get; set; }


        //public int MaxDiasPagamentos { get; set; }
        //public String ChaveSeguranca { get; set; }

        [Display(Name = "Observação")]
        [DataType(DataType.MultilineText)]
        public String Nota { get; set; }

        [Display(Name = "Ativo")]
        public Boolean Ativo { get; set; }

        //[Display(Name = "Visitante")]
        //public Boolean Visitante { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Cadastro { get; set; }

        [Display(Name = "Atualizado")]
        [DataType(DataType.Date)]
        public DateTime Atualizado { get; set; }

        //[Display(Name = "Deletado")]
        //public Boolean Deletado { get; set; }


        public ICollection<ContatoTelefoneViewModel> ContatoTelefones { get; set; }
        public ICollection<EnderecoViewModel> Enderecos { get; set; }
        public ICollection<ClienteGrupoViewModel> ClienteGrupo { get; set; }


        public static ClienteViewModel Mapear(SCommerce.Domain.Entities.Cliente.Cliente cliente)
        {
            try
            {
                var saida = new ClienteViewModel();
                if (cliente != null)
                {
                    saida = new ClienteViewModel()
                    {
                        Ativo = cliente.Ativo,
                        Atualizado = cliente.Atualizado,
                        Cadastro = cliente.Cadastro,
                        ContatoTelefones = ContatoTelefoneViewModel.Mapear(cliente.ContatoTelefones),
                        Email = cliente.Email,
                        Enderecos = EnderecoViewModel.Mapear(cliente.Enderecos),
                        ID = cliente.ID,
                        Nascimento = cliente.Nascimento,
                        NewsLetter = cliente.NewsLetter,
                        Nome = cliente.Nome,
                        Nota = cliente.Nota,
                        Senha = cliente.Senha,
                        Website = cliente.Website
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ClienteViewModel> Mapear(ICollection<SCommerce.Domain.Entities.Cliente.Cliente> clientes)
        {
            try
            {
                var saida = new Collection<ClienteViewModel>();
                if (clientes != null)
                {
                    foreach (var item in clientes)
                    {
                        var cliente = Mapear(item);
                        saida.Add(cliente);
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
