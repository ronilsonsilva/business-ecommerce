using System;
using System.Collections.Generic;
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
    public class CategoriaProdutoController : BaseController
    {
        private readonly ICategoriaProdutoRepository _categoriaProdutoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        private const string path = "~/Areas/Admin/Views/CategoriaProduto/";

        public CategoriaProdutoController(ICategoriaProdutoRepository categoriaProdutoRepository, ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaProdutoRepository = categoriaProdutoRepository;
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }


        // GET: CategoriaProduto
        public ActionResult Index()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                IEnumerable<CategoriaProdutoViewModel> categoriaModels = _mapper.Map<IEnumerable<CategoriaProduto>, IEnumerable<CategoriaProdutoViewModel>>(_categoriaProdutoRepository.GetAll());
                return View(path + "Index.cshtml", categoriaModels);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        // GET: CategoriaProduto/Details/5
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
                CategoriaProdutoViewModel categoriaProduto = _mapper.Map<CategoriaProduto, CategoriaProdutoViewModel>(_categoriaProdutoRepository.GetById(idCategoria));
                if (categoriaProduto == null)
                {
                    return NotFound();
                }
                return View(path + "Details.cshtml", categoriaProduto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // GET: CategoriaProduto/Create
        public ActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                CategoriaProdutoViewModel categoriaProduto = new CategoriaProdutoViewModel();

                return View(path + "Create.cshtml", categoriaProduto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        // POST: CategoriaProduto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaProdutoViewModel categoriaProdutoViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                //CategoriaViewModel categoriaViewModel = categoriaProdutoViewModel.Categoria;
                //var categoriaDomain = _mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
                //_categoriaRepository.Add(categoriaDomain);
                //var categoriaProdutDomain = _mapper.Map<CategoriaProdutoViewModel, CategoriaProduto>(categoriaProdutoViewModel);
                //categoriaProdutDomain.Categoria = 
                return View();
            }
            catch
            {
                return View(path + "Create.cshtml", categoriaProdutoViewModel);
            }
        }

        // GET: CategoriaProduto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaProduto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaProduto/Delete/5
        public ActionResult Delete(int id)
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        // POST: CategoriaProduto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}