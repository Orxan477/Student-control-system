using ControlSystem.Business.Interfaces;
using ControlSystem.Business.ViewModels;
using ControlSystem.Business.ViewModels.Price;
using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Areas.admin.Controllers
{
    [Area("Admin")]
    public class PaidController : Controller
    {
        private AppDbContext _context;
        private IUnitOfWork _unitOfWork;
        private IPaidService _paidService;

        public PaidController(AppDbContext context,IUnitOfWork unitOfWork,IPaidService paidService)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _paidService = paidService;
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
            if (!await _paidService.CreatePaid(id)) return NotFound();
            return RedirectToAction("Index");
        }
        [Route("/UpdatePaid/{id}")]
        public async Task<IActionResult> UpdatePaid(int id)
        {
            var price = await _paidService.GetPaid(id);
            return View(price);
        }
        [Route("/UpdatePaid/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePaid(int id,PriceVM price)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (!await _paidService.UpdatePaid(id,price)) return NotFound();
            return RedirectToAction("Index");
        }
    }
}
