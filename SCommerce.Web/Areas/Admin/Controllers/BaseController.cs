using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SCommerce.Domain.Entities.Empregado;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        
        public Empregado GetEmpregado()
        {
            try
            {
                var empregado = HttpContext.Session.GetString("empregado");
                if (empregado != null && empregado != String.Empty)
                {
                    var usuario = JsonConvert.DeserializeObject<Empregado>(empregado);
                    return usuario;
                }
                return null;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}