using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Domain.Entities.Cliente
{
    public class Cliente : Base
    {
        public Cliente(Guid ID)
            : base(ID)
        {

        }
        public String Usuario { get; set; }
        public String GeneroCliente { get; set; }
        public String Companhia { get;  set; }
        public String Nome { get;  set; }
        public String Email { get;  set; }
        public String Senha { get;  set; }
        public DateTime Nascimento { get;  set; }
        public Boolean NewsLetter { get;  set; }
        public Boolean CadastroNewsLetter { get;  set; }
        public String Website { get;  set; }
        public int PermissoesPendente { get;  set; }
        public Boolean ExibirPrecosPublicos { get;  set; }
        public int MaxDiasPagamentos { get;  set; }
        public String ChaveSeguranca { get;  set; }
        public String Nota { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Visitante { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public Boolean Deletado { get;  set; }

        public ICollection<Carrinho.Carrinho> Carrinhos { get; set; }
        public ICollection<ContatoTelefone> ContatoTelefones  { get;  set; }
        public ICollection<Endereco> Enderecos { get;  set; }
        public ICollection<ClienteProcesso> ClienteProcessos { get; set; }
        public ICollection<OC.OC> OCs { get; set; }
    }
}
