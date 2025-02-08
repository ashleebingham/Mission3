using System.Diagnostics;
using IS413Mission5.Models;
using Microsoft.AspNetCore.Mvc;

namespace IS413Mission5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Time()
        {
            return View();
        }
    }
}
