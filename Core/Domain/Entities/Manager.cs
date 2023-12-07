using System;

namespace food_app.Core.Domain.Entities
{
	public class Manager: AuditableEntity
	{
		public string UserId { get; set; } = default!;
		public User User { get; set; } = default!;
		public string CompanyId { get; set; } = default!;
		public Company Company { get; set; } = default!;
	}
}