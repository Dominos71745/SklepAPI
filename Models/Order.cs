namespace SklepAPI.Models
{
	public class Order
	{
		public int Id { get; set; }
		public List<Product> Products { get; set; }
		public decimal TotalPrice => Products.Sum(p => p.Price);
	}
}
