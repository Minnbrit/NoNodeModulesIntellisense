using Microsoft.AspNetCore.Mvc;

namespace NoNodeModulesIntellisense.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}