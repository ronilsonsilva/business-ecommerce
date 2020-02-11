using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Interfaces.Repositories.CMS;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CMSController : BaseController
    {
        ICMSSlidePrincipalRepository _CMSSlidePrincipal;
        IMapper _mapper;

        public CMSController(ICMSSlidePrincipalRepository CMSSlidePrincipal, IMapper mapper)
        {
            _CMSSlidePrincipal = CMSSlidePrincipal;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return RedirectToAction("SlidePrincipal");
        }

        public ActionResult SlidePrincipal()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                CMSSlidePrincipalViewModel viewModel = new CMSSlidePrincipalViewModel();

                viewModel.Slides = _mapper.Map<ICollection<CMSSlidePrincipal>, ICollection<CMSSlidePrincipalViewModel>>(_CMSSlidePrincipal.GetAll().ToList());
                return View(viewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SlidePrincipal(CMSSlidePrincipalViewModel viewModel, string submit)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (submit.Equals("Adiconar"))
                {
                    if (ModelState.IsValid)
                    {
                        var cmsSlider = new CMSSlidePrincipal(Guid.Empty);
                        cmsSlider.Atualizado = DateTime.Now;
                        cmsSlider.Cadastro = DateTime.Now;
                        cmsSlider.DataInicio = viewModel.DataInicio;
                        cmsSlider.DataFinal = viewModel.DataFinal;
                        cmsSlider.TituloPrincipal = viewModel.TituloPrincipal;
                        cmsSlider.Subtitulo = viewModel.Subtitulo;
                        if (viewModel.ArquivoImagem != null && viewModel.ArquivoImagem.Length != 0)
                        {
                            MemoryStream ms = new MemoryStream();
                            viewModel.ArquivoImagem.OpenReadStream().CopyTo(ms);
                            cmsSlider.ArquivoImage = ms.ToArray();
                            cmsSlider.ArquivoType = viewModel.ArquivoImagem.ContentType;

                        }
                        _CMSSlidePrincipal.Add(cmsSlider);
                    }
                }
                else if (submit.StartsWith("ExcluirSlide_"))
                {
                    Guid idSlide = Guid.Parse(submit.Split('_')[1]);
                    var slideDomain = _CMSSlidePrincipal.GetById(idSlide);
                    if (slideDomain != null)
                    {
                        _CMSSlidePrincipal.Remove(slideDomain);
                    }
                }

                viewModel.Slides = _mapper.Map<ICollection<CMSSlidePrincipal>, ICollection<CMSSlidePrincipalViewModel>>(_CMSSlidePrincipal.GetAll().ToList());
                return View(viewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}