﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class WorkController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
