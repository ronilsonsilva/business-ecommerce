using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Entities.Fabricante;
using SCommerce.Domain.Interfaces.Repositories.Fabricante;
using SCommerce.Web.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FabricanteController : BaseController
    {
        private readonly IFabricanteRepository _fabricanteRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Fabricante/";

        public FabricanteController(IFabricanteRepository fabricanteRepository, IMapper mapper)
        {
            _fabricanteRepository = fabricanteRepository;
            _mapper = mapper;
        }

        // GET: Fabricante
        public ActionResult Index()
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            IEnumerable<FabricanteViewModels> fabricanteViewModels = _mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteViewModels>>(_fabricanteRepository.GetAll());
            return View(path + "Index.cshtml", fabricanteViewModels);
        }

        // GET: Fabricante/Details/5
        public ActionResult Details(Guid idFabricante)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFabricante == Guid.Empty || idFabricante == null)
                {
                    return NotFound();
                }
                FabricanteViewModels fabricanteViewModel = _mapper.Map<Fabricante, FabricanteViewModels>(_fabricanteRepository.GetById(idFabricante));
                if (fabricanteViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", fabricanteViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Fabricante/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                FabricanteViewModels fabricanteViewModels = new FabricanteViewModels();

                return View(path + "Create.cshtml", fabricanteViewModels);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fabricante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FabricanteViewModels fabricanteViewModels)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                fabricanteViewModels.DataAtualizacao = DateTime.Now;
                fabricanteViewModels.DataCadastro = DateTime.Now;
                var fabricanteDomain = _mapper.Map<FabricanteViewModels, Fabricante>(fabricanteViewModels);
                _fabricanteRepository.Add(fabricanteDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(path + "Create.cshtml", fabricanteViewModels);
            }
        }

        // GET: Fabricante/Edit/5
        public ActionResult Edit(Guid idFabricante)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFabricante == Guid.Empty || idFabricante == null)
                {
                    return NotFound();
                }
                FabricanteViewModels fabricanteViewModel = _mapper.Map<Fabricante, FabricanteViewModels>(_fabricanteRepository.GetById(idFabricante));
                if (fabricanteViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Edit.cshtml", fabricanteViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fabricante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FabricanteViewModels fabricanteViewModels)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                fabricanteViewModels.DataAtualizacao = DateTime.Now;
                var fabricanteDomain = _mapper.Map<FabricanteViewModels, Fabricante>(fabricanteViewModels);
                _fabricanteRepository.Update(fabricanteDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(path + "Edit.cshtml", fabricanteViewModels);
            }
        }


        // GET: Fabricante/Delete/5
        public ActionResult Delete(Guid idFabricante)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idFabricante == Guid.Empty || idFabricante == null)
                {
                    return NotFound();
                }
                FabricanteViewModels fabricanteViewModel = _mapper.Map<Fabricante, FabricanteViewModels>(_fabricanteRepository.GetById(idFabricante));
                if (fabricanteViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", fabricanteViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Fabricante/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FabricanteViewModels fabricanteViewModels)
        {
            try
            {
                try
                {
                    if (GetEmpregado() == null)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    var fabricanteDomain = _mapper.Map<FabricanteViewModels, Fabricante>(fabricanteViewModels);
                    _fabricanteRepository.Remove(fabricanteDomain);
                    return RedirectToAction("Index");
                }
                catch (Exception erro)
                {
                    throw erro;
                }
            }
            catch
            {
                return View(path + "Delete.cshtml", fabricanteViewModels);
            }
        }
    }
}