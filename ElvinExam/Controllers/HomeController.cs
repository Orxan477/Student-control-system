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
                //Paids = await _context.Paids.Include(x=>x.Subject).ToListAsync(),
                //AzərbaycanDili=await _context.Paids.Where(x=>x.SubjectId==1).ToListAsync(),
                Paids=await _context.Paids.ToListAsync(),
                //İngilisDili=await _context.Paids.Where(x=>x.SubjectId==3).ToListAsync(),
                //Fizika=await _context.Paids.Where(x=>x.SubjectId==4).ToListAsync(),
                //Kimya=await _context.Paids.Where(x=>x.SubjectId==5).ToListAsync(),
            };
            return View(model);
        }
    }
}
