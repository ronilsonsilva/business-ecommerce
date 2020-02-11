using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.Produto;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriaController : BaseController
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/Categoria/";

        public CategoriaController(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }


        // GET: Categoria
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<CategoriaViewModel> categoriaViewModel = _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaRepository.GetAll());
                ViewBag.CategorisComProdutos = _categoriaRepository.CategoriaComProdutos();
                return View(path + "Index.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        

        // GET: Categoria/Details/5
        public ActionResult Details(Guid idCategoria)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCategoria == Guid.Empty || idCategoria == null)
                {
                    return NotFound();
                }
                CategoriaViewModel categoriaViewModel = _mapper.Map<Categoria, CategoriaViewModel>(_categoriaRepository.GetById(idCategoria));
                if (categoriaViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ConfigCreate(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                ViewBag.Categorias = new SelectList(_categoriaRepository.GetCategoriasRoot(), "ID", "Nome", categoriaViewModel.CategoriaPai);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                CategoriaViewModel categoriaViewModel = new CategoriaViewModel();
                this.ConfigCreate(categoriaViewModel);
                return View(path + "Create.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Create.cshtml", categoriaViewModel);
                }
                var categoriaDomain = _mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
                categoriaDomain.Cadastro = DateTime.Now;
                categoriaDomain.Atualizado = DateTime.Now;
                _categoriaRepository.Add(categoriaDomain);
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                this.ConfigCreate(categoriaViewModel);
                return View(path + "Create.cshtml", categoriaViewModel);
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(Guid idCategoria)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCategoria == Guid.Empty || idCategoria == null)
                {
                    return NotFound();
                }
                CategoriaViewModel categoriaViewModel = _mapper.Map<Categoria, CategoriaViewModel>(_categoriaRepository.GetById(idCategoria));
                if (categoriaViewModel == null)
                {
                    return NotFound();
                }
                this.ConfigCreate(categoriaViewModel);
                return View(path + "Edit.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (!ModelState.IsValid)
                {
                    return View(path + "Edit.cshtml", categoriaViewModel);
                }
                var categoriaDomain = _mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
                _categoriaRepository.Update(categoriaDomain);
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                this.ConfigCreate(categoriaViewModel);
                return View(path + "Edit.cshtml", categoriaViewModel);
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(Guid idCategoria)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCategoria == Guid.Empty || idCategoria == null)
                {
                    return NotFound();
                }
                CategoriaViewModel categoriaViewModel = _mapper.Map<Categoria, CategoriaViewModel>(_categoriaRepository.GetById(idCategoria));
                if (categoriaViewModel == null)
                {
                    return NotFound();
                }
                return View(path + "Delete.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var categoriaDomain = _categoriaRepository.GetById(categoriaViewModel.ID);
                if (categoriaDomain != null)
                {
                    _categoriaRepository.Remove(categoriaDomain);
                    return RedirectToAction("Index");
                }
                return View(path + "Delete.cshtml", categoriaViewModel);
            }
            catch (Exception erro)
            {
                return View(path + "Delete.cshtml", categoriaViewModel);
            }
        }
    }
}