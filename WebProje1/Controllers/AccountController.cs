using Microsoft.AspNetCore.Mvc;

namespace WebProje1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
