using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SCommerce.Domain.Interfaces.Repositories.Empregado;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : BaseController
    {
        private readonly IEmpregadoRepository _empregadoRepository;

        public LoginController(IEmpregadoRepository empregadoRepository)
        {
            _empregadoRepository = empregadoRepository;
        }

        public IActionResult Index()
        {
            try
            {
                if (GetEmpregado() != null)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        public IActionResult Index(String usuario, String Senha)
        {
            try
            {
                if (GetEmpregado() != null)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                var empregado = _empregadoRepository.Login(usuario: usuario, senha: Utils.StringExtension.ConvertToMD5(Senha));
                if (empregado != null)
                {
                    HttpContext.Session.SetString("empregado", JsonConvert.SerializeObject(empregado));
                    return Redirect("/Admin/Dashboard");
                }
                ViewBag.mensagem = "Usuario ou senha incorreto";
                return View();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public IActionResult EncerarSessao()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                HttpContext.Session.SetString("empregado", JsonConvert.SerializeObject(String.Empty));
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {

                throw;
            }
        }
    }
}