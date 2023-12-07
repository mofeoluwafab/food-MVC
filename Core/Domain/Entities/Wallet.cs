using System;

namespace food_app.Core.Domain.Entities
{
	public class Wallet : AuditableEntity
	{
		public string UserId { get; set; } = default!;
		public User User { get; set; } = default!;
		public string RefNumber { get; set; } = default!;
		public double Balance { get; set; } = default!;
	}
}