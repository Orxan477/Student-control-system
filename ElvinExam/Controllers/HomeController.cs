using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
