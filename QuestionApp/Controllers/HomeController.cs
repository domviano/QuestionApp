using Microsoft.AspNetCore.Mvc;

namespace QuestionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
