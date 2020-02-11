using SCommerce.Domain.Entities.OC;
using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class OCViewModel : BaseViewModels
    {
        public String Referencia { get; set; }
        public String NumeroEnvio { get; set; }
        public Decimal DescontoTotal { get; set; }
        public Decimal PagamentoTotal { get; set; }
        public Decimal PagamentoReal { get; set; }
        public Decimal ProdutoTotal { get; set; }
        public Decimal TotalEnviado { get; set; }
        public DateTime DataEnvio { get; set; }
        public Boolean Valido { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }

        public Guid IdMetotoPagamento { get; set; }
        public MetodoPagamentoViewModel MetodoPagamento { get; set; }
        public Guid IdLoja { get; set; }
        public LojaViewModel Loja { get; set; }
        public Guid IdCliente { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public Guid IdOCStatus { get; set; }
        public OCStatusViewModel OCStatus { get; set; }

        //public ICollection<OCFatura> OCFaturas { get; set; }
        //public ICollection<EmpregadoOC> EmpregadoOCs { get; set; }
        //public ICollection<ClienteProcesso> ClienteProcessos { get; set; }
        public ICollection<OCDetalhesViewModel> OCDetalhes { get; set; }
        public ICollection<OCMensagemViewModel> OCMensagens { get; set; }
        //public ICollection<Entrega> Entregas { get; set; }
        

        public static OCViewModel Mapear(OC oC)
        {
            try
            {
                var saida = new OCViewModel();
                if (oC != null)
                {
                    saida = new OCViewModel()
                    {
                        Atualizado = oC.Atualizado,
                        Cadastro = oC.Cadastro,
                        Cliente = ClienteViewModel.Mapear(oC.Cliente),
                        DataEnvio = oC.DataEnvio,
                        DescontoTotal = oC.DescontoTotal,
                        ID = oC.ID,
                        IdCliente = oC.IdCliente.Value,
                        IdLoja = oC.IdLoja.Value,
                        IdMetotoPagamento = oC.IdMetotoPagamento != null ? oC.IdMetotoPagamento.Value : Guid.Empty,
                        IdOCStatus = oC.IdOCStatus != null ? oC.IdOCStatus.Value : Guid.Empty,
                        Loja = LojaViewModel.Mapear(oC.Loja),
                        MetodoPagamento = MetodoPagamentoViewModel.Mapear(oC.MetodoPagamento),
                        NumeroEnvio = oC.NumeroEnvio,
                        OCStatus = OCStatusViewModel.Mapear(oC.OCStatus),
                        PagamentoReal = oC.PagamentoReal,
                        PagamentoTotal = oC.PagamentoTotal,
                        ProdutoTotal = oC.ProdutoTotal,
                        Referencia = oC.Referencia,
                        TotalEnviado = oC.TotalEnviado,
                        Valido = oC.Valido,
                        OCDetalhes = OCDetalhesViewModel.Mapear(oC.OCDetalhes),
                        OCMensagens = OCMensagemViewModel.Mapear(oC.OCMensagens)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<OCViewModel> Mapear(List<OC> oCs)
        {
            try
            {
                var saida = new List<OCViewModel>();
                if (oCs != null)
                {
                    foreach (var item in oCs)
                    {
                        var oc = Mapear(item);
                        saida.Add(oc);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public static OC Mapear(OCViewModel oC)
        {
            try
            {
                var saida = new OC(Guid.Empty);
                if (oC != null)
                {
                    saida = new OC(Guid.Empty)
                    {
                        Atualizado = oC.Atualizado,
                        Cadastro = oC.Cadastro,
                        Cliente = ClienteViewModel.Mapear(oC.Cliente),
                        DataEnvio = oC.DataEnvio,
                        DescontoTotal = oC.DescontoTotal,
                        ID = oC.ID,
                        IdCliente = oC.IdCliente,
                        IdLoja = oC.IdLoja,
                        IdMetotoPagamento = oC.IdMetotoPagamento,
                        IdOCStatus = oC.IdOCStatus,
                        Loja = LojaViewModel.Mapear(oC.Loja),
                        MetodoPagamento = MetodoPagamentoViewModel.Mapear(oC.MetodoPagamento),
                        NumeroEnvio = oC.NumeroEnvio,
                        OCStatus = OCStatusViewModel.Mapear(oC.OCStatus),
                        PagamentoReal = oC.PagamentoReal,
                        PagamentoTotal = oC.PagamentoTotal,
                        ProdutoTotal = oC.ProdutoTotal,
                        Referencia = oC.Referencia,
                        TotalEnviado = oC.TotalEnviado,
                        Valido = oC.Valido,
                        OCDetalhes = OCDetalhesViewModel.Mapear(oC.OCDetalhes),
                        OCMensagens = OCMensagemViewModel.Mapear(oC.OCMensagens)
                    };
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<OC> Mapear(List<OCViewModel> oCs)
        {
            try
            {
                var saida = new List<OC>();
                if (oCs != null)
                {
                    foreach (var item in oCs)
                    {
                        var oc = Mapear(item);
                        saida.Add(oc);
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
