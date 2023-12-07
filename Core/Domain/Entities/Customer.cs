using System;

namespace food_app.Core.Domain.Entities
{
	public class Customer : AuditableEntity
	{
		public string UserId { get; set; } = default!;
		public User User { get; set; } = default!;
		public ICollection<Order> Order { get; set; } = new HashSet<Order>();
	}
}