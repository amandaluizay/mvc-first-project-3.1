using System;
using Microsoft.AspNetCore.Mvc;
namespace dev.appModelo.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
