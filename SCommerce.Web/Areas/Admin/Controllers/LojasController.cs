using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CMS;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LojasController : BaseController
    {
        private readonly ILojaRepository _lojaRepository;
        private readonly ICMSRedeSocialRepository _cMSRedeSocialRepository;
        private readonly IPaisRepository _paisRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IContatoLojaRepository _contatoLojaRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IContatoEmailRepository _contatoEmailRepository;
        private readonly IContatoTelefoneRepository _contatoTelefoneRepository;
        private readonly IContatoRedeSocialRepository _contatoRedeSocialRepository;
        private readonly IContatoLojaEmailRepository _contatoLojaEmailRepository;
        private readonly IContatoLojaTelefoneRepository _contatoLojaTelefoneRepository;
        private readonly IContatoLojaEnderecoRepository _contatoLojaEnderecoRepository;
        private readonly IContatoLojaRedeSocialRepository _contatoLojaRedeSocialRepository;
        private readonly ICMSWhatsAppRepository _cMSWhatsAppRepository;
        private readonly ICMSLojaRepository _cMSLojaRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Lojas/";

        public LojasController(ILojaRepository lojaRepository, ICMSRedeSocialRepository cMSRedeSocialRepository, IPaisRepository paisRepository, ICidadeRepository cidadeRepository, IProvinciaRepository provinciaRepository, IContatoLojaRepository contatoLojaRepository, IEnderecoRepository enderecoRepository, IContatoEmailRepository contatoEmailRepository, IContatoTelefoneRepository contatoTelefoneRepository, IContatoRedeSocialRepository contatoRedeSocialRepository, IContatoLojaEmailRepository contatoLojaEmailRepository, IContatoLojaTelefoneRepository contatoLojaTelefoneRepository, IContatoLojaEnderecoRepository contatoLojaEnderecoRepository, IContatoLojaRedeSocialRepository contatoLojaRedeSocialRepository, ICMSWhatsAppRepository cMSWhatsAppRepository, ICMSLojaRepository cMSLojaRepository, IMapper mapper)
        {
            _lojaRepository = lojaRepository;
            _cMSRedeSocialRepository = cMSRedeSocialRepository;
            _paisRepository = paisRepository;
            _cidadeRepository = cidadeRepository;
            _provinciaRepository = provinciaRepository;
            _contatoLojaRepository = contatoLojaRepository;
            _enderecoRepository = enderecoRepository;
            _contatoEmailRepository = contatoEmailRepository;
            _contatoTelefoneRepository = contatoTelefoneRepository;
            _contatoRedeSocialRepository = contatoRedeSocialRepository;
            _contatoLojaEmailRepository = contatoLojaEmailRepository;
            _contatoLojaTelefoneRepository = contatoLojaTelefoneRepository;
            _contatoLojaEnderecoRepository = contatoLojaEnderecoRepository;
            _contatoLojaRedeSocialRepository = contatoLojaRedeSocialRepository;
            _cMSWhatsAppRepository = cMSWhatsAppRepository;
            _cMSLojaRepository = cMSLojaRepository;
            _mapper = mapper;
        }



        // GET: Lojas
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var loja = _lojaRepository.GetAll().ToList();
                var lojaViewModels = LojaViewModel.Mapear(loja);
                return View(path + "Index.cshtml", lojaViewModels);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        // GET: Lojas/Details/5
        public ActionResult Details(Guid idLoja)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idLoja == Guid.Empty || idLoja == null)
                {
                    return NotFound();
                }
                LojaViewModel lojaViewModel = _mapper.Map<Loja, LojaViewModel>(_lojaRepository.GetById(idLoja));
                if (lojaViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ConfigEditCreate(LojaViewModel lojaViewModel)
        {
            try
            {
                ViewBag.Lojas = new SelectList(LojaViewModel.Mapear(_lojaRepository.GetAll().ToList()), "ID", "Nome", lojaViewModel?.LojaMatriz);
                ViewBag.Paises = new SelectList(_paisRepository.GetAll(), "ID", "Nome");
                ViewBag.TipoContato = new SelectList(Utils.GetEnum.TipoTelefones(), "Valor", "Exibir", lojaViewModel?.ContatoLojaViewModel?.ContatoLojaTelefone?.ContatoTelefone?.TipoContato);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Lojas/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                LojaViewModel lojaViewModel = new LojaViewModel();
                this.ConfigEditCreate(lojaViewModel);
                return View(path + "Create.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #region não permitido
        // POST: Lojas/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(LojaViewModel lojaViewModel)
        //{
        //    try
        //    {
        //        if (lojaViewModel.Nome != null && lojaViewModel.Nome != String.Empty && lojaViewModel.RazaoSocial != null && lojaViewModel.RazaoSocial != String.Empty)
        //        {
        //            Loja lojaDomain = new Loja(Guid.Empty)
        //            {
        //                Cadatro = DateTime.Now,
        //                Atualizado = DateTime.Now,
        //                Ativa = lojaViewModel.Ativa,
        //                CNPJ = lojaViewModel.CNPJ,
        //                InscricaoEstadual = lojaViewModel.InscricaoEstadual,
        //                Matriz = lojaViewModel.Matriz,
        //                Nome = lojaViewModel.Nome,
        //                RazaoSocial = lojaViewModel.RazaoSocial,
        //                LojaMatriz = lojaViewModel.LojaMatriz
        //            };
        //            _lojaRepository.Add(lojaDomain);
        //            return RedirectToAction(nameof(Index));
        //        }
        //        this.ConfigEditCreate(lojaViewModel);
        //        return View(path + "Create.cshtml", lojaViewModel);
        //    }
        //    catch (Exception erro)
        //    {
        //        this.ConfigEditCreate(lojaViewModel);
        //        return View(path + "Create.cshtml", lojaViewModel);
        //    }
        //}
        #endregion

        // GET: Lojas/Edit/5
        public ActionResult Edit(Guid idLoja)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idLoja == Guid.Empty || idLoja == null)
                {
                    return NotFound();
                }
                var loja = _lojaRepository.GetById(idLoja);
                LojaViewModel lojaViewModel = LojaViewModel.Mapear(loja);
                if (lojaViewModel == null)
                {
                    return NotFound();
                }
                lojaViewModel.CMSRedeSocials = _mapper.Map<ICollection<CMSRedeSocial>, ICollection<CMSRedeSocialViewModel>>(_cMSRedeSocialRepository.GetAll()?.Where(x => x.IdLoja == idLoja)?.ToList());
                if (lojaViewModel.ContatoLojas == null)
                {
                    lojaViewModel.ContatoLojas = new Collection<ContatoLojaViewModel>();
                }
                var contatoLoja = _contatoLojaRepository.GetContatoLojaPorLoja(idLoja);
                if (lojaViewModel.ContatoLoja == null)
                {
                    lojaViewModel.ContatoLoja = new ContatoLojaViewModel();
                }
                lojaViewModel.ContatoLoja = ContatoLojaViewModel.Mapear(contatoLoja);
                if (lojaViewModel.ContatoLoja.ContatoLojaEnderecos != null)
                {
                    foreach (var item in lojaViewModel.ContatoLoja.ContatoLojaEnderecos)
                    {
                        item.Endereco.Cidade = CidadeViewModel.Mapear(_cidadeRepository.GetById(item.Endereco.idCidade));
                    }
                }
                lojaViewModel.CMSLojaViewModel = CMSLojaViewModel.Mapear(_cMSLojaRepository.GetAll().FirstOrDefault());
                this.GetCMSWhatsApp(ref lojaViewModel);
                this.ConfigEditCreate(lojaViewModel);
                return View(path + "Edit.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public void MapearContatoLoja(ref LojaViewModel lojaViewModel)
        {
            try
            {
                lojaViewModel.ContatoLojas = new Collection<ContatoLojaViewModel>();
                var contatoLoja = _contatoLojaRepository.GetAll();
                if (contatoLoja != null)
                {
                    foreach (var item in contatoLoja)
                    {
                        ContatoLojaViewModel contatoLojaViewModel = new ContatoLojaViewModel();

                        contatoLojaViewModel.ContatoLojaEmails = _mapper.Map<ICollection<ContatoLojaEmail>, ICollection<ContatoLojaEmailViewModel>>(_contatoLojaEmailRepository.GetPorLoja(item.ID));
                        contatoLojaViewModel.ContatoLojaEnderecos = _mapper.Map<ICollection<ContatoLojaEndereco>, ICollection<ContatoLojaEnderecoViewModel>>(_contatoLojaEnderecoRepository.GetPorLoja(item.ID));
                        contatoLojaViewModel.ContatoLojaTelefones = _mapper.Map<ICollection<ContatoLojaTelefone>, ICollection<ContatoLojaTelefoneViewModel>>(_contatoLojaTelefoneRepository.GetPorLoja(item.ID));
                        contatoLojaViewModel.ContatoLojaRedeSocials = _mapper.Map<ICollection<ContatoLojaRedeSocial>, ICollection<ContatoLojaRedeSocialViewModel>>(_contatoLojaRedeSocialRepository.GetPorLoja(item.ID));
                        
                        contatoLojaViewModel.ID = item.ID;
                        contatoLojaViewModel.Loja = LojaViewModel.Mapear(item.Loja);
                        contatoLojaViewModel.NomeContato = item.NomeContato;
                        lojaViewModel.ContatoLojas.Add(contatoLojaViewModel);
                    }
                }
                var cmsWhatsApp = _cMSWhatsAppRepository.GetCMSWhatsApp().Result;
                lojaViewModel.CMSWhatsApp = _mapper.Map<CMSWhatsApp, CMSWhatsAppViewModel>(cmsWhatsApp);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Lojas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LojaViewModel lojaViewModel)
        {
            try
            {
                if (String.IsNullOrEmpty(lojaViewModel.submit) && lojaViewModel.Nome != null && lojaViewModel.Nome != String.Empty && lojaViewModel.RazaoSocial != null && lojaViewModel.RazaoSocial != String.Empty)
                {
                    Loja lojaDomain = _lojaRepository.GetById(lojaViewModel.ID);
                    if (lojaDomain != null)
                    {
                        lojaDomain.Atualizado = DateTime.Now;
                        lojaDomain.Ativa = lojaViewModel.Ativa;
                        lojaDomain.CNPJ = lojaViewModel.CNPJ;
                        lojaDomain.InscricaoEstadual = lojaViewModel.InscricaoEstadual;
                        lojaDomain.Matriz = lojaViewModel.Matriz;
                        lojaDomain.Nome = lojaViewModel.Nome;
                        lojaDomain.RazaoSocial = lojaViewModel.RazaoSocial;
                        lojaDomain.LojaMatriz = lojaViewModel.LojaMatriz;
                        _lojaRepository.Update(lojaDomain);
                        return RedirectToAction(nameof(Index));
                    }

                }
                else if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (lojaViewModel.submit.Equals("AdiconarRedeSocial"))
                {
                    this.AdicionarContatoLojaRedeSocial(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.StartsWith("ExcluirRedeSocial_"))
                {
                    this.ExcluirContatoLojaRedeSocial(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarTelefone"))
                {
                    this.AdicionarContatoLojaTelefone(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.StartsWith("ExcluirContatoTelefone_"))
                {
                    this.ExcluirContatoLojaTelefone(ref lojaViewModel, Guid.Parse(lojaViewModel.submit.Split('_')[1]));
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarEndereco"))
                {
                    this.AdicionarContatoLojaEndereco(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.StartsWith("ExcluirContatoEndereco_"))
                {
                    this.ExcluirContatoLojaEndereco(ref lojaViewModel, Guid.Parse(lojaViewModel.submit.Split('_')[1]));
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdicionarEmail"))
                {
                    this.AdicionarContatoLojaEmail(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.StartsWith("ExcluirContatoEmail_"))
                {
                    this.ExcluirContatoLojaEmail(ref lojaViewModel, Guid.Parse(lojaViewModel.submit.Split('_')[1]));
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarTelefone"))
                {
                    this.AdicionarContatoLojaTelefone(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.StartsWith("ExcluirContatoTelefone_"))
                {
                    this.ExcluirContatoLojaTelefone(ref lojaViewModel, Guid.Parse(lojaViewModel.submit.Split('_')[1]));
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarWhatsApp"))
                {
                    this.AdicionarWhatsApp(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }else if (lojaViewModel.submit.Equals("Excluir_logo1"))
                {
                    var cmsloja = _cMSLojaRepository.GetById(lojaViewModel.CMSLojaViewModel.ID);
                    if (cmsloja != null)
                    {
                        cmsloja.Logo = null;
                        cmsloja.LogoType = "";
                        _cMSLojaRepository.Update(cmsloja);
                    }
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("Excluir_logo2"))
                {
                    var cmsloja = _cMSLojaRepository.GetById(lojaViewModel.CMSLojaViewModel.ID);
                    if (cmsloja != null)
                    {
                        cmsloja.Logo2 = null;
                        cmsloja.LogoType2 = "";
                        _cMSLojaRepository.Update(cmsloja);
                    }
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarLogo"))
                {
                    this.AdicionarLogo(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("Excluir_icone"))
                {
                    var cmsloja = _cMSLojaRepository.GetById(lojaViewModel.CMSLojaViewModel.ID);
                    if (cmsloja != null)
                    {
                        cmsloja.Icone = null;
                        cmsloja.IconeType = "";
                        _cMSLojaRepository.Update(cmsloja);
                    }
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }
                else if (lojaViewModel.submit.Equals("AdiconarIcone"))
                {
                    this.AdicionarIcone(ref lojaViewModel);
                    return RedirectToAction("Edit", new { idLoja = lojaViewModel.ID });
                }

                this.ConfigEditCreate(lojaViewModel);
                return View(path + "Edit.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                this.ConfigEditCreate(lojaViewModel);
                return View(path + "Edit.cshtml", lojaViewModel);
            }
        }

        /// <summary>
        /// Adiciona um novo contato do WhatsApp
        /// </summary>
        /// <param name="lojaViewModel"></param>
        /// <returns></returns>
        private Boolean AdicionarWhatsApp(ref LojaViewModel lojaViewModel)
        {
            try
            {
                if (lojaViewModel.CMSWhatsApp.ID != null && lojaViewModel.CMSWhatsApp.ID != Guid.Empty)
                {
                    CMSWhatsApp cMSWhatsApp = _cMSWhatsAppRepository.GetCMSWhatsApp().Result;
                    cMSWhatsApp.Observacao = lojaViewModel.CMSWhatsApp.Observacao;
                    cMSWhatsApp.Principal = lojaViewModel.CMSWhatsApp.Principal;
                    cMSWhatsApp.Exibir = lojaViewModel.CMSWhatsApp.Exibir;
                    _cMSWhatsAppRepository.Update(cMSWhatsApp);

                    ContatoLojaTelefone contatoLojaTelefone = _contatoLojaTelefoneRepository.GetById(cMSWhatsApp.IDContatoLojaTelefone);

                    var telefone = _contatoTelefoneRepository.GetById(contatoLojaTelefone.IdContatoTelefone);
                    telefone.CodigoLocal = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.CodigoLocal;
                    telefone.CodigoNacional = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.CodigoNacional;
                    telefone.Descricao = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Descricao;
                    telefone.Numero = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Numero;
                    telefone.Operadora = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Operadora;
                    telefone.TipoContato = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.TipoContato;
                    _contatoTelefoneRepository.Update(telefone);
                    return true;
                }
                else
                {
                    ContatoLoja contatoLoja = _contatoLojaRepository.GetContatoLojaPorLoja(lojaViewModel.ID);
                    if (contatoLoja == null)
                    {
                        contatoLoja = new ContatoLoja(Guid.NewGuid());
                        contatoLoja.IdLoja = lojaViewModel.ID;
                        contatoLoja.NomeContato = lojaViewModel.CMSWhatsApp.Observacao;
                        _contatoLojaRepository.Add(contatoLoja);
                    }
                    

                    var telefone = new ContatoTelefone(Guid.NewGuid());
                    telefone.CodigoLocal = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.CodigoLocal;
                    telefone.CodigoNacional = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.CodigoNacional;
                    telefone.Descricao = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Descricao;
                    telefone.Numero = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Numero;
                    telefone.Operadora = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.Operadora;
                    telefone.TipoContato = lojaViewModel.CMSWhatsApp.ContatoLojaTelefone.ContatoTelefone.TipoContato;
                    _contatoTelefoneRepository.Add(telefone);

                    ContatoLojaTelefone contatoLojaTelefone = new ContatoLojaTelefone(Guid.NewGuid());
                    contatoLojaTelefone.IdContatoLoja = contatoLoja.ID;
                    contatoLojaTelefone.IdContatoTelefone = telefone.ID;
                    _contatoLojaTelefoneRepository.Add(contatoLojaTelefone);

                    CMSWhatsApp cMSWhatsApp = new CMSWhatsApp(Guid.NewGuid());
                    cMSWhatsApp.Observacao = lojaViewModel.CMSWhatsApp.Observacao;
                    cMSWhatsApp.Principal = lojaViewModel.CMSWhatsApp.Principal;
                    cMSWhatsApp.Exibir = lojaViewModel.CMSWhatsApp.Exibir;
                    cMSWhatsApp.IDContatoLojaTelefone = contatoLojaTelefone.ID;
                    _cMSWhatsAppRepository.Add(cMSWhatsApp);
                    return true;
                }
            }
            catch (Exception erro)
            {
                return false;
                throw erro;
            }
        }

        /// <summary>
        /// Adicionar novo registro de contato telefonico da loja
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void AdicionarContatoLojaTelefone(ref LojaViewModel lojaViewModel)
        {
            try
            {
                if (lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ID != null && lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ID != Guid.Empty)
                {
                    ContatoLojaTelefone contatoLojaTelefone = _contatoLojaTelefoneRepository.GetById(lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ID);
                    if (contatoLojaTelefone != null)
                    {
                        ContatoTelefone contatoTelefone = _contatoTelefoneRepository.GetById(contatoLojaTelefone.IdContatoTelefone);
                        contatoTelefone.Numero = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Numero;
                        contatoTelefone.CodigoLocal = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.CodigoLocal;
                        contatoTelefone.CodigoNacional = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.CodigoNacional;
                        contatoTelefone.Descricao = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Descricao;
                        contatoTelefone.Operadora = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Operadora;
                        contatoTelefone.TipoContato = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.TipoContato;

                        _contatoTelefoneRepository.Update(contatoTelefone);
                    }

                }
                else
                {
                    ContatoLoja contatoLoja = _contatoLojaRepository.GetContatoLojaPorLoja(lojaViewModel.ID);
                    if (contatoLoja == null)
                    {
                        contatoLoja = new ContatoLoja(Guid.NewGuid());
                        contatoLoja.IdLoja = lojaViewModel.ID;
                        contatoLoja.NomeContato = lojaViewModel.ContatoLojaViewModel.NomeContato;
                        _contatoLojaRepository.Add(contatoLoja);
                    }

                    ContatoLojaTelefone contatoLojaTelefone = new ContatoLojaTelefone(Guid.NewGuid());
                    contatoLojaTelefone.IdContatoLoja = contatoLoja.ID;


                    ContatoTelefone contatoTelefone = new ContatoTelefone(Guid.NewGuid());
                    contatoTelefone.Numero = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Numero;
                    contatoTelefone.CodigoLocal = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.CodigoLocal;
                    contatoTelefone.CodigoNacional = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.CodigoNacional;
                    contatoTelefone.Descricao = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Descricao;
                    contatoTelefone.Operadora = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.Operadora;
                    contatoTelefone.TipoContato = lojaViewModel.ContatoLojaViewModel.ContatoLojaTelefone.ContatoTelefone.TipoContato;

                    _contatoTelefoneRepository.Add(contatoTelefone);
                    contatoLojaTelefone.IdContatoTelefone = contatoTelefone.ID;
                    _contatoLojaTelefoneRepository.Add(contatoLojaTelefone);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Remove o contato de telefone da Loja
        /// </summary>
        /// <param name="lojaViewModel"></param>
        /// <param name="idContatoLojaTelefone"></param>
        public void ExcluirContatoLojaTelefone(ref LojaViewModel lojaViewModel, Guid idContatoLojaTelefone)
        {
            try
            {
                ContatoLojaTelefone contatoLojaTelefone = _contatoLojaTelefoneRepository.GetById(idContatoLojaTelefone);
                if (contatoLojaTelefone != null)
                {
                    ContatoTelefone contatoTelefone = _contatoTelefoneRepository.GetById(contatoLojaTelefone.IdContatoTelefone);
                    if (contatoTelefone != null)
                    {
                        _contatoTelefoneRepository.Remove(contatoTelefone);
                    }
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        /// <summary>
        /// Adiciona novo registro de ContatoLojaEndereço
        /// </summary>
        /// <param name="lojaViewModel"></param>
        public void AdicionarContatoLojaEndereco(ref LojaViewModel lojaViewModel)
        {
            try
            {
                ContatoLoja contatoLoja = _contatoLojaRepository.GetContatoLojaPorLoja(lojaViewModel.ID);
                if (contatoLoja == null)
                {
                    contatoLoja = new ContatoLoja(Guid.NewGuid());
                    contatoLoja.IdLoja = lojaViewModel.ID;
                    contatoLoja.NomeContato = lojaViewModel.ContatoLojaViewModel.NomeContato;
                    _contatoLojaRepository.Add(contatoLoja);
                }

                ContatoLojaEndereco contatoLojaEndereco = new ContatoLojaEndereco(Guid.NewGuid());
                contatoLojaEndereco.IdContatoLoja = contatoLoja.ID;
                Endereco endereco = new Endereco(Guid.NewGuid());
                endereco.Aliase = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Aliase;
                endereco.Ativo = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Ativo;
                endereco.Atualizado = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Atualizado;
                endereco.Cadastro = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Cadastro;
                endereco.CodigoPostal = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.CodigoPostal;
                endereco.Complemento = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Complemento;
                endereco.Deletado = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Deletado;
                endereco.IdCidade = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.idCidade;
                endereco.Numero = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Numero;
                endereco.Logradouro = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Logradouro;
                _enderecoRepository.Add(endereco);
                contatoLojaEndereco.IdEndereco = endereco.ID;
                _contatoLojaEnderecoRepository.Add(contatoLojaEndereco);

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Remove um registro de ContatoLojaEndereco
        /// </summary>
        /// <param name="lojaViewModel"></param>
        /// <param name="idEndereco"></param>
        public void ExcluirContatoLojaEndereco(ref LojaViewModel lojaViewModel, Guid idContatoLojaEndereco)
        {
            try
            {
                ContatoLojaEndereco contatoLojaEndereco = _contatoLojaEnderecoRepository.GetById(idContatoLojaEndereco);
                if (contatoLojaEndereco != null)
                {
                    Endereco endereco = _enderecoRepository.GetById(contatoLojaEndereco.IdEndereco);
                    if (endereco != null)
                    {
                        _enderecoRepository.Remove(endereco);
                    }
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adiciona novo registro de contato do WhatsApp
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void AdicionarContatoLojaRedeSocial(ref LojaViewModel lojaViewModel)
        {
            try
            {
                Domain.Entities.CMS.CMSRedeSocial cMSRedeSocial = new Domain.Entities.CMS.CMSRedeSocial(Guid.Empty)
                {
                    IdLoja = lojaViewModel.ID,
                    Nome = lojaViewModel.CMSRedeSocialViewModel.Nome,
                    Url = lojaViewModel.CMSRedeSocialViewModel.Url
                };
                if (lojaViewModel.CMSRedeSocialViewModel.ArquivoIcone.Length != 0)
                {
                    MemoryStream ms = new MemoryStream();
                    lojaViewModel.CMSRedeSocialViewModel.ArquivoIcone.OpenReadStream().CopyTo(ms);
                    cMSRedeSocial.Icone = ms.ToArray();
                    cMSRedeSocial.IconeType = lojaViewModel.CMSRedeSocialViewModel.ArquivoIcone.ContentType;
                }
                _cMSRedeSocialRepository.Add(cMSRedeSocial);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adicionar logo para a loja
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void AdicionarLogo(ref LojaViewModel lojaViewModel)
        {
            try
            {
                var cmsloja = _cMSLojaRepository.GetById(lojaViewModel.CMSLojaViewModel.ID);
                if (cmsloja != null)
                {
                    if (lojaViewModel.CMSLojaViewModel.ArquivoLog_1.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        lojaViewModel.CMSLojaViewModel.ArquivoLog_1.OpenReadStream().CopyTo(ms);
                        if (cmsloja.Logo == null)
                        {
                            cmsloja.Logo = ms.ToArray();
                            cmsloja.LogoType = lojaViewModel.CMSLojaViewModel.ArquivoLog_1.ContentType;
                        }else
                        {
                            cmsloja.Logo2 = ms.ToArray();
                            cmsloja.LogoType2 = lojaViewModel.CMSLojaViewModel.ArquivoLog_1.ContentType;
                        }
                        _cMSLojaRepository.Update(cmsloja);
                    }
                }
                else
                {
                    CMSLoja cMSLoja = new CMSLoja(Guid.Empty) {
                        IdLoja = lojaViewModel.ID
                    };
                    if (lojaViewModel.CMSLojaViewModel.ArquivoLog_1.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        lojaViewModel.CMSLojaViewModel.ArquivoLog_1.OpenReadStream().CopyTo(ms);
                        if (cMSLoja.Logo == null)
                        {
                            cMSLoja.Logo = ms.ToArray();
                            cMSLoja.LogoType = lojaViewModel.CMSLojaViewModel.ArquivoLog_1.ContentType;
                        }
                        else
                        {
                            cMSLoja.Logo2 = ms.ToArray();
                            cMSLoja.LogoType2 = lojaViewModel.CMSLojaViewModel.ArquivoLog_1.ContentType;
                        }
                    }
                    _cMSLojaRepository.Add(cMSLoja);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adicionar logo para a loja
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void AdicionarIcone(ref LojaViewModel lojaViewModel)
        {
            try
            {
                var cmsloja = _cMSLojaRepository.GetById(lojaViewModel.CMSLojaViewModel.ID);
                if (cmsloja != null)
                {
                    if (lojaViewModel.CMSLojaViewModel.ArquivoIcone.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        lojaViewModel.CMSLojaViewModel.ArquivoIcone.OpenReadStream().CopyTo(ms);
                        cmsloja.Icone = ms.ToArray();
                        cmsloja.IconeType = lojaViewModel.CMSLojaViewModel.ArquivoIcone.ContentType;
                        _cMSLojaRepository.Update(cmsloja);
                    }
                }
                else
                {
                    CMSLoja cMSLoja = new CMSLoja(Guid.Empty)
                    {
                        IdLoja = lojaViewModel.ID
                    };
                    if (lojaViewModel.CMSLojaViewModel.ArquivoIcone.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        lojaViewModel.CMSLojaViewModel.ArquivoIcone.OpenReadStream().CopyTo(ms);
                        cMSLoja.Icone = ms.ToArray();
                        cMSLoja.IconeType = lojaViewModel.CMSLojaViewModel.ArquivoIcone.ContentType;
                        _cMSLojaRepository.Add(cMSLoja);
                    }
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Excluir registro de rede social
        /// </summary>
        /// <param name="lojaViewModel"></param>
        public void ExcluirContatoLojaRedeSocial(ref LojaViewModel lojaViewModel)
        {
            try
            {
                Guid idCMS = Guid.Parse(lojaViewModel.submit.Split('_')[1].ToString());
                var excluir = _cMSRedeSocialRepository.GetById(idCMS);
                if (excluir != null)
                {
                    _cMSRedeSocialRepository.Remove(excluir);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Adiciona novo registro de contato de E-mail
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void AdicionarContatoLojaEmail(ref LojaViewModel lojaViewModel)
        {
            try
            {
                ContatoLoja contatoLoja = _contatoLojaRepository.GetContatoLojaPorLoja(lojaViewModel.ID);
                if (contatoLoja == null)
                {
                    contatoLoja = new ContatoLoja(Guid.NewGuid());
                    contatoLoja.IdLoja = lojaViewModel.ID;
                    contatoLoja.NomeContato = lojaViewModel.ContatoLojaViewModel.NomeContato;
                    _contatoLojaRepository.Add(contatoLoja);
                }

                ContatoLojaEmail contatoLojaEmail = new ContatoLojaEmail(Guid.NewGuid());
                contatoLojaEmail.IdContatoLoja = contatoLoja.ID;

                ContatoEmail contatoEmail = new ContatoEmail(Guid.NewGuid());
                contatoEmail.NomeContato = lojaViewModel.ContatoLojaViewModel.ContatoLojaEmail.ContatoEmail.NomeContato;
                contatoEmail.Email = lojaViewModel.ContatoLojaViewModel.ContatoLojaEmail.ContatoEmail.Email;
                _contatoEmailRepository.Add(contatoEmail);
                contatoLojaEmail.IdContatoEmail = contatoEmail.ID;
                _contatoLojaEmailRepository.Add(contatoLojaEmail);

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// REmove um registro de ContatoLojaEmail
        /// </summary>
        /// <param name="lojaViewModel"></param>
        /// <param name="idContatoEmail"></param>
        private void ExcluirContatoLojaEmail(ref LojaViewModel lojaViewModel, Guid idContatoEmail)
        {
            try
            {
                ContatoLojaEmail contatoLojaEmail = _contatoLojaEmailRepository.GetById(idContatoEmail);
                if (contatoLojaEmail != null)
                {
                    ContatoEmail contatoEmail = _contatoEmailRepository.GetById(contatoLojaEmail.IdContatoEmail);
                    if (contatoEmail != null)
                    {
                        _contatoEmailRepository.Remove(contatoEmail);
                    }
                    
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// FAz a busca do CMSWhatsApp para exibir os dados na tela.
        /// </summary>
        /// <param name="lojaViewModel"></param>
        private void GetCMSWhatsApp(ref LojaViewModel lojaViewModel)
        {
            try
            {
                var cmsWhatsApp = _cMSWhatsAppRepository.GetCMSWhatsApp().Result;
                lojaViewModel.CMSWhatsApp = _mapper.Map<CMSWhatsApp, CMSWhatsAppViewModel>(cmsWhatsApp);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private Endereco MapearEndereco(LojaViewModel lojaViewModel)
        {
            try
            {
                if (lojaViewModel?.ContatoLojaViewModel != null)
                {
                    if (lojaViewModel?.ContatoLojaViewModel?.ContatoLojaEndereco != null)
                    {
                        var cidade = _cidadeRepository.GetById(lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.idCidade);
                        var enderecoDomain = new Endereco(Guid.NewGuid())
                        {

                            Aliase = lojaViewModel?.ContatoLojaViewModel?.ContatoLojaEndereco.Endereco.Aliase,
                            Ativo = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Ativo,
                            Atualizado = DateTime.Now,
                            Cadastro = DateTime.Now,
                            Cidade = cidade,
                            CodigoPostal = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.CodigoPostal,
                            Complemento = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Complemento,
                            Logradouro = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Logradouro,
                            IdCidade = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.idCidade,
                            Numero = lojaViewModel.ContatoLojaViewModel.ContatoLojaEndereco.Endereco.Numero
                        };
                        return enderecoDomain;
                    }
                }
                return null;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Lojas/Delete/5
        public ActionResult Delete(Guid idLoja)
        {
            try
            {
                if (idLoja == Guid.Empty || idLoja == null)
                {
                    return NotFound();
                }
                LojaViewModel lojaViewModel = _mapper.Map<Loja, LojaViewModel>(_lojaRepository.GetById(idLoja));
                if (lojaViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Lojas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(LojaViewModel lojaViewModel)
        {
            try
            {
                Loja lojaDomain = _lojaRepository.GetById(lojaViewModel.ID);
                if (lojaDomain != null)
                {
                    _lojaRepository.Remove(lojaDomain);
                    return RedirectToAction(nameof(Index));
                }
                return View(path + "Delete.cshtml", lojaViewModel);
            }
            catch (Exception erro)
            {
                return View(path + "Delete.cshtml", lojaViewModel);
            }
        }

    }
}