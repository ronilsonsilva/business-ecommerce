using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropriedadeController : BaseController
    {
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly IPropriedadeValorRepository _propriedadeValorRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Propriedade/";

        public PropriedadeController(IPropriedadeRepository propriedadeRepository, IPropriedadeValorRepository propriedadeValorRepository, IMapper mapper)
        {
            _propriedadeRepository = propriedadeRepository;
            _propriedadeValorRepository = propriedadeValorRepository;
            _mapper = mapper;
        }


        // GET: Propriedade
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<PropriedadeViewModel> propriedadeViewModel = _mapper.Map<IEnumerable<Propriedade>, IEnumerable<PropriedadeViewModel>>(_propriedadeRepository.GetAll());
                foreach (var item in propriedadeViewModel)
                {
                    if (item.PropriedadeValors == null)
                    {
                        item.PropriedadeValors = new Collection<PropriedadeValorViewModel>();
                    }
                    IEnumerable<PropriedadeValorViewModel> propriedadeValorViewModels = _mapper.Map<IEnumerable<PropriedadeValor>, IEnumerable<PropriedadeValorViewModel>>(_propriedadeValorRepository.GetByPropriedade(item.ID));
                    foreach (var item2 in propriedadeValorViewModels)
                    {
                        item.PropriedadeValors.Add(item2);
                    }
                }
                return View(path + "Index.cshtml", propriedadeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Propriedade/Details/5
        public ActionResult Details(Guid idPropriedade)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeViewModel propriedadeViewModel = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeRepository.GetById(idPropriedade));
                return View(path + "Details.cshtml", propriedadeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Propriedade/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeViewModel propriedadeViewModel = new PropriedadeViewModel();
                this.ConfigCreateEdit(propriedadeViewModel);
                return View(path + "Create.cshtml", propriedadeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ConfigCreateEdit(PropriedadeViewModel propriedadeViewModel)
        {
            try
            {
                ViewBag.Propriedades = _propriedadeRepository.GetAll();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropriedadeViewModel propriedadeViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Create.cshtml", propriedadeViewModel);
                }
                var propriedadeDomain = _mapper.Map<PropriedadeViewModel, Propriedade>(propriedadeViewModel);
                _propriedadeRepository.Add(propriedadeDomain);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                this.ConfigCreateEdit(propriedadeViewModel);
                return View(path + "Create.cshtml", propriedadeViewModel);
            }
        }

        // GET: Propriedade/Edit/5
        public ActionResult Edit(Guid idPropriedade)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeViewModel propriedadeViewModel = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeRepository.GetById(idPropriedade));
                this.ConfigCreateEdit(propriedadeViewModel);
                return View(path + "Edit.cshtml", propriedadeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PropriedadeViewModel propriedadeViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (propriedadeViewModel.IdPai == Guid.Empty)
                {
                    propriedadeViewModel.IdPai = null;
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Edit.cshtml", propriedadeViewModel);
                }
                var propriedadeDomain = _mapper.Map<PropriedadeViewModel, Propriedade>(propriedadeViewModel);
                _propriedadeRepository.Update(propriedadeDomain);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception erro)
            {
                this.ConfigCreateEdit(propriedadeViewModel);
                return View(path + "Edit.cshtml", propriedadeViewModel);
            }
        }

        // GET: Propriedade/Delete/5
        public ActionResult Delete(Guid idPropriedade)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeViewModel propriedadeViewModel = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeRepository.GetById(idPropriedade));
                return View(path + "Delete.cshtml", propriedadeViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PropriedadeViewModel propriedadeViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var propriedadeDomain = _mapper.Map<PropriedadeViewModel, Propriedade>(propriedadeViewModel);
                _propriedadeRepository.Remove(propriedadeDomain);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(path + "Delete.cshtml", propriedadeViewModel);
            }
        }

        public ActionResult Valores(Guid idPropriedade)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var propriedade = _propriedadeRepository.GetById(idPropriedade);
                ViewBag.NomePropriedade = propriedade?.Nome;
                ViewBag.IdPropriedade = idPropriedade;
                IEnumerable<PropriedadeValorViewModel> propriedadeValorViewModels = _mapper.Map<IEnumerable<PropriedadeValor>, IEnumerable<PropriedadeValorViewModel>>(_propriedadeValorRepository.GetByPropriedade(idPropriedade));
                return View(path + "Valores.cshtml", propriedadeValorViewModels);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ConfigCreateEditPropriedadeValor(PropriedadeValorViewModel propriedadeValorViewModel)
        {
            try
            {
                ViewBag.TipoDados = Utils.GetEnum.TipoDados();
                var propriedade = _propriedadeRepository.GetById(propriedadeValorViewModel.ID);
                ViewBag.NomePropriedade = propriedade?.Nome;
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ActionResult AdicionarValor(Guid idPropriedade)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeValorViewModel propriedadeValorViewModel = new PropriedadeValorViewModel();
                propriedadeValorViewModel.Propriedade = new PropriedadeViewModel();
                propriedadeValorViewModel.Propriedade.ID = idPropriedade;
                this.ConfigCreateEditPropriedadeValor(propriedadeValorViewModel);
                return View(path + "AdicionarValor.cshtml", propriedadeValorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/AdicionarValor/PropriedadeValorViewModel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarValor(PropriedadeValorViewModel propriedadeValorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "AdicionarValor.cshtml", propriedadeValorViewModel);
                }
                 var propriedadeValor = _mapper.Map<PropriedadeValorViewModel, PropriedadeValor>(propriedadeValorViewModel);
                var propriedade = _propriedadeRepository.GetById(propriedadeValorViewModel.Propriedade.ID);
                if (propriedade.propriedadeValors == null)
                {
                    propriedade.propriedadeValors = new Collection<PropriedadeValor>();
                }
                propriedade.propriedadeValors.Add(propriedadeValor);
                _propriedadeRepository.Update(propriedade);
                return RedirectToAction("Valores", new { idPropriedade = propriedade.ID});
            }
            catch (Exception erro)
            {
                return View(path + "AdicionarValor.cshtml", propriedadeValorViewModel);
            }
        }


        public ActionResult EditValor(Guid idPropriedadeValor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                ViewBag.TipoDados = Utils.GetEnum.TipoDados();
                PropriedadeValorViewModel propriedadeValorViewModel = _mapper.Map<PropriedadeValor, PropriedadeValorViewModel>(_propriedadeValorRepository.GetById(idPropriedadeValor));
                propriedadeValorViewModel.Propriedade = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeValorRepository.GetPropriedade(idPropriedadeValor));
                return View(path + "EditValor.cshtml", propriedadeValorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/EditValor/PropriedadeValorViewModel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditValor(PropriedadeValorViewModel propriedadeValorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "EditValor.cshtml", propriedadeValorViewModel);
                }
                var propriedadeValor = _mapper.Map<PropriedadeValorViewModel, PropriedadeValor>(propriedadeValorViewModel);
                _propriedadeValorRepository.Update(propriedadeValor);
                propriedadeValorViewModel.Propriedade = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeValorRepository.GetPropriedade(propriedadeValorViewModel.ID));
                return RedirectToAction("Valores", new { idPropriedade = propriedadeValorViewModel.Propriedade?.ID });
            }
            catch (Exception erro)
            {
                ViewBag.TipoDados = Utils.GetEnum.TipoDados();
                return View(path + "EditValor.cshtml", propriedadeValorViewModel);
            }
        }

        public ActionResult DetailsValor(Guid idPropriedadeValor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeValorViewModel propriedadeValorViewModel = _mapper.Map<PropriedadeValor, PropriedadeValorViewModel>(_propriedadeValorRepository.GetById(idPropriedadeValor));
                return View(path + "DetailsValor.cshtml", propriedadeValorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ActionResult DeleteValor(Guid idPropriedadeValor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                PropriedadeValorViewModel propriedadeValorViewModel = _mapper.Map<PropriedadeValor, PropriedadeValorViewModel>(_propriedadeValorRepository.GetById(idPropriedadeValor));
                return View(path + "DeleteValor.cshtml", propriedadeValorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Propriedade/DeleteValor/PropriedadeValorViewModel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteValor(PropriedadeValorViewModel propriedadeValorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var propriedadeValor = _mapper.Map<PropriedadeValorViewModel, PropriedadeValor>(propriedadeValorViewModel);
                propriedadeValorViewModel.Propriedade = _mapper.Map<Propriedade, PropriedadeViewModel>(_propriedadeValorRepository.GetPropriedade(propriedadeValorViewModel.ID));
                _propriedadeValorRepository.Remove(propriedadeValor);
                return RedirectToAction("Valores", new { idPropriedade = propriedadeValorViewModel.Propriedade?.ID });
            }
            catch (Exception erro)
            {
                return View(path + "DeleteValor.cshtml", propriedadeValorViewModel);
            }
        }
    }
}