using ElvinExam.DAL;
using ElvinExam.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Controllers
{
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
                Months = await _context.Months.ToListAsync(),
                Subjects = await _context.Subjects.ToListAsync(),
                Paids=await _context.Paids.ToListAsync(),
            };
            return View(model);
        }
    }
}
