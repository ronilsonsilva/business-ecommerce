using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories.Cliente;
using SCommerce.Domain.Interfaces.Repositories.Carrinho;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using bCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Interfaces.Repositories.OC;
using SCommerce.Domain.Interfaces.Repositories.Financeiro;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Entities.OC;

namespace bCommerce.b2SalesFashion.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ICarrinhoRepository _carrinhoRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IOCRepository _oCRepository;
        private readonly IOCDetalhesRepository _oCDetalhesRepository;
        private readonly IOCMensagemRepository _oCMensagemRepository;
        private readonly IOCPagamentoRepository _oCPagamentoRepository;
        private readonly IMetodoPagamentoRepository _metodoPagamentoRepository;
        private readonly IAnexoRepository _anexoRepository;

        public ClienteController(IClienteRepository clienteRepository, ICarrinhoRepository carrinhoRepository, IProdutoRepository produtoRepository, IOCRepository oCRepository, IOCDetalhesRepository oCDetalhesRepository, IOCMensagemRepository oCMensagemRepository, IOCPagamentoRepository oCPagamentoRepository, IMetodoPagamentoRepository metodoPagamentoRepository, IAnexoRepository anexoRepository)
        {
            _clienteRepository = clienteRepository;
            _carrinhoRepository = carrinhoRepository;
            _produtoRepository = produtoRepository;
            _oCRepository = oCRepository;
            _oCDetalhesRepository = oCDetalhesRepository;
            _oCMensagemRepository = oCMensagemRepository;
            _oCPagamentoRepository = oCPagamentoRepository;
            _metodoPagamentoRepository = metodoPagamentoRepository;
            _anexoRepository = anexoRepository;
        }

        public IActionResult Index()
        {
            var cliente = HttpContext.Session.GetString("cliente");
            if (cliente == null || cliente == String.Empty)
            {
                return RedirectToAction("Login");
            }
            DashboardCliente dashboardCliente = new DashboardCliente();
            dashboardCliente.Cliente = ClienteViewModel.Mapear(JsonConvert.DeserializeObject<Cliente>(cliente));
            var carrinho = _carrinhoRepository.GetCarrinho(dashboardCliente.Cliente.ID);
            if (carrinho != null)
            {
                foreach (var item in carrinho.CarrinhoProdutos)
                {
                    var produto = _produtoRepository.GetProduto(item.IdProduto);
                    item.Produto = produto;
                }
            }
            dashboardCliente.Carrinho = CarrinhoViewModel.Mapear(carrinho);
            var oc = _oCRepository.GetAll().Where(x => x.IdCliente == dashboardCliente.Cliente.ID);
            if (oc != null)
            {
                foreach (var item in oc)
                {
                    item.OCDetalhes = _oCDetalhesRepository.GetAll().Where(x => x.IdOC == item.ID).ToList();
                    if (item.OCDetalhes != null)
                    {
                        foreach (var item2 in item.OCDetalhes)
                        {
                            item2.Produto = _produtoRepository.GetById(item2.IdProduto);
                        }
                    }
                    item.OCMensagens = _oCMensagemRepository.GetAll().Where(x => x.IdOC == item.ID).OrderBy(x => x.Posicao).ToList();
                    if (item.OCMensagens != null)
                    {
                        foreach (var item2 in item.OCMensagens)
                        {
                            item2.Anexos = _anexoRepository.GetAll().Where(x => x.IdOCMensagem == item2.ID).ToList();
                        }
                    }
                }
                dashboardCliente.OCs = OCViewModel.Mapear(oc.ToList());
            }
            return View(dashboardCliente);
        }


        public IActionResult Registrar()
        {
            try
            {
                if (HttpContext.Session.GetString("cliente") != null && HttpContext.Session.GetString("cliente") != String.Empty)
                {
                    var cliente = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("cliente"));
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Alterar(DashboardCliente dashboardCliente)
        {
            try
            {
                var erro = new List<String>();
                if (String.IsNullOrEmpty(dashboardCliente.Cliente.Nome))
                {
                    erro.Add("Preencha o campo nome");
                }
                if (String.IsNullOrEmpty(dashboardCliente.Cliente.Email))
                {
                    erro.Add("Preencha o campo E-mail");
                }
                if (String.IsNullOrEmpty(dashboardCliente.Cliente.Senha))
                {
                    erro.Add("Preencha o campo Senha");
                }
                if (String.IsNullOrEmpty(dashboardCliente.Cliente.Senha1))
                {
                    erro.Add("Preencha o campo Senha");
                }
                if (dashboardCliente.Cliente.Senha != dashboardCliente.Cliente.Senha1)
                {
                    erro.Add("Senhas incompatível");
                    ViewBag.Error = erro;
                }
                if (erro.Count == 0)
                {
                    var cliente = _clienteRepository.GetById(dashboardCliente.Cliente.ID);
                    if (cliente != null)
                    {
                        cliente.Atualizado = dashboardCliente.Cliente.Atualizado;
                        cliente.ChaveSeguranca = Utils.StringExtension.ConvertToMD5(dashboardCliente.Cliente.Senha);
                        cliente.Email = dashboardCliente.Cliente.Email;
                        cliente.Nome = dashboardCliente.Cliente.Nome;
                        _clienteRepository.Update(cliente);
                    }
                }
                ViewBag.Error = erro;
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (!String.IsNullOrEmpty(clienteViewModel.Nome) && !String.IsNullOrEmpty(clienteViewModel.Email) && !String.IsNullOrEmpty(clienteViewModel.Senha) && clienteViewModel.Senha.Count() > 6)
                {
                    Cliente cliente = new Cliente(Guid.NewGuid())
                    {
                        Nome = clienteViewModel.Nome,
                        Email = clienteViewModel.Email,
                        Senha = Utils.StringExtension.ConvertToMD5(clienteViewModel.Senha),
                        NewsLetter = clienteViewModel.NewsLetter,
                        Cadastro = DateTime.Now,
                        Usuario = clienteViewModel.Email
                    };

                    _clienteRepository.Add(cliente);
                    HttpContext.Session.SetString("cliente", JsonConvert.SerializeObject(cliente));
                    return RedirectToAction("Index");
                }
                return View(clienteViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult Login(Boolean? redirectCarrinho = false)
        {
            try
            {
                var login = HttpContext.Session.GetString("cliente");
                ViewBag.redirectCarrinho = redirectCarrinho;
                if (HttpContext.Session.GetString("cliente") != null && HttpContext.Session.GetString("cliente") != String.Empty)
                {
                    var cliente = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("cliente"));
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(String usuario, String senha, Boolean redirectCarrinho)
        {
            try
            {
                var cliente = _clienteRepository.Login(usuario: usuario, senha: Utils.StringExtension.ConvertToMD5(senha));
                if (cliente != null)
                {
                    HttpContext.Session.SetString("cliente", JsonConvert.SerializeObject(cliente));
                    if (redirectCarrinho == true)
                    {
                        return RedirectToAction("Carrinho", "Home");
                    }
                    return RedirectToAction("Index");
                }
                ViewBag.MsgErroLogin = "Usuario ou senha incorreto";
                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult Sair()
        {
            try
            {
                if (HttpContext.Session.GetString("cliente") != null && HttpContext.Session.GetString("cliente") != String.Empty)
                {
                    HttpContext.Session.SetString("cliente", String.Empty);
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpGet]
        public ActionResult GetClienteSession()
        {
            try
            {
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                if (usuarioLogado != null && usuarioLogado != String.Empty)
                {
                    var cliente = JsonConvert.DeserializeObject<Cliente>(usuarioLogado);
                    return Json(cliente);
                }
                return Json("");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpGet]
        public ActionResult GetItensCarrinho()
        {
            try
            {
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                if (usuarioLogado != null && usuarioLogado != String.Empty)
                {
                    var cliente = JsonConvert.DeserializeObject<Cliente>(usuarioLogado);
                    var carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                    if (carrinho != null)
                    {
                        foreach (var item in carrinho.CarrinhoProdutos)
                        {
                            var produto = _produtoRepository.GetProduto(item.IdProduto);
                            if (produto != null)
                            {
                                foreach (var item2 in produto.imagens)
                                {
                                    item2.Produto = null;
                                }
                            }
                            item.Produto = produto;
                            item.Carrinho = null;
                        }
                    }
                    var saida = JsonConvert.SerializeObject(carrinho);
                    return Json(saida);
                }
                return Json("");
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
                var pos = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOC).Count();
                if (carregarMensagens)
                {
                    var ocSession = HttpContext.Session.GetString("idOCSelect");
                    var cliente = HttpContext.Session.GetString("cliente");
                    if (ocSession != null && cliente != null && cliente != String.Empty)
                    {
                        var emitente = JsonConvert.DeserializeObject<Cliente>(cliente);
                        idOC = Guid.Parse(JsonConvert.DeserializeObject<String>(ocSession));
                        List<OCMensagem> oCMensagens1 = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOC && x.idEmitente == emitente.ID).OrderBy(x => x.Posicao).ToList();
                        if (oCMensagens1 != null)
                        {
                            return Json(oCMensagens1);
                        }
                    }
                }
                OCMensagem oCMensagem = new OCMensagem(Guid.NewGuid())
                {
                    Data = DateTime.Now,
                    idEmitente = idEmitente,
                    IdOC = idOC,
                    Lida = false,
                    Privada = true,
                    Mensagem = texto,
                    Posicao = pos + 1
                };
                _oCMensagemRepository.Add(oCMensagem);
                List<OCMensagem> oCMensagens = _oCMensagemRepository.GetAll().Where(x => x.IdOC == idOC && x.idEmitente == idEmitente).OrderBy(x => x.Posicao).ToList();
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