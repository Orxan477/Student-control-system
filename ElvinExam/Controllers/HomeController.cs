using ControlSystem.Business.ViewModels;
using ControlSystem.Core.Interfaces;
using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Data.DAL;
using ControlSystem.Data.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        //private IMonthRepository _monthRepository;
        //private ISubjectRepository _subjectRepository;
        //private IPaidRepository _paidRepository;
        private IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Months=await _unitOfWork.MonthRepository.GetAll(),
                Subjects=await _unitOfWork.SubjectRepository.GetAll(),
                Paids=await _unitOfWork.PaidRepository.GetAll(),
            };
            return View(model);
        }
    }
}
