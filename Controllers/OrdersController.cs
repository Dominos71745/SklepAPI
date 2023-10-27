using Microsoft.AspNetCore.Mvc;
using SklepAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private static List<Order> _orders = new List<Order>();
		private static List<Product> _products = new List<Product>
		{
			new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.00m },
			new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.00m },
        };

		[HttpPost]
		public ActionResult<Order> CreateOrder(List<int> productIds)
		{
			var products = _products.Where(p => productIds.Contains(p.Id)).ToList();
			var order = new Order { Id = _orders.Count + 1, Products = products };
			_orders.Add(order);

			return order;
		}
	}
}
