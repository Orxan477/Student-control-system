using ElvinExam.DAL;
using ElvinExam.Models;
using ElvinExam.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Areas.admin.Controllers
{
    [Area("Admin")]
    public class PaidController : Controller
    {
        private AppDbContext _context;

        public PaidController(AppDbContext context)
        {
            _context = context;
        }
        [Route("/admin")]
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Subjects=await _context.Subjects.ToListAsync(),
                Settings=await _context.Settings.ToListAsync(),
            };
            return View(model);
        }
        [Route("/CreatePaid/{id}")]
        public async Task<IActionResult> CreatePaid(int id)
        {
            var subject = await _context.Settings.Where(x => x.SubjectId == id).FirstOrDefaultAsync();
            if (subject is null) return NotFound();
            Paids newPaid = new Paids()
            {
                SubjectId = id,
                Price = subject.Price
            };
            await _context.Paids.AddAsync(newPaid);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
