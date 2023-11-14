using Book_Market.Data;
using Book_Market.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Market.Controllers
{
	public class HomeController : Controller
	{
        public readonly BookDatabase _db;
        public HomeController(BookDatabase db)
        {
            _db = db;
        }
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
        [HttpGet("/products/{Id}")]
        
        public IActionResult Product(Guid Id)
		{
            Product product = _db.products.Find(Id);
            return View(product);

        }

        //giỏ hàng
        //[HttpGet("/home/cart")]
        public IActionResult Cart()
		{
			return View();
		}

	}
}
