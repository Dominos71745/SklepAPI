using Microsoft.AspNetCore.Mvc;
using SklepAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private static List<Product> _products = new List<Product>
		{
			new Product { Id = 1, Name = "Koszulka", Description = "Delikatna koszulka męska", Price = 90.00m },
			new Product { Id = 2, Name = "Kurtka", Description = "Skórzana kurtka", Price = 250.00m },
        };

		[HttpGet]
		public ActionResult<IEnumerable<Product>> Get()
		{
			return _products;
		}

		[HttpGet("{id}")]
		public ActionResult<Product> GetById(int id)
		{
			var product = _products.FirstOrDefault(p => p.Id == id);
			if (product == null)
			{
				return NotFound();
			}
			return product;
		}
	}
}
