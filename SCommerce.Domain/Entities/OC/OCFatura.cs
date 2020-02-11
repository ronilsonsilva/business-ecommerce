using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.OC
{
    public class OCFatura : Base
    {
        public OCFatura(Guid ID)
            : base(ID)
        {

        }
         
        public int Numero { get;  set; }
        public int NumeroEntrega { get;  set; }
        public DateTime Entrega { get;  set; }
        public Decimal ImpostoExlusaoTotal { get;  set; }
        public Decimal ImpostoInlusaoTotal { get;  set; }
        public Decimal ImpostoInlusaoPago { get;  set; }
        public Decimal ImpostoExlusaoPago { get;  set; }
        public Decimal TotalProdutosWT { get;  set; }
        public Decimal TotalImpostoExclusaoEnvio { get;  set; }
        public Decimal TotalImpostoInclusaoEnvio { get;  set; }
        public String Nota { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }

        public OC OC { get;  set; }
        public Guid IdOC { get; set; }

        public ICollection<OCPagamento> OCPagamentos { get; set; }
    }
}
