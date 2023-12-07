using System;

namespace food_app.Core.Domain.Entities
{
	public class OrderFood : AuditableEntity
	{
		public string OrderId { get; set; } = default!;
		public Order Order { get; set; } = default!;
		public string FoodId { get; set; } = default!;
		public Food Food { get; set; } = default!;
		public int Quantity { get; set; } = default!;
	}
}