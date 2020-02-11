using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.Carrinho;
using SCommerce.Domain.Interfaces.Repositories.OC;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PedidosController : BaseController
    {
        IOCRepository _oCRepository;
        IOCDetalhesRepository _oCDetalhesRepository;
        ICarrinhoRepository _carrinhoRepository;
        ICarrinhoProdutoRepository _carrinhoProdutoRepository;
        IProdutoRepository _produtoRepository;
        IOCStatusRepository _oCStatusRepository;
        IOCMensagemRepository _oCMensagemRepository;
        IAnexoRepository _anexoRepository;
        IMapper _mapper;

        public PedidosController(IOCRepository oCRepository, IOCDetalhesRepository oCDetalhesRepository, ICarrinhoRepository carrinhoRepository, ICarrinhoProdutoRepository carrinhoProdutoRepository, IProdutoRepository produtoRepository, IOCStatusRepository oCStatusRepository, IOCMensagemRepository oCMensagemRepository, IAnexoRepository anexoRepository, IMapper mapper)
        {
            _oCRepository = oCRepository;
            _oCDetalhesRepository = oCDetalhesRepository;
            _carrinhoRepository = carrinhoRepository;
            _carrinhoProdutoRepository = carrinhoProdutoRepository;
            _produtoRepository = produtoRepository;
            _oCStatusRepository = oCStatusRepository;
            _oCMensagemRepository = oCMensagemRepository;
            _anexoRepository = anexoRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        public IActionResult Pedidos()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PedidosViewModel pedidosViewModel = new PedidosViewModel();
                pedidosViewModel.OCs = OCViewModel.Mapear(_oCRepository.GetOCs().ToList());
                foreach (var item in pedidosViewModel.OCs)
                {
                    foreach (var item2 in item.OCDetalhes)
                    {
                        item2.Produto = ProdutoViewModel.Mapear(_produtoRepository.GetById(item2.IdProduto));
                    }
                }
                return View(pedidosViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult OCDetalhes(Guid idOC)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                OCViewModel oCViewModel = OCViewModel.Mapear(_oCRepository.GetOC(idOC));
                foreach (var item in oCViewModel.OCDetalhes)
                {
                    item.Produto = ProdutoViewModel.Mapear(_produtoRepository.GetById(item.IdProduto));
                }
                return View(oCViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult AlterarOC(OCViewModel oCViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocStatus = _oCStatusRepository.GetById(oCViewModel.IdOCStatus);
                if (ocStatus != null)
                {
                    ocStatus.Cancelado = oCViewModel.OCStatus.Cancelado;
                    ocStatus.Deletado = oCViewModel.OCStatus.Deletado;
                    ocStatus.Entregado = oCViewModel.OCStatus.Entregado;
                    ocStatus.Enviado = oCViewModel.OCStatus.Enviado;
                    ocStatus.Faturado = oCViewModel.OCStatus.Faturado;
                    ocStatus.Pago = oCViewModel.OCStatus.Pago;
                    ocStatus.Oculto = oCViewModel.OCStatus.Oculto;
                    ocStatus.Logable = oCViewModel.OCStatus.Logable;
                    _oCStatusRepository.Update(ocStatus);
                }
                return RedirectToAction("OCDetalhes", new { idOC = oCViewModel.ID });
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult AlterarItemOC(Guid idOCDetalhes)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocDetalhes = _oCDetalhesRepository.GetOCDetalhes(idOCDetalhes);
                OCDetalhesViewModel oCDetalhesViewModel =  OCDetalhesViewModel.Mapear(ocDetalhes);
                oCDetalhesViewModel.OC = OCViewModel.Mapear(ocDetalhes.OC);
                return View(oCDetalhesViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AlterarItemOC(OCDetalhesViewModel oCDetalhesViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocDetalhes = _oCDetalhesRepository.GetById(oCDetalhesViewModel.ID);
                ocDetalhes.Quantidade = oCDetalhesViewModel.Quantidade;
                _oCDetalhesRepository.Update(ocDetalhes);
                return RedirectToAction("OCDetalhes", new { idOC = oCDetalhesViewModel.IdOC });
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult ExcluirItemOC(Guid idOCDetalhes)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocDetalhes = _oCDetalhesRepository.GetOCDetalhes(idOCDetalhes);
                OCDetalhesViewModel oCDetalhesViewModel = OCDetalhesViewModel.Mapear(ocDetalhes);
                return View(oCDetalhesViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExcluirItemOC(OCDetalhesViewModel oCDetalhesViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocDetalhes = _oCDetalhesRepository.GetById(oCDetalhesViewModel.ID);
                if (ocDetalhes != null)
                {
                    _oCDetalhesRepository.Remove(ocDetalhes);
                }
                return RedirectToAction("OCDetalhes", new { idOC = oCDetalhesViewModel.IdOC });
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult Carrinhos()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult AdicionarItens(Guid idOC)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                OCViewModel oCViewModel = new OCViewModel();

                return View(oCViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarItens(OCViewModel oCViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                return View(oCViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult MensagensOC(Guid idOC)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var oc = _oCRepository.GetOC(idOC);
                OCViewModel oCViewModel = OCViewModel.Mapear(oc);
                if (oCViewModel.OCMensagens != null)
                {
                    foreach (var item in oCViewModel.OCMensagens)
                    {
                        item.Anexos = AnexoViewModel.Mapear(_anexoRepository.GetAll().Where(x => x.IdOCMensagem == item.ID).ToList());
                    }
                }
                oCViewModel.OCMensagens = oCViewModel.OCMensagens.OrderBy(x => x.Posicao).ToList();
                HttpContext.Session.SetString("idOCSelect", JsonConvert.SerializeObject(oc.ID));
                return View(oCViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult UploadArquivoChat(string qquuid, string qqfilename, int qqtotalfilesize, IFormFile qqfile)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var ocSession = HttpContext.Session.GetString("idOCSelect");
                var cliente = HttpContext.Session.GetString("empregado");
                if (ocSession != null && cliente != null && cliente != String.Empty)
                {
                    Guid idOC = Guid.Parse(JsonConvert.DeserializeObject<String>(ocSession));
                    var emitente = JsonConvert.DeserializeObject<Cliente>(cliente);
                    var pos = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOC).Count();
                    OCMensagem oCMensagem = new OCMensagem(Guid.NewGuid())
                    {
                        Data = DateTime.Now,
                        idEmitente = emitente.ID,
                        IdOC = idOC,
                        Lida = false,
                        Privada = true,
                        Mensagem = "",
                        Posicao = pos + 1
                    };
                    if (qqfile != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        qqfile.OpenReadStream().CopyTo(ms);
                        Anexo anexo = new Anexo(Guid.NewGuid())
                        {
                            Arquivo = ms.ToArray(),
                            IdOCMensagem = oCMensagem.ID,
                            Nome = qqfilename,
                            Tipo = qqfile.ContentType
                        };
                        _oCMensagemRepository.Add(oCMensagem);
                        _anexoRepository.Add(anexo);
                        return Json(new { success = "true" });
                    }
                }
                return Json(new { success = "false", error = "Erro ao salvar arquivo." });
            }
            catch (Exception erro)
            {
                return Json(new { success = "false", error = erro.Message });
            }
        }

        [HttpPost]
        public void SetarOCChat(Guid idOC)
        {
            try
            {
                HttpContext.Session.SetString("idOCSelect", JsonConvert.SerializeObject(idOC));
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult BaixarAnexo(Guid idAnexo)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idAnexo == null || idAnexo == Guid.Empty)
                {
                    throw new Exception("Verificar existencia de arquivo");
                }
                var arquivo = _anexoRepository.GetById(idAnexo);
                return File(arquivo.Arquivo, arquivo.Tipo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        public IActionResult EnviarMensagem(String texto, Guid idOC, Guid idEmitente, Boolean carregarMensagens = false)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var pos = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOC).Count();
                var ocSession = HttpContext.Session.GetString("idOCSelect");
                Guid idOCSelected = Guid.Parse(JsonConvert.DeserializeObject<Guid>(ocSession).ToString());
                var empregado = HttpContext.Session.GetString("empregado");
                var usuario = JsonConvert.DeserializeObject<Empregado>(empregado);
                if (carregarMensagens)
                {
                    if (ocSession != null && empregado != null && empregado != String.Empty)
                    {
                        var emitente = JsonConvert.DeserializeObject<Cliente>(empregado);
                        idOC = Guid.Parse(JsonConvert.DeserializeObject<String>(ocSession));
                        List<OCMensagem> oCMensagens1 = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOCSelected).OrderBy(x => x.Posicao).ToList();
                        if (oCMensagens1 != null)
                        {
                            return Json(oCMensagens1);
                        }
                    }
                }
                OCMensagem oCMensagem = new OCMensagem(Guid.NewGuid())
                {
                    Data = DateTime.Now,
                    idEmitente = usuario.ID,
                    IdOC = idOC,
                    Lida = false,
                    Privada = true,
                    Mensagem = texto,
                    Posicao = pos + 1
                };
                _oCMensagemRepository.Add(oCMensagem);
                List<OCMensagem> oCMensagens = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOCSelected).OrderBy(x => x.Posicao).ToList();
                if (oCMensagens != null)
                {
                    return Json(oCMensagens);
                }
                return Json("");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }

    
}