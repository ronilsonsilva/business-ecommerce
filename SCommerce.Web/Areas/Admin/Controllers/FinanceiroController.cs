using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FinanceiroController : BaseController
    {
        public IActionResult Index()
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}