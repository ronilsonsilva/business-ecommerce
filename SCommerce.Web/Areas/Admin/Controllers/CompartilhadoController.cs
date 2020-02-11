using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.CMS;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompartilhadoController : BaseController
    {
        private readonly ILojaRepository _lojaRepository;
        private readonly ICMSRedeSocialRepository _cMSRedeSocialRepository;
        private readonly IPaisRepository _paisRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IProvinciaRepository _provinciaRepository;

        public CompartilhadoController(ILojaRepository lojaRepository, ICMSRedeSocialRepository cMSRedeSocialRepository, IPaisRepository paisRepository, ICidadeRepository cidadeRepository, IProvinciaRepository provinciaRepository)
        {
            _lojaRepository = lojaRepository;
            _cMSRedeSocialRepository = cMSRedeSocialRepository;
            _paisRepository = paisRepository;
            _cidadeRepository = cidadeRepository;
            _provinciaRepository = provinciaRepository;
        }

        /// <summary>
        /// Retorna um Lista/Json de todas provincias relacionada ao estado passado por parâmetro
        /// </summary>
        /// <param name="idPais"></param>
        /// <returns></returns>
        public IActionResult GetProvincias(Guid idPais)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var saida = _provinciaRepository.GetProvincias(idPais)
                    .Select(x => new { ID = x.ID, Nome = x.Nome + " (" + x.CodigoISO + ")" })
                    .OrderBy(x => x.Nome).ToList();
                return Json(saida);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Retorna uma lista/json de todas cidades relacionada a uma provincia
        /// </summary>
        /// <param name="idProvincia"></param>
        /// <returns></returns>
        public IActionResult GetCidades(Guid idProvincia)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var saida = _cidadeRepository.GetCidades(idProvincia)
                    .Select(x => new { x.ID, x.Nome }).OrderBy(x => x.Nome).ToList();
                return Json(saida);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}