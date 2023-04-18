using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
