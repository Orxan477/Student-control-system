using Microsoft.AspNetCore.Mvc;

namespace ElvinExam.Areas.admin.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
