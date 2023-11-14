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
        [HttpGet("/products/{Category}/{Page}")]
       
        public IActionResult All_Product(string Category, int Page)
		{
            List<Product> count = _db.products.ToList();

			var maxPage = count.Count / 8;
			if (count.Count % 8 != 0)
			{
				maxPage++;
			}

            if(maxPage == 0)
            {
                maxPage = 1;
            }

			if (Page <= 0 || Page > maxPage)
			{
				Page = 1;
			}

            ViewBag.MaxPage = maxPage;
			ViewBag.Page=Page;
            ViewBag.Category=Category;

			if (Category == "all")
            {
               List<Product> products = _db.products.Skip((Page-1)*8).Take(8).ToList<Product>();
               return View(products);
            }

            List<Product> product= _db.products.Where(p=> p.Category == Category)
                                                .Skip((Page-1)*8)
                                                .Take(8).ToList<Product>();

			return View(product);
		}

        //chi tiết sản phẩm
        [HttpGet("/products/{Id}")]
        
        public IActionResult Product(Guid Id)
		{
            Product? product = _db.products.Find(Id);
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
