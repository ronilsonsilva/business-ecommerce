using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Entities.Fornecedor;
using SCommerce.Domain.Interfaces.Repositories.Fornecedor;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FornecedorController : BaseController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Fornecedor/";

        public FornecedorController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        // GET: Fornecedor
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<FornecedorViewModel> fornecedorViewModel = _mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorRepository.GetAll());
                return View(path + "Index.cshtml", fornecedorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(Guid idFornecedor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFornecedor == Guid.Empty || idFornecedor == null)
                {
                    return NotFound();
                }
                FornecedorViewModel fornecedorViewModel = _mapper.Map<Fornecedor, FornecedorViewModel>(_fornecedorRepository.GetById(idFornecedor));
                if (idFornecedor == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", fornecedorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                FornecedorViewModel fornecedorViewModel = new FornecedorViewModel();

                return View(path + "Create.cshtml", fornecedorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Create.cshtml", fornecedorViewModel);
                }
                fornecedorViewModel.DataAtualizacao = DateTime.Now;
                fornecedorViewModel.DataCadastro = DateTime.Now;
                var fonecedorDomain = _mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
                _fornecedorRepository.Add(fonecedorDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(path + "Create.cshtml", fornecedorViewModel);
            }
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(Guid idFornecedor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFornecedor == Guid.Empty || idFornecedor == null)
                {
                    return NotFound();
                }
                FornecedorViewModel fornecedorViewModel = _mapper.Map<Fornecedor, FornecedorViewModel>(_fornecedorRepository.GetById(idFornecedor));
                if (idFornecedor == null)
                {
                    return NotFound();
                }
                return View(path + "Edit.cshtml", fornecedorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Edit.cshtml", fornecedorViewModel);
                }
                fornecedorViewModel.DataAtualizacao = DateTime.Now;
                var fonecedorDomain = _mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
                _fornecedorRepository.Update(fonecedorDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(path + "Edit.cshtml", fornecedorViewModel);
            }
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(Guid idFornecedor)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFornecedor == Guid.Empty || idFornecedor == null)
                {
                    return NotFound();
                }
                FornecedorViewModel fornecedorViewModel = _mapper.Map<Fornecedor, FornecedorViewModel>(_fornecedorRepository.GetById(idFornecedor));
                if (idFornecedor == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", fornecedorViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fornecedor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var fornecedorDomain = _mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
                _fornecedorRepository.Remove(fornecedorDomain);
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View(path + "Delete.cshtml", fornecedorViewModel);
            }
        }
    }
}