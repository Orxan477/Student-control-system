using ControlSystem.Business.Interfaces;
using ControlSystem.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = await _homeService.HomeView();
            return View(model);
        }
    }
}
