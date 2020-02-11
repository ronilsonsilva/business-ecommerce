using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Produto;

namespace SCommerce.Domain.Entities.Transportadora
{
    public class Transportadora : Base
    {
        public Transportadora(Guid ID)
            : base(ID)
        {

        }
        
        public String Nome { get;  set; }
        public String NomeModuloExterno { get;  set; }
        public String MetodoEnvio { get;  set; }
        public String Website { get;  set; }
        public Boolean Ativo { get;  set; }
        public Boolean Deletado { get;  set; }
        public Boolean ShippingHandling { get;  set; }
        public Boolean RangeBehavior { get;  set; }
        public Boolean Modulo { get;  set; }
        public Boolean Gratis { get;  set; }
        public Boolean EnvioExterno { get;  set; }
        public Boolean NeedRange { get;  set; }
        public int Posicao { get;  set; }
        public Decimal AlturaMaxima { get;  set; }
        public Decimal ProfundidadeMaxima { get;  set; }
        public Decimal PesoMaximo { get;  set; }
        public Decimal Grade { get;  set; }

        public ICollection<TransportadoraEndereco> TransportadoraEndereco { get; set; }
        public ICollection<TransportadoraLoja> TransportadoraLoja { get; set; }
        public ICollection<FaixaDePeso> FaixaDePeso { get; set; }
        public ICollection<FaixaDePreco> FaixaDePreco { get; set; }
        public ICollection<ProdutoTransportadora> ProdutoTransportadoras { get; set; }
        public ICollection<Entrega> Entregas { get; set; }
    }
}
