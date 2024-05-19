using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
