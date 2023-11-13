using Microsoft.AspNetCore.Mvc;

namespace Book_Market.Controllers
{
	public class HomeController : Controller
	{
        //trang chủ
        [HttpGet("/")]
        
        public IActionResult Home()
		{
			return View();
		}

        //tổng hợp sản phẩm
        //[HttpGet("/home/products")]
       
        public IActionResult All_Product()
		{
			return View();
		}

        //chi tiết sản phẩm
        //[HttpGet("/home/products/{id}")]
        
        public IActionResult Product()
		{
			return View();
		}

        //giỏ hàng
        //[HttpGet("/home/cart")]
        public IActionResult Cart()
		{
			return View();
		}

	}
}
