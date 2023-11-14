using Book_Market.Data;
using Book_Market.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Book_Market.Controllers
{
	public class InfoController : Controller
	{
        public readonly BookDatabase _db;
        private readonly IWebHostEnvironment _en;
        public InfoController(BookDatabase db, IWebHostEnvironment en)
        {
            _db = db;
            _en = en;

        }

        //chỉnh sửa, xem thông tin cá nhân
        [HttpGet("/info")]
        
        public IActionResult Info()
		{
			string? username = HttpContext.Session.GetString("username");
            User? user = _db.users.Find(username);
			return View(user);
		}

		[HttpPost("/info")]
		public IActionResult Info([FromForm] User user, IFormFile img)
		{
            if (img != null && img.Length > 0)
            {
                var imagePath = Path.Combine(_en.WebRootPath, "user");

                // Đường dẫn đầy đủ để lưu trữ hình ảnh trong thư mục wwwroot
                var filePath = Path.Combine(imagePath, img.FileName);

                // Lưu hình ảnh vào đường dẫn
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                user.image = img.FileName;
            }

            _db.users.Update(user);
            _db.SaveChanges();
            ModelState.AddModelError("", "update success");
            return View(user);
        }

		//đăng sản phẩm
		[HttpGet("/post")]
		public IActionResult Post()
		{

			return View();
		}

        [HttpPost("/post")]
        public IActionResult Post([FromForm]Product product, IFormFile img)
        {
            if (img != null && img.Length > 0)
            {
                var imagePath = Path.Combine(_en.WebRootPath, "product");

                // Đường dẫn đầy đủ để lưu trữ hình ảnh trong thư mục wwwroot
                var filePath = Path.Combine(imagePath, img.FileName);

                // Lưu hình ảnh vào đường dẫn
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                product.Image = img.FileName;
                _db.products.Add(product);
                _db.SaveChanges();

                
                return RedirectToAction("Product","Home", new { Id = product.Id });

            }
            else
            {
                ModelState.AddModelError("", "Cần hình ảnh sản phẩm");
                return View();
            }

        }
	}
}
