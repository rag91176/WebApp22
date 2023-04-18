using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                string un = loginModel.Username;
                string pw = loginModel.Password;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
