using Book_Market.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BookDatabase>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("BookConnect"));
});

builder.Services.AddSession(option =>
{
	option.IdleTimeout = TimeSpan.FromMinutes(30);

});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();

/*
 Các trang phải tạo:
- đăng nhập, đăng ký
- trang chủ
- tổng hợp sản phẩm
- chi tiết sản phẩm
- giỏ hàng
- đăng thông tin sản phẩm
- thông tin cá nhân
 (đặt tên class chuẩn bem)
 */
