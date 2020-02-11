using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Utils
{
    public static class GetEnum
    {
        public static IEnumerable<EnumModel> SituacaoProduto()
        {
            var saida = new List<EnumModel>();
            saida.Add(new EnumModel { Valor = "novo", Exibir = "Novo" });
            saida.Add(new EnumModel { Valor = "used", Exibir = "Usado" });
            saida.Add(new EnumModel { Valor = "refurbished", Exibir = "Remanufaturado" });
            return saida;
        }

        public static List<EnumModel> TipoDados()
        {
            var saida = new List<EnumModel>();
            saida.Add(new EnumModel { Valor = "numero_inteiro", Exibir = "Inteiro" });
            saida.Add(new EnumModel { Valor = "numero_decimal", Exibir = "Decimal" });
            saida.Add(new EnumModel { Valor = "texto", Exibir = "Texto" });
            saida.Add(new EnumModel { Valor = "codigo_cor_hexadecimal", Exibir = "Código de Cor" });
            saida.Add(new EnumModel { Valor = "codigo_rgb", Exibir = "Cor RGB" });
            saida.Add(new EnumModel { Valor = "booleano", Exibir = "SIM/NÂO" });
            return saida;
        }
        public static List<EnumModel> TipoTelefones()
        {
            var saida = new List<EnumModel>();
            saida.Add(new EnumModel { Valor = "Residencial", Exibir = "Residencial" });
            saida.Add(new EnumModel { Valor = "Comercial", Exibir = "Comercial" });
            saida.Add(new EnumModel { Valor = "Movel", Exibir = "Movel" });
            return saida;
        }
    }
}
