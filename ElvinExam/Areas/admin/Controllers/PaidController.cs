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
        private IUnitOfWork _unitOfWork;
        private IPaidService _paidService;
        private IHomeService _homeService;

        public PaidController(IUnitOfWork unitOfWork, IPaidService paidService,IHomeService homeService)
        {
            _unitOfWork = unitOfWork;
            _paidService = paidService;
            _homeService = homeService;
        }
        [Route("/admin")]
        public async Task<IActionResult> Index()
        {
            HomeVM model = await _homeService.AdminView();
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

            try
            {
                var price = await _paidService.GetPaid(id);
                return View(price);
            }
            catch (Exception ex)
            {

                return Json("NotFound"); 
            }
        }
        [Route("/UpdatePaid/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePaid(int id, PriceVM price)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (!await _paidService.UpdatePaid(id, price)) return NotFound();
            return RedirectToAction("Index");
        }
    }
}
