using System;
using food_app.Core.Domain.Enums;

namespace food_app.Core.Domain.Entities
{
	public class Order : AuditableEntity
	{
		public string RefNumber { get; set; } = default!;
		public string CustomerId { get; set; } = default!;
		public OrderStatus Status { get; set; } = default!;
		public Customer Customer { get; set; } = default!;
		public ICollection<OrderFood> OrderFoods { get; set; } = new HashSet<OrderFood>();
		public double TotalPrice { get; set; } = default!;
	}
}