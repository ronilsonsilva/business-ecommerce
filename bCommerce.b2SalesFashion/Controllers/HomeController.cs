using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bCommerce.b2SalesFashion.Models;
using AutoMapper;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.Fabricante;
using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.Produto;
using System.Collections.ObjectModel;
using bCommerce.b2SalesFashion.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories.Carrinho;
using SCommerce.Domain.Interfaces.Repositories.OC;
using SCommerce.Domain.Entities.Carrinho;
using SCommerce.Domain.Entities.OC;
using SCommerce.Domain.Interfaces.Repositories.Financeiro;
using System.IO;
using SCommerce.Domain.Entities.CadastroBase;

namespace bCommerce.b2SalesFashion.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoImagemRepository _produtoImagemRepository;
        private readonly IProdutoPropriedadeRepository _produtoPropriedadeRepository;
        private readonly IFabricanteRepository _fabricanteRepository;
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly IPropriedadeValorRepository _propriedadeValorRepository;
        private readonly ILojaRepository _lojaRepository;
        private readonly ICarrinhoRepository _carrinhoRepository;
        private readonly ICarrinhoProdutoRepository _carrinhoProdutoRepository;
        private readonly IOCRepository _oCRepository;
        private readonly IOCDetalhesRepository _oCDetalhesRepository;
        private readonly IOCMensagemRepository _oCMensagemRepository;
        private readonly IOCPagamentoRepository _oCPagamentoRepository;
        private readonly IMetodoPagamentoRepository _metodoPagamentoRepository;
        private readonly IAnexoRepository _anexoRepository;
        private readonly IMapper _mapper;

        public HomeController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IProdutoImagemRepository produtoImagemRepository, IProdutoPropriedadeRepository produtoPropriedadeRepository, IFabricanteRepository fabricanteRepository, IPropriedadeRepository propriedadeRepository, IPropriedadeValorRepository propriedadeValorRepository, ILojaRepository lojaRepository, ICarrinhoRepository carrinhoRepository, ICarrinhoProdutoRepository carrinhoProdutoRepository, IOCRepository oCRepository, IOCDetalhesRepository oCDetalhesRepository, IOCMensagemRepository oCMensagemRepository, IOCPagamentoRepository oCPagamentoRepository, IMetodoPagamentoRepository metodoPagamentoRepository, IAnexoRepository anexoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _produtoImagemRepository = produtoImagemRepository;
            _produtoPropriedadeRepository = produtoPropriedadeRepository;
            _fabricanteRepository = fabricanteRepository;
            _propriedadeRepository = propriedadeRepository;
            _propriedadeValorRepository = propriedadeValorRepository;
            _lojaRepository = lojaRepository;
            _carrinhoRepository = carrinhoRepository;
            _carrinhoProdutoRepository = carrinhoProdutoRepository;
            _oCRepository = oCRepository;
            _oCDetalhesRepository = oCDetalhesRepository;
            _oCMensagemRepository = oCMensagemRepository;
            _oCPagamentoRepository = oCPagamentoRepository;
            _metodoPagamentoRepository = metodoPagamentoRepository;
            _anexoRepository = anexoRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("cliente") != null)
            {
                
            }
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel();
            this.ConfigurarSlidesProdutos(homeIndexViewModel);
            this.GetProdutosPromocao(homeIndexViewModel);
            this.GetProdutosMaisVendidos(homeIndexViewModel);
            return View(homeIndexViewModel);
        }

        public void GetProdutosPromocao(HomeIndexViewModel homeIndexViewModel)
        {
            try
            {
                var ultimosProdutos = _produtoRepository.GetAll().ToList();
                homeIndexViewModel.PromocaoHomeIndexViewModels = new List<PromocaoHomeIndexViewModel>();
                foreach (var item in ultimosProdutos)
                {
                    var produto = new PromocaoHomeIndexViewModel
                    {
                        ID = item.ID,
                        DescricaoCurta = item.DescricaoCurta,
                        IdCategoriaPadrao = item.IdCategoriaPadrao,
                        Nome = item.Nome,
                        NomeExibicao = item.NomeExibicao,
                        Preco = item.Preco,
                        PrecoAtacado = item.PrecoAtacado
                    };
                    produto.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, IEnumerable<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item.ID)).ToList();
                    homeIndexViewModel.PromocaoHomeIndexViewModels.Add(produto);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GetProdutosMaisVendidos(HomeIndexViewModel homeIndexViewModel)
        {
            try
            {
                var ultimosProdutos = _produtoRepository.GetAll().ToList();
                homeIndexViewModel.ProdutosMaisVendidos = new List<ProdutosMaisVendidos>();
                foreach (var item in ultimosProdutos)
                {
                    var produto = new ProdutosMaisVendidos
                    {
                        ID = item.ID,
                        DescricaoCurta = item.DescricaoCurta,
                        IdCategoriaPadrao = item.IdCategoriaPadrao,
                        Nome = item.Nome,
                        NomeExibicao = item.NomeExibicao,
                        Preco = item.Preco,
                        PrecoAtacado = item.PrecoAtacado
                    };
                    produto.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, IEnumerable<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item.ID)).ToList();
                    homeIndexViewModel.ProdutosMaisVendidos.Add(produto);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void ConfigurarSlidesProdutos(HomeIndexViewModel homeIndexViewModel)
        {
            try
            {
                var categoriasRoot = _categoriaRepository.GetAll().ToList();
                homeIndexViewModel.CategoriasHomeViewModels = new List<CategoriasHomeViewModel>();
                foreach (var item in categoriasRoot)
                {
                    var categoria = new CategoriasHomeViewModel()
                    {
                        ID = item.ID,
                        Ativo = item.Ativo,
                        Atualizado = item.Atualizado,
                        Cadastro = item.Cadastro,
                        IdCategoriaPai = item.IDCategoriaPai,
                        Nome = item.Nome,
                        Produtos = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetProdutosDaCategoria(item.ID)).ToList()
                    };
                    foreach (var item2 in categoria.Produtos)
                    {
                        item2.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, ICollection<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item2.ID));
                    }
                    homeIndexViewModel.CategoriasHomeViewModels.Add(categoria);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Produto(Guid idProduto)
        {
            try
            {
                if (idProduto == Guid.Empty || idProduto == null)
                {
                    return NotFound();
                }
                ProdutoViewModel produtoViewModel = _mapper.Map<Produto, ProdutoViewModel>(_produtoRepository.GetById(idProduto));
                if (produtoViewModel == null)
                {
                    return NotFound();
                }
                var produtoPropriedades = _produtoPropriedadeRepository.GetPorProduto(idProduto)?.ToList();
                foreach (var item in produtoPropriedades)
                {
                    if (produtoViewModel.ProdutoPropriedadesViewmodel == null)
                    {
                        produtoViewModel.ProdutoPropriedadesViewmodel = new List<ProdutoPropriedadeViewModel>();
                    }
                    item.Propriedade = _propriedadeRepository.GetById(item.IdPropriedade);
                    item.Propriedade.propriedadeValors = _propriedadeValorRepository.GetByPropriedade(item.IdPropriedade);
                    produtoViewModel.ProdutoPropriedadesViewmodel.Add(_mapper.Map<ProdutoPropriedade, ProdutoPropriedadeViewModel>(item));
                }
                var produtoImagens = _produtoImagemRepository.GetPorProduto(idProduto)?.ToList();
                foreach (var item in produtoImagens)
                {
                    if (produtoViewModel.imagensProduto == null)
                    {
                        produtoViewModel.imagensProduto = new Collection<ProdutoImagemViewModel>();
                    }
                    produtoViewModel.imagensProduto.Add(_mapper.Map<ProdutoImagem, ProdutoImagemViewModel>(item));
                }
                produtoViewModel.CategoriaPadrao = _mapper.Map<Categoria, CategoriaViewModel>(_categoriaRepository.GetById(produtoViewModel.IdCategoriaPadrao));
                ConfigViewProduto(produtoViewModel);
                return View(produtoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void ConfigViewProduto(ProdutoViewModel produtoViewModel)
        {
            try
            {
                var produtosSimilares = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetProdutosDaCategoria(produtoViewModel.IdCategoriaPadrao));
                foreach (var item in produtosSimilares)
                {
                    if (item.imagensProduto == null)
                    {
                        item.imagensProduto = new Collection<ProdutoImagemViewModel>();
                    }
                    item.imagensProduto = _mapper.Map<ICollection<ProdutoImagem>, ICollection<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item.ID).ToList());
                }
                ViewBag.ProdutosSimilares = produtosSimilares.ToList();

                ViewBag.ProdutosPromocional = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAll());

                ViewBag.OutrosProdutos = _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaRepository.GetIrmaosDaCategoriasRoot(produtoViewModel.IdCategoriaPadrao));
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Loja(Guid? idCategoria = null, String palavraChave = "", String btnSubmit = "")
        {
            try
            {
                if (btnSubmit != null && btnSubmit.Equals("cadastrarEmail"))
                {
                    return RedirectToAction("Index");
                }
                LojaHomeViewModel lojaHomeViewModel = new LojaHomeViewModel();

                if (idCategoria != null && idCategoria != Guid.Empty)
                {
                    var categoria = _categoriaRepository.GetById(idCategoria.Value);

                    lojaHomeViewModel.NomeCategoria = categoria?.Nome;
                    lojaHomeViewModel.IdCategoria = categoria?.ID;
                    if (palavraChave != null && !palavraChave.Equals(""))
                    {
                        this.ConfigurarListaProdutos(ref lojaHomeViewModel, idCategoria.Value, palavraChave);
                    }
                    else
                    {
                        this.ConfigurarListaProdutos(ref lojaHomeViewModel, idCategoria.Value);
                    }
                }
                else if (palavraChave != null && !palavraChave.Equals(""))
                {
                    this.ConfigurarListaProdutos(ref lojaHomeViewModel, palavraChave);
                }
                else
                {
                    this.ConfigurarListaProdutos(ref lojaHomeViewModel, palavraChave);
                }
                this.GetCategorias(ref lojaHomeViewModel, idCategoria);
                return View(lojaHomeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adiciona no model a lista de categorias.
        /// </summary>
        /// <param name="lojaHomeViewModel"></param>
        /// <param name="idCategoria"></param>
        public void GetCategorias(ref LojaHomeViewModel lojaHomeViewModel, Guid? idCategoria = null)
        {
            try
            {
                var categorias = new List<Categoria>();
                if (idCategoria != null && idCategoria != Guid.Empty)
                {
                    var categoria = _categoriaRepository.GetById(idCategoria.Value);
                    if (categoria != null)
                    {
                        categorias = _categoriaRepository.GetIrmaosDaCategoriasRoot(categoria.IDCategoriaPai).ToList();
                    }
                }
                else
                {
                    categorias = _categoriaRepository.GetAll().ToList();
                }

                foreach (var item in categorias)
                {
                    if (lojaHomeViewModel.CategoriasHomeViewModels == null)
                    {
                        lojaHomeViewModel.CategoriasHomeViewModels = new List<CategoriasLojaViewModel>();
                    }
                    lojaHomeViewModel.CategoriasHomeViewModels.Add(new CategoriasLojaViewModel()
                    {
                        Ativo = item.Ativo,
                        ID = item.ID,
                        IdCategoriaPai = item.IDCategoriaPai,
                        Nome = item.Nome
                    });
                }
            }
            catch (Exception erro)
            {
                throw;
            }
        }

        /// <summary>
        /// Carregar produtos pela categoria e palavra chave
        /// </summary>
        /// <param name="lojaHomeViewModel"></param>
        /// <param name="idCategoria"></param>
        private void ConfigurarListaProdutos(ref LojaHomeViewModel lojaHomeViewModel, Guid idCategoria, String palavraChave)
        {
            try
            {
                var categoria = _categoriaRepository.GetById(idCategoria);
                lojaHomeViewModel.CategoriasHomeViewModels = new List<CategoriasLojaViewModel>();
                if (categoria != null)
                {
                    CategoriasLojaViewModel categoriasLojaViewModel = new CategoriasLojaViewModel();
                    categoriasLojaViewModel.ID = categoria.ID;
                    categoriasLojaViewModel.Nome = categoria.Nome;
                    lojaHomeViewModel.Produtos = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetProdutosDaCategoria(categoria.ID))
                        .Where(x => x.Nome.Contains(palavraChave) || x.NomeExibicao.Contains(palavraChave) || x.DescricaoCurta.Contains(palavraChave)
                        || x.EAN13.Contains(palavraChave) || x.Referencia.Contains(palavraChave)).ToList();
                    foreach (var item2 in lojaHomeViewModel.Produtos)
                    {
                        item2.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, ICollection<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item2.ID));
                    }
                }

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        /// <summary>
        /// Carregar produtos  palavra chave
        /// </summary>
        /// <param name="lojaHomeViewModel"></param>
        /// <param name="idCategoria"></param>
        private void ConfigurarListaProdutos(ref LojaHomeViewModel lojaHomeViewModel, String palavraChave)
        {
            try
            {
                lojaHomeViewModel.Produtos = new List<ProdutoViewModel>();
                lojaHomeViewModel.Produtos = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAll())
                        .Where(x => x.Nome.Contains(palavraChave) || x.NomeExibicao.Contains(palavraChave) || x.DescricaoCurta.Contains(palavraChave)
                        || x.EAN13.Contains(palavraChave) || x.Fabricante.Nome.Contains(palavraChave) || x.Referencia.Contains(palavraChave)).ToList();
                foreach (var item2 in lojaHomeViewModel.Produtos)
                {
                    item2.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, ICollection<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item2.ID));
                }

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Carregar produtos pela categoria
        /// </summary>
        /// <param name="lojaHomeViewModel"></param>
        /// <param name="idCategoria"></param>
        private void ConfigurarListaProdutos(ref LojaHomeViewModel lojaHomeViewModel, Guid idCategoria)
        {
            try
            {
                var categoria = _categoriaRepository.GetById(idCategoria);
                lojaHomeViewModel.CategoriasHomeViewModels = new List<CategoriasLojaViewModel>();
                if (categoria != null)
                {
                    CategoriasLojaViewModel categoriasLojaViewModel = new CategoriasLojaViewModel();
                    categoriasLojaViewModel.ID = categoria.ID;
                    categoriasLojaViewModel.Nome = categoria.Nome;
                    lojaHomeViewModel.Produtos = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetProdutosDaCategoria(categoria.ID)).ToList();
                    foreach (var item2 in lojaHomeViewModel.Produtos)
                    {
                        item2.imagensProduto = _mapper.Map<IEnumerable<ProdutoImagem>, ICollection<ProdutoImagemViewModel>>(_produtoImagemRepository.GetPorProduto(item2.ID));
                    }
                }

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public IActionResult Carrinho()
        {
            try
            {
                CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(Guid.Empty);
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                if (usuarioLogado == null || usuarioLogado == String.Empty)
                {
                    return RedirectToAction("Login", "Cliente", new { redirectCarrinho = true });
                }
                var cliente = JsonConvert.DeserializeObject<Cliente>(usuarioLogado);
                var produtoSession = HttpContext.Session.GetString("produtoCarrinho");
                var quantidadeProduto = HttpContext.Session.GetString("quantidadeProduto");
                if (produtoSession != null && produtoSession != "null")
                {
                    Guid idProduto = Guid.Parse(JsonConvert.DeserializeObject<String>(produtoSession));
                    if (idProduto != Guid.Empty)
                    {
                        var carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                        if (carrinho == null)
                        {
                            carrinho = new SCommerce.Domain.Entities.Carrinho.Carrinho(Guid.NewGuid());
                            carrinho.IdCliente = cliente.ID;
                            carrinho.IdLoja = _lojaRepository.GetAll().FirstOrDefault().ID;
                            _carrinhoRepository.Add(carrinho);
                        }
                        CarrinhoProduto carrinhoProduto = new CarrinhoProduto(Guid.NewGuid());
                        carrinhoProduto.IdCarrinho = carrinho.ID;
                        carrinhoProduto.IdProduto = idProduto;
                        if (quantidadeProduto != null)
                        {
                            carrinhoProduto.Quantidade = JsonConvert.DeserializeObject<int>(quantidadeProduto);
                        }
                        else
                        {
                            carrinhoProduto.Quantidade = 1;
                        }
                        carrinhoProduto.Atualizado = DateTime.Now;
                        if (carrinho.CarrinhoProdutos.Where(x => x.IdProduto == idProduto).Count() > 0)
                        {
                            carrinhoProduto = carrinho.CarrinhoProdutos.Where(x => x.IdProduto == idProduto).FirstOrDefault();
                            if (quantidadeProduto != null)
                            {
                                carrinhoProduto.Quantidade += JsonConvert.DeserializeObject<int>(quantidadeProduto);
                            }
                            else
                            {
                                carrinhoProduto.Quantidade += 1;
                            }
                            _carrinhoProdutoRepository.Update(carrinhoProduto);
                        }
                        else
                        {
                            _carrinhoProdutoRepository.Add(carrinhoProduto);
                        }
                        carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                        carrinhoViewModel = CarrinhoViewModel.Mapear(carrinho);
                        HttpContext.Session.SetString("produtoCarrinho", JsonConvert.SerializeObject(null));
                        HttpContext.Session.SetString("quantidadeProduto", JsonConvert.SerializeObject(null));
                    }
                }
                var carrinhoEntity = _carrinhoRepository.GetCarrinho(cliente.ID);
                if (carrinhoEntity != null)
                {
                    foreach (var item in carrinhoEntity.CarrinhoProdutos)
                    {
                        var produto = _produtoRepository.GetProduto(item.IdProduto);
                        item.Produto = produto;
                    }
                    carrinhoViewModel = CarrinhoViewModel.Mapear(carrinhoEntity);
                }
                
                return View(carrinhoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public Carrinho GetCarrinho()
        {
            try
            {
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                var cliente = JsonConvert.DeserializeObject<Cliente>(usuarioLogado);
                var carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                foreach (var item in carrinho.CarrinhoProdutos)
                {
                    var produto = _produtoRepository.GetProduto(item.IdProduto);
                    item.Produto = produto;
                }
                return carrinho;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adicionar novo produto no carrinho
        /// </summary>
        /// <param name="idProduto"></param>
        public IActionResult AddCarrinho(Guid idProduto, int? quantidade = 1)
        {
            try
            {
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                if (usuarioLogado == null || usuarioLogado == String.Empty)
                {
                    HttpContext.Session.SetString("produtoCarrinho", JsonConvert.SerializeObject(idProduto));
                    HttpContext.Session.SetString("quantidadeProduto", JsonConvert.SerializeObject(quantidade));
                    return RedirectToAction("Login", "Cliente", new { redirectCarrinho = true });
                }
                var cliente = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("cliente"));
                var carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                if (carrinho == null)
                {
                    carrinho = new SCommerce.Domain.Entities.Carrinho.Carrinho(Guid.NewGuid());
                    carrinho.Atualizado = DateTime.Now;
                    carrinho.Cadastro = DateTime.Now;
                    carrinho.IdCliente = cliente.ID;
                    carrinho.IdLoja = _lojaRepository.GetAll().FirstOrDefault().ID;
                    
                    _carrinhoRepository.Add(carrinho);
                }
                CarrinhoProduto carrinhoProduto = new CarrinhoProduto(Guid.NewGuid());
                carrinhoProduto.IdCarrinho = carrinho.ID;
                carrinhoProduto.IdProduto = idProduto;
                carrinhoProduto.Quantidade = quantidade.Value;
                carrinhoProduto.Atualizado = DateTime.Now;
                if (carrinho.CarrinhoProdutos?.Where(x => x.IdProduto == idProduto).Count() > 0)
                {
                    carrinhoProduto = carrinho.CarrinhoProdutos.Where(x => x.IdProduto == idProduto).FirstOrDefault();
                    carrinhoProduto.Quantidade += quantidade.Value;
                    _carrinhoProdutoRepository.Update(carrinhoProduto);
                }
                else
                {
                    _carrinhoProdutoRepository.Add(carrinhoProduto); 
                }
                
                return RedirectToAction("Produto", new { idProduto = idProduto });
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        public IActionResult AdicionarProdutoCarrinho(Guid idProduto)
        {
            try
            {
                var usuarioLogado = HttpContext.Session.GetString("cliente");
                if (usuarioLogado == null || usuarioLogado == String.Empty)
                {
                    HttpContext.Session.SetString("produtoCarrinho", JsonConvert.SerializeObject(idProduto));
                    return Json("Usuário deve acessar sua conta");
                }
                var cliente = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("cliente"));
                var carrinho = _carrinhoRepository.GetCarrinho(cliente.ID);
                if (carrinho == null)
                {
                    carrinho = new SCommerce.Domain.Entities.Carrinho.Carrinho(Guid.NewGuid());
                    carrinho.Atualizado = DateTime.Now;
                    carrinho.Cadastro = DateTime.Now;
                    carrinho.IdCliente = cliente.ID;
                    carrinho.IdLoja = _lojaRepository.GetAll().FirstOrDefault().ID;

                    _carrinhoRepository.Add(carrinho);
                }
                CarrinhoProduto carrinhoProduto = new CarrinhoProduto(Guid.NewGuid());
                carrinhoProduto.IdCarrinho = carrinho.ID;
                carrinhoProduto.IdProduto = idProduto;
                carrinhoProduto.Quantidade = 1;
                carrinhoProduto.Atualizado = DateTime.Now;
                if (carrinho.CarrinhoProdutos?.Where(x => x.IdProduto == idProduto).Count() > 0)
                {
                    carrinhoProduto = carrinho.CarrinhoProdutos.Where(x => x.IdProduto == idProduto).FirstOrDefault();
                    carrinhoProduto.Quantidade += 1;
                    _carrinhoProdutoRepository.Update(carrinhoProduto);
                }
                else
                {
                    _carrinhoProdutoRepository.Add(carrinhoProduto);
                }
                return Json("");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult AlterarQuantidadeProduto(Guid idCarrinhoProduto, int quantidade)
        {
            try
            {
                if (quantidade < 1)
                {
                    return Json("Error -> quantidade de produto deve ser superior a 1");
                }
                var produto = _carrinhoProdutoRepository.GetById(idCarrinhoProduto);
                var preco = _produtoRepository.GetById(produto.IdProduto)?.Preco;
                if (produto != null)
                {
                    produto.Quantidade = quantidade;
                }
                else
                {
                    return Json("Error -> Produto não existe!!");
                }
                _carrinhoProdutoRepository.Update(produto);
                return Json(preco);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult ExcluirProduto(Guid idProduto)
        {
            try
            {
                var carrinhoProduto = _carrinhoProdutoRepository.GetById(idProduto);
                if (carrinhoProduto != null)
                {
                    _carrinhoProdutoRepository.Remove(carrinhoProduto);
                }
                //var carrinho = GetCarrinho();
                return Json(true);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        

        public IActionResult GerarOC(Guid idCarrinho)
        {
            try
            {
                if (idCarrinho != null && idCarrinho != Guid.Empty)
                {
                    var carrinho = _carrinhoRepository.GetCarrinhoDoCliente(idCarrinho);
                    if (carrinho != null)
                    {
                        carrinho.GerarOC = true;
                        _carrinhoRepository.Update(carrinho);
                        GerarOCCarrinho(carrinho);
                        return RedirectToAction("Index", "Cliente");
                    }
                }
                return RedirectToAction("Carrinho");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void GerarOCCarrinho(Carrinho carrinho)
        {
            try
            {
                OC oC = new OC(Guid.NewGuid())
                {
                    Atualizado = DateTime.Now,
                    Cadastro = DateTime.Now,
                    IdCliente = carrinho.IdCliente,
                    IdLoja = carrinho.IdLoja,
                    Valido = true,
                    Referencia = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString()
                };
                foreach (var item in carrinho.CarrinhoProdutos)
                {
                    var ocDetalhes = new OCDetalhes(Guid.NewGuid())
                    {
                        IdOC = oC.ID,
                        IdProduto = item.IdProduto,
                        Quantidade = item.Quantidade
                    };
                    if (oC.OCDetalhes == null)
                    {
                        oC.OCDetalhes = new Collection<OCDetalhes>();
                    }
                    oC.OCDetalhes.Add(ocDetalhes);
                }
                _oCRepository.Add(oC);
                _carrinhoRepository.Remove(carrinho);
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
                var ocSession = HttpContext.Session.GetString("idOCSelect");
                var cliente = HttpContext.Session.GetString("cliente");
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


    }
}
