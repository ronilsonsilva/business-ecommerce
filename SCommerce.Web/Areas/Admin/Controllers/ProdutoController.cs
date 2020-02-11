using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.Fabricante;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Web.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;


namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProdutoController : BaseController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoImagemRepository _produtoImagemRepository;
        private readonly IProdutoPropriedadeRepository _produtoPropriedadeRepository;
        private readonly IFabricanteRepository _fabricanteRepository;
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly ILojaRepository _lojaRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Produto/";

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IProdutoImagemRepository produtoImagemRepository, IProdutoPropriedadeRepository produtoPropriedadeRepository, IFabricanteRepository fabricanteRepository, IPropriedadeRepository propriedadeRepository, ILojaRepository lojaRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _produtoImagemRepository = produtoImagemRepository;
            _produtoPropriedadeRepository = produtoPropriedadeRepository;
            _fabricanteRepository = fabricanteRepository;
            _propriedadeRepository = propriedadeRepository;
            _lojaRepository = lojaRepository;
            _mapper = mapper;
        }


        // GET: Produto
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<ProdutoViewModel> produtoViewModel = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAll());
                return View(path + "Index.cshtml", produtoViewModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: Produto/Details/5
        public ActionResult Details(Guid idProduto)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idProduto == Guid.Empty || idProduto == null)
                {
                    return NotFound();
                }
                ProdutoViewModel produtoViewModel = _mapper.Map<Produto, ProdutoViewModel>(_produtoRepository.GetById(idProduto));
                if (produtoViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", produtoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ConfigCreate(ProdutoViewModel produtoViewModel)
        {
            try
            {
                ViewBag.Categorias = new SelectList(_mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaRepository.GetAll()),"ID", "Nome", produtoViewModel.IdCategoriaPadrao);
                ViewBag.Fabricantes = new SelectList(_mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteViewModels>>(_fabricanteRepository.GetAll()), "ID", "Nome", produtoViewModel.FabricanteId);
                ViewBag.Propriedades = new SelectList(_mapper.Map<IEnumerable<Propriedade>, IEnumerable<PropriedadeViewModel>>(_propriedadeRepository.GetAll()), "ID", "Nome", produtoViewModel.PropriedadeView);
                ViewBag.Condicao = new SelectList(SCommerce.Web.Utils.GetEnum.SituacaoProduto(), "Valor", "Exibir", produtoViewModel.Condicao);
                if (produtoViewModel.ProdutoPropriedadesViewmodel == null)
                {
                    produtoViewModel.ProdutoPropriedadesViewmodel = new  List<ProdutoPropriedadeViewModel>();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                ProdutoViewModel produtoViewModel = new ProdutoViewModel();
                this.ConfigCreate(produtoViewModel);
                return View(path + "Create.cshtml", produtoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel, String button)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (button.Equals("Salvar"))
                {
                    if (produtoViewModel.Nome == null || produtoViewModel.NomeExibicao == null || produtoViewModel.DescricaoCurta == null)
                    {
                        this.ConfigCreate(produtoViewModel);
                        return View(path + "Create.cshtml", produtoViewModel);
                    }

                    var produtoDomain = this.MapearProduto(produtoViewModel);
                    
                    _produtoRepository.SalvarProduto(produtoDomain);
                    return RedirectToAction("Index");
                }
                else if (button.Equals("AdicionarPropriedade"))
                {
                    if (produtoViewModel.ProdutoPropriedadesViewmodel == null)
                    {
                        produtoViewModel.ProdutoPropriedadesViewmodel = new List<ProdutoPropriedadeViewModel>();
                    }
                    var propriedade = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeRepository.GetById(produtoViewModel.PropriedadeView));
                    ProdutoPropriedadeViewModel produtoPropriedade = new ProdutoPropriedadeViewModel();
                    produtoPropriedade.Produto = produtoViewModel;
                    produtoPropriedade.Propriedade = propriedade;
                    produtoViewModel.ProdutoPropriedadesViewmodel.Add(produtoPropriedade);
                }
                else if (button.Split('_')[0].Equals("Excluir"))
                {
                    var colecao = produtoViewModel.ProdutoPropriedadesViewmodel;
                    foreach (var item in colecao)
                    {
                        if (item.Propriedade.ID.ToString().Equals(button.Split('_')[1]))
                        {
                            produtoViewModel.ProdutoPropriedadesViewmodel.Remove(item);
                        }
                    }
                }
                this.ConfigCreate(produtoViewModel);
                return View(path + "Create.cshtml", produtoViewModel);
            }
            catch(Exception erro)
            {
                this.ConfigCreate(produtoViewModel);
                return View(path + "Create.cshtml", produtoViewModel);
            }
        }

        public Produto MapearProduto(ProdutoViewModel produtoViewModel)
        {
            try
            {
                Produto produto = new Produto(produtoViewModel.ID != null && produtoViewModel.ID != Guid.Empty? produtoViewModel.ID : Guid.Empty) {
                    Altura = produtoViewModel.Altura,
                    Atualizado = produtoViewModel.Atualizado,
                    Ativo = produtoViewModel.Ativo,
                    Cadastro = produtoViewModel.Cadastro,
                    CampoTexto = produtoViewModel.CampoTexto,
                    Condicao = produtoViewModel.Condicao,
                    CustoEnvio = produtoViewModel.CustoEnvio,
                    Customizavel = produtoViewModel.Customizavel,
                    DescontoPorQuantidade = produtoViewModel.DescontoPorQuantidade,
                    DescricaoCurta = produtoViewModel.DescricaoCurta,
                    Disponivel = produtoViewModel.Disponivel,
                    DisponivelParaOC = produtoViewModel.DisponivelParaOC,
                    EAN13 = produtoViewModel.EAN13,
                    Ecotax = produtoViewModel.Ecotax,
                    ExibirPreco = produtoViewModel.ExibirPreco,
                    ForaDeEstoque = produtoViewModel.ForaDeEstoque,
                    GerenciamentoAvancadoEstoque = produtoViewModel.GerenciamentoAvancadoEstoque,
                    ImpactoPrecoUnitario = produtoViewModel.ImpactoPrecoUnitario,
                    Indexado = produtoViewModel.Indexado,
                    Largura = produtoViewModel.Largura,
                    Nome = produtoViewModel.Nome,
                    NomeExibicao = produtoViewModel.NomeExibicao,
                    Peso = produtoViewModel.Peso,
                    Preco = produtoViewModel.Preco,
                    PrecoAtacado = produtoViewModel.PrecoAtacado,
                    ProdutoDigital = produtoViewModel.ProdutoDigital,
                    Profundidade = produtoViewModel.Profundidade,
                    Quantidade = produtoViewModel.Quantidade,
                    QuantidadeMinima = produtoViewModel.QuantidadeMinima,
                    Referencia = produtoViewModel.Referencia,
                    ReferenciaFabricante = produtoViewModel.ReferenciaFabricante,
                    ReferenciaFornecedor = produtoViewModel.ReferenciaFornecedor,
                    SomenteOnline = produtoViewModel.SomenteOnline,
                    TemAnexoOculto = produtoViewModel.TemAnexoOculto,
                    Unidade = produtoViewModel.Unidade,
                    UPC = produtoViewModel.UPC,
                    UploadArquivos = produtoViewModel.UploadArquivos,
                    IdCategoriaPadrao = produtoViewModel.IdCategoriaPadrao
                };
                if (produtoViewModel.IdCategoriaPadrao != null && produtoViewModel.IdCategoriaPadrao!= Guid.Empty)
                {
                    produto.CategoriaPadrao = _categoriaRepository.GetById(produtoViewModel.IdCategoriaPadrao);
                }
                if (produtoViewModel.LojaId != null && produtoViewModel.LojaId != Guid.Empty)
                {
                    produto.LojaPadrao = _lojaRepository.GetById(produtoViewModel.LojaId);
                }


                if (produto.ID == null || produto.ID == Guid.Empty)
                {
                    produto.Cadastro = DateTime.Now;
                }
                produto.Atualizado = DateTime.Now;
                if (produtoViewModel.arquivosImagens?.Count > 0)
                {
                    this.SalvarImagens(produtoViewModel, ref produto);
                }
                if (produtoViewModel.ProdutoPropriedadesViewmodel?.Count > 0)
                {
                    foreach (var item in produtoViewModel.ProdutoPropriedadesViewmodel)
                    {
                        if (produto.ProdutoPropriedades == null)
                        {
                            produto.ProdutoPropriedades = new Collection<ProdutoPropriedade>();
                        }
                        if (item.ID != Guid.Empty)
                        {
                            produto.ProdutoPropriedades.Add(new ProdutoPropriedade(item.ID)
                            {
                                ID = item.ID,
                                Produto = null,
                                Propriedade = _propriedadeRepository.GetById(item.Propriedade.ID)
                            });
                        }
                        else
                        {
                            produto.ProdutoPropriedades.Add(new ProdutoPropriedade(Guid.Empty)
                            {
                                ID = Guid.Empty,
                                Produto = null,
                                Propriedade = _propriedadeRepository.GetById(item.Propriedade.ID)
                            });
                        }
                        
                    }
                }
                return produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

       
        /// <summary>
        /// Salva as imagens de um determinado produto no banco de dados.
        /// </summary>
        /// <param name="produtoViewModel"></param>
        /// <param name="produto"></param>
        /// <returns></returns>
        public Boolean SalvarImagens(ProdutoViewModel produtoViewModel, ref Produto produto)
        {
            try
            {
                if (produtoViewModel.arquivosImagens != null)
                {
                    foreach (var imagem in produtoViewModel.arquivosImagens)
                    {
                        if (imagem.Length != 0)
                        {
                            ProdutoImagemViewModel produtoImagemViewModel = new ProdutoImagemViewModel();
                            MemoryStream ms = new MemoryStream();
                            imagem.OpenReadStream().CopyTo(ms);
                            produtoImagemViewModel.Arquivo = ms.ToArray();
                            produtoImagemViewModel.Formato = imagem.ContentType;
                            produtoImagemViewModel.Cadastro = DateTime.Now;
                            produtoImagemViewModel.Atualizada = DateTime.Now;
                            var produtoImagemEntity = _mapper.Map<ProdutoImagemViewModel, ProdutoImagem>(produtoImagemViewModel);
                            if (produto.imagens == null)
                            {
                                produto.imagens = new Collection<ProdutoImagem>();
                            }
                            produto.imagens.Add(produtoImagemEntity);
                        }

                    }
                }
                return true;
            }
            catch (Exception  erro)
            {
                throw erro;
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(Guid idProduto)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
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
                    produtoViewModel.ProdutoPropriedadesViewmodel.Add(_mapper.Map<ProdutoPropriedade, ProdutoPropriedadeViewModel>(item));
                }
                var produtoImagens = _produtoImagemRepository.GetPorProduto(idProduto)?.ToList();
                foreach (var item in produtoImagens)
                {
                    if (produtoViewModel.imagensProduto == null)
                    {
                        produtoViewModel.imagensProduto = new Collection<ProdutoImagemViewModel>();
                    }
                    produtoViewModel.imagensProduto.Add(_mapper.Map<ProdutoImagem,ProdutoImagemViewModel>(item));
                }
                //produtoViewModel.arquivosImagens = new Collection<FormFile>();
                this.ConfigCreate(produtoViewModel);
                return View(path + "Edit.cshtml", produtoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel, String button)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (button.Equals("Salvar"))
                {
                    if (produtoViewModel.Nome == null || produtoViewModel.NomeExibicao == null || produtoViewModel.DescricaoCurta == null)
                    {
                        this.ConfigCreate(produtoViewModel);
                        return View(path + "Edit.cshtml", produtoViewModel);
                    }

                    var produtoDomain = this.MapearProduto(produtoViewModel);

                    _produtoRepository.UpdateProduto(produtoDomain);
                    return RedirectToAction("Index");
                }
                else if (button.Equals("AdicionarPropriedade"))
                {
                    if (produtoViewModel.ProdutoPropriedadesViewmodel == null)
                    {
                        produtoViewModel.ProdutoPropriedadesViewmodel = new List<ProdutoPropriedadeViewModel>();
                    }
                    var propriedade = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeRepository.GetById(produtoViewModel.PropriedadeView));
                    ProdutoPropriedadeViewModel produtoPropriedade = new ProdutoPropriedadeViewModel();
                    produtoPropriedade.Produto = produtoViewModel;
                    produtoPropriedade.Propriedade = propriedade;
                    produtoViewModel.ProdutoPropriedadesViewmodel.Add(produtoPropriedade);
                    var produtoImagens = _produtoImagemRepository.GetPorProduto(produtoViewModel.ID)?.ToList();
                    foreach (var item in produtoImagens)
                    {
                        if (produtoViewModel.imagensProduto == null)
                        {
                            produtoViewModel.imagensProduto = new Collection<ProdutoImagemViewModel>();
                        }
                        produtoViewModel.imagensProduto.Add(_mapper.Map<ProdutoImagem, ProdutoImagemViewModel>(item));
                    }
                    this.ConfigCreate(produtoViewModel);
                    return View(path + "Edit.cshtml", produtoViewModel);
                }
                else if (button.Split('_')[0].Equals("Excluir"))
                {
                    var colecao = produtoViewModel.ProdutoPropriedadesViewmodel;
                    foreach (var item in colecao)
                    {
                        if (item.Propriedade.ID.ToString().Equals(button.Split('_')[1]))
                        {
                            produtoViewModel.ProdutoPropriedadesViewmodel.Remove(item);
                            var produtoPropriedade = _produtoPropriedadeRepository.GetById(item.ID);
                            if (produtoPropriedade != null)
                            {
                                _produtoPropriedadeRepository.Remove(produtoPropriedade);
                            }
                            return RedirectToAction("Edit", new { idProduto = produtoViewModel.ID });
                        }
                    }
                    return RedirectToAction("Edit", new { idProduto = produtoViewModel.ID });
                }
                else if (button.Split('_')[0].Equals("ExcluirImagem"))
                {
                    var produtoImagem = _produtoImagemRepository.GetById(Guid.Parse(button.Split('_')[1]));
                    if (produtoImagem != null)
                    {
                        _produtoImagemRepository.Remove(produtoImagem);
                    }
                    return RedirectToAction("Edit", new { idProduto  = produtoViewModel.ID});
                }
                this.ConfigCreate(produtoViewModel);
                return RedirectToAction("Index");
            }
            catch(Exception erro)
            {
                this.ConfigCreate(produtoViewModel);
                return View(path + "Edit.cshtml", produtoViewModel);
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(Guid idProduto)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idProduto == Guid.Empty || idProduto == null)
                {
                    return NotFound();
                }
                ProdutoViewModel produtoViewModel = _mapper.Map<Produto, ProdutoViewModel>(_produtoRepository.GetById(idProduto));
                if (produtoViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", produtoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProdutoViewModel produtoViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var produtoDomain = _mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                produtoDomain.Atualizado = DateTime.Now;
                _produtoRepository.Remove(produtoDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                this.ConfigCreate(produtoViewModel);
                return View(path + "Delete.cshtml", produtoViewModel);
            }
        }
    }
}