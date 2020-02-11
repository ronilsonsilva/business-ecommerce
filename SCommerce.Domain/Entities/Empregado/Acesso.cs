using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Empregado
{
    public class Acesso : Base
    {
        public Acesso(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String Comentario { get;  set; }
        public Guid IdPerfil { get; set; }
        public Guid IdModulo { get; set; }
        public Perfil Perfil { get;  set; }
        public Modulo Modulo { get;  set; }
        public Boolean View { get;  set; }
        public Boolean Edit { get;  set; }
        public Boolean Delete { get;  set; }
        public Boolean Create { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }
    }
}
