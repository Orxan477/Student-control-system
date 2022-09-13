using ElvinExam.DAL;
using ElvinExam.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Months=
            };
            return View();
        }
    }
}
