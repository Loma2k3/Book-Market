using Microsoft.AspNetCore.Mvc;

namespace Book_Market.Controllers
{
	public class LoginController : Controller
	{
        //[HttpGet("/")]
        
        public IActionResult Login()
		{
			return View();
		}
        

        public IActionResult Register()
		{
			return View();
		}
    }
}
