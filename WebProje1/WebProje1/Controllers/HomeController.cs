using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProje1.Models;

namespace WebProje1.Controllers
{
	public class HomeController : Controller
	{
        private readonly UserService _userService;

        public HomeController( UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            var user = _userService.GetUser(userName);

            if (user != null && user.Password == password)
            {
                // Kullanıcı başarılı bir şekilde giriş yaptı, işlemlerinizi gerçekleştirin.
                ViewBag.Message = "Giriş başarılı!";
            }
            else
            {
                // Kullanıcı adı veya şifre yanlış, hata mesajı göster.
                ViewBag.Message = "Kullanıcı adı veya şifre yanlış!";
            }

            return View("Index");
        }
    }
}
