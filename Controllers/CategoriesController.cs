using Microsoft.AspNetCore.Mvc;
using SklepAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private static List<Category> _categories = new List<Category>
		{
			new Category { Id = 1, Name = "Kategoria 1" },
			new Category { Id = 2, Name = "Kategoria 2" },
        };

		[HttpGet]
		public ActionResult<IEnumerable<Category>> Get()
		{
			return _categories;
		}

		[HttpGet("{id}")]
		public ActionResult<Category> GetById(int id)
		{
			var category = _categories.FirstOrDefault(c => c.Id == id);
			if (category == null)
			{
				return NotFound();
			}
			return category;
		}
	}
}
