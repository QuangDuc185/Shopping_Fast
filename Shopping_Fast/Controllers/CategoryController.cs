using Microsoft.AspNetCore.Mvc;

namespace Shopping_Fast.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
