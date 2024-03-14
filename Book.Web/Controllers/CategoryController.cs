using Microsoft.AspNetCore.Mvc;

namespace Book.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
