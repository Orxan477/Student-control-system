using ControlSystem.Business.ViewModels;
using ControlSystem.Business.ViewModels.Price;
using ControlSystem.Core.Interfaces;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Areas.admin.Controllers
{
    [Area("Admin")]
    public class PaidController : Controller
    {
        private AppDbContext _context;
        private IUnitOfWork _unitOfWork;

        public PaidController(AppDbContext context,IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        [Route("/admin")]
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Subjects=await _unitOfWork.SubjectRepository.GetAll(),
                Settings=await _unitOfWork.SettingRepository.GetAll(),
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
        [Route("/UpdatePaid/{id}")]
        public async Task<IActionResult> UpdatePaid(int id)
        {
            var subject = await _unitOfWork.SettingRepository.Get(x => x.SubjectId == id);
            if (subject is null) return NotFound();
            PriceVM price = new PriceVM()
            {
                Id=id,
                NewPrice = subject.Price,
            };
            return View(price);
        }
        [Route("/UpdatePaid/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePaid(int id,PriceVM price)
        {
            if (!ModelState.IsValid) return BadRequest();
            var subject = await _unitOfWork.SettingRepository.Get(x => x.SubjectId == id);
            if (subject is null) return NotFound();
            subject.Price = price.NewPrice;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
