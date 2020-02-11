using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class Endereco : Base
    {
        public Endereco(Guid ID)
            : base(ID)
        {

        }

        public String Aliase { get;  set; }
        public String Logradouro { get;  set; }
        public int Numero { get;  set; }
        public String Complemento { get;  set; }
        public String CodigoPostal { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public Boolean Ativo { get;  set; }
        public bool Deletado { get;  set; }

        public Guid IdCidade { get; set; }
        public Cidade Cidade { get;  set; }
        public Cliente.Cliente Cliente { get; set; }
        public Guid? IdCliente { get; set; }
        
        public ICollection<ContatoLojaEndereco> ContatoLojaEnderecos { get; set; }
        public ICollection<Transportadora.TransportadoraEndereco> TransportadoraEnderecos { get; set; }
        public ICollection<Empregado.EmpregadoEndereco> EmpregadoEnderecos { get; set; }
    }
}
