using ControlSystem.Business.ViewModels;
using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private AppDbContext _context;

        public HomeController(AppDbContext context,IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Months = await _unitOfWork.MonthRepository.GetAll(),
                Subjects = await _unitOfWork.SubjectRepository.GetAll(),
                Paids=await _unitOfWork.PaidRepository.GetAll(),
            };
            return View(model);
        }
    }
}
