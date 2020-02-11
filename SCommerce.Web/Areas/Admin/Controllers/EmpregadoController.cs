using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Entities.Empregado;
using SCommerce.Domain.Interfaces.Repositories.Empregado;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpregadoController : BaseController
    {
        private readonly IEmpregadoRepository _empregadoRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Empregado/";

        public EmpregadoController(IEmpregadoRepository empregadoRepository, IMapper mapper)
        {
            _empregadoRepository = empregadoRepository;
            _mapper = mapper;
        }

        // GET: Empregado
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<EmpregadoViewModel> empregadoViewModels = _mapper.Map<IEnumerable<Empregado>, IEnumerable<EmpregadoViewModel>>(_empregadoRepository.GetAll());
                return View(path + "Index.cshtml", empregadoViewModels);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Empregado/Details/5
        public ActionResult Details(Guid idEmpregado)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idEmpregado == Guid.Empty || idEmpregado == null)
                {
                    return NotFound();
                }
                EmpregadoViewModel empregadoViewModel = _mapper.Map<Empregado, EmpregadoViewModel>(_empregadoRepository.GetById(idEmpregado));
                if (empregadoViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", empregadoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Empregado/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                EmpregadoViewModel empregadoViewModel = new EmpregadoViewModel();
                return View(path + "Create.cshtml", empregadoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Empregado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpregadoViewModel empregadoViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (empregadoViewModel.Usuario != null && empregadoViewModel.Senha != null && empregadoViewModel.Nome != null)
                {
                    Empregado empregadoDomain = new Empregado(Guid.Empty)
                    {
                        Nome = empregadoViewModel.Nome,
                        Usuario = empregadoViewModel.Usuario
                    };
                    empregadoDomain.Cadastro = DateTime.Now;
                    empregadoDomain.Atualizado = DateTime.Now;
                    empregadoDomain.Senha = Utils.StringExtension.ConvertToMD5(empregadoViewModel.Senha);
                    _empregadoRepository.Add(empregadoDomain);
                    return RedirectToAction(nameof(Index));
                }
                return View(path + "Create.cshtml", empregadoViewModel);
            }
            catch(Exception erro)
            {
                return View(path + "Create.cshtml", empregadoViewModel);
            }
        }

        // GET: Empregado/Edit/5
        public ActionResult Edit(Guid idEmpregado)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idEmpregado == Guid.Empty || idEmpregado == null)
                {
                    return NotFound();
                }
                EmpregadoViewModel empregadoViewModel = _mapper.Map<Empregado, EmpregadoViewModel>(_empregadoRepository.GetById(idEmpregado));
                if (empregadoViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Edit.cshtml", empregadoViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Empregado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpregadoViewModel empregadoViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (empregadoViewModel.Usuario != null  && empregadoViewModel.Nome != null)
                {
                    Empregado empregadoDomain = new Empregado(empregadoViewModel.ID)
                    {
                        ID = empregadoViewModel.ID,
                        Nome = empregadoViewModel.Nome,
                        Usuario = empregadoViewModel.Usuario
                    };
                    empregadoDomain.Atualizado = DateTime.Now;
                    if (empregadoViewModel.Senha != null)
                    {
                        empregadoDomain.Senha = Utils.StringExtension.ConvertToMD5(empregadoViewModel.Senha);
                    }
                    _empregadoRepository.Update(empregadoDomain);
                    return RedirectToAction(nameof(Index));
                }
                return View(path + "Edit.cshtml", empregadoViewModel);
            }
            catch(Exception erro)
            {
                return View(path + "Create.cshtml", empregadoViewModel);
            }
        }

        // GET: Empregado/Delete/5
        public ActionResult Delete(Guid idEmpregado)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idEmpregado == Guid.Empty || idEmpregado == null)
                {
                    return NotFound();
                }
                EmpregadoViewModel empregadoViewModel = _mapper.Map<Empregado, EmpregadoViewModel>(_empregadoRepository.GetById(idEmpregado));
                if (empregadoViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", empregadoViewModel);
            }
            catch (Exception erro)
            {
                return View(path + "Delete.cshtml");
            }
        }

        // POST: Empregado/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmpregadoViewModel empregadoViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                Empregado empregadoDomain = _empregadoRepository.GetById(empregadoViewModel.ID);
                if (empregadoDomain != null)
                {
                    _empregadoRepository.Remove(empregadoDomain);
                    return RedirectToAction(nameof(Index));
                }
                return View(path + "Delete.cshtml", empregadoViewModel);
            }
            catch(Exception erro)
            {
                return View(path + "Delete.cshtml", empregadoViewModel);
            }
        }
    }
}