using Microsoft.AspNetCore.Mvc;

namespace Learn.Github.Controllers
{
    public class LearnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
