using Microsoft.AspNetCore.Mvc;

namespace MarketSG.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
