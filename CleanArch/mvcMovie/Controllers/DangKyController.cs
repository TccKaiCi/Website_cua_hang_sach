using Microsoft.AspNetCore.Mvc;

namespace Domain.Entities.Controllers
{
    public class DangKyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}