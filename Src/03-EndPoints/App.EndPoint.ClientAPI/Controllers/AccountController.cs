using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
