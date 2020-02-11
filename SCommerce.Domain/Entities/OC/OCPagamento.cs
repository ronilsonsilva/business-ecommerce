using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Financeiro;

namespace SCommerce.Domain.Entities.OC
{
    public class OCPagamento : Base
    {
        public OCPagamento(Guid ID)
            : base(ID)
        {

        }
        

        public String OCReferencia { get;  set; }
        public int Quantidade { get;  set; }
        public Decimal TaxaConversao { get;  set; }
        public String NumeroCartao { get;  set; }
        public String BandeiraCartao { get;  set; }
        public DateTime CartaoVencimento { get;  set; }
        public String TitularCartao { get;  set; }
        public String TitularCPF { get;  set; }
        public DateTime NascimentoTitular { get;  set; }
        public DateTime Cadastro { get;  set; }
        public DateTime Atualizado { get;  set; }

        public Guid IdOCFatura { get; set; }
        public OCFatura OCFatura { get; set; }
    }
}
