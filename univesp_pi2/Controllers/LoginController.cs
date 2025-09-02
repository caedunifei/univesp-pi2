using Microsoft.AspNetCore.Mvc;
using univesp_pi2.Models;

namespace univesp_pi2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login(LoginViewModel login)
        {
            if(login.User == null && login.Password == null)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
