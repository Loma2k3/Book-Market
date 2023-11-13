﻿using Book_Market.Data;
using Book_Market.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Market.Controllers
{
	public class LoginController : Controller
	{
		public readonly BookDatabase _db;
        public LoginController(BookDatabase db)
        {
            _db = db;
        }

        [HttpGet("/Login")]
        public IActionResult Login()
		{
			return View();
		}

		[HttpPost("/Login")]
		public IActionResult Login(Authentication user)
		{
			if (ModelState.IsValid)
			{
				if(_db.users.FirstOrDefault(u=> u.userName==user.Username && u.password==user.Password) == null)
				{
					ModelState.AddModelError("","username or password is wrong");
					return View();
				}

				HttpContext.Session.SetString("username",user.Username);
				return RedirectToAction("Home","Home");
			}
			return View();
		}

		//register user

		[HttpGet("/register")]
        public IActionResult Register()
		{
			return View();
		}

		[HttpPost("/register")]
		public IActionResult Register(User user)
		{
			if (ModelState.IsValid)
			{
				if(_db.users.FirstOrDefault(u => u.userName== user.userName) == null)
				{
                    _db.users.Add(user);
                    _db.SaveChanges();
                    return RedirectToAction("Login");
                }

				ModelState.AddModelError("", "this username is exist");
				return View();
			}

			return View();
		}
	}
}
