//using System;
//using System.Collections.Generic;
//using System.Text;
//using SCommerce.Domain.Entities.CadastroBase;

//namespace SCommerce.Domain.Entities.Financeiro
//{
//    public class ImpostoRegra : Base
//    {
//        public ImpostoRegra()
//        {

//        }
//        public ImpostoRegra(ImpostoRegraGrupo impostoRegraGrupo, Pais pais, Provincia provincia, string codigoPostalInico, string codigoPostalFim, string descricao, Imposto imposto, DateTime cadastro, DateTime atualizado)
//        {
//            ImpostoRegraGrupo = impostoRegraGrupo;
//            Pais = pais;
//            Provincia = provincia;
//            CodigoPostalInico = codigoPostalInico;
//            CodigoPostalFim = codigoPostalFim;
//            Descricao = descricao;
//            Imposto = imposto;
//            Cadastro = cadastro;
//            Atualizado = atualizado;
//        }

//        public ImpostoRegraGrupo ImpostoRegraGrupo { get;  set; }
//        public CadastroBase.Pais Pais { get;  set; }
//        public CadastroBase.Provincia Provincia { get;  set; }
//        public String CodigoPostalInico { get;  set; }
//        public String CodigoPostalFim { get;  set; }
//        public String Descricao { get;  set; }
//        public Imposto Imposto { get;  set; }
//        public DateTime Cadastro { get;  set; }
//        public DateTime Atualizado { get;  set; }
//    }
//}
