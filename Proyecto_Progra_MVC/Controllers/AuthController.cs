using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Progra_MVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
