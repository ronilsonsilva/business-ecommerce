using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.OC;

namespace SCommerce.Domain.Entities.Empregado
{
    public class Empregado : Base
    {
        public Empregado(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdPerfil { get; set; }
        public Perfil Perfil { get;  set; }
        public String Nome { get;  set; }
        public String Usuario { get;  set; }
        public String Senha { get;  set; }
        public DateTime UltimaConexao { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
        public ICollection<EmpregadoOC> EmpregadoOCs { get; set; }
        public ICollection<EmpregadoEndereco> EmpregadoEndereco { get;  set; }
        public ICollection<EmpregadoLoja> EmpregadoLojas { get; set; }
    }
}
