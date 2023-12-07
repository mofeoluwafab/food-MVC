using System;

namespace food_app.Core.Domain.Entities
{
	public class Director : AuditableEntity
	{
		public string UserId { get; set; } = default!;
		public User User { get; set; } = default!;
		public string BranchId { get; set; } = default!;
		public Branch Branch { get; set; } = default!;
	}
}