using ControlSystem.Business.Interfaces;
using ControlSystem.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        private IExamOfWork _examOfWork;

        public HomeController(IExamOfWork examOfWork)
        {
            _examOfWork = examOfWork;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = await _examOfWork.HomeService.HomeView();
            return View(model);
        }
    }
}
