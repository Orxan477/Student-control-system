using ElvinExam.DAL;
using ElvinExam.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Areas.admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Subjects=await _context.Subjects.ToListAsync(),
                Settings=await _context.Settings.ToListAsync(),
            };
            return View(model);
        }
    }
}
