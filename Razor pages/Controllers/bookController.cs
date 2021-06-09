using Microsoft.AspNetCore.Mvc;
using Razor_pages.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_pages.Controllers
{
	[Route("api/Book")]
	[ApiController]
	public class bookController : Controller
	{
		private readonly dbclass _db;

		public bookController(dbclass db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Json(new { data = _db.Book.ToList() });
		}
	}
}
