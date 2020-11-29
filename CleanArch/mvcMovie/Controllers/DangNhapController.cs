using Microsoft.AspNetCore.Mvc;

namespace Domain.Entities.Controllers
{
    public class DangNhapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}