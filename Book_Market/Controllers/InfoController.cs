using Microsoft.AspNetCore.Mvc;

namespace Book_Market.Controllers
{
	public class InfoController : Controller
	{
        //chỉnh sửa, xem thông tin cá nhân
        //[HttpGet("/home/info")]
        
        public IActionResult Info()
		{
			return View();
		}

        //đăng sản phẩm
        //[HttpGet("/home/post")]

        
        public IActionResult Post()
		{
			return View();
		}
	}
}
