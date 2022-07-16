using Microsoft.AspNetCore.Mvc;

namespace RazorPizza.Controllers
{
    public class YoutubeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
