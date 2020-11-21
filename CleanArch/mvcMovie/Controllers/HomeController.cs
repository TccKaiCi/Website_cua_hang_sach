using Microsoft.AspNetCore.Mvc;

namespace Domain.Entities.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}