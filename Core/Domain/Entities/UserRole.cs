using System;

namespace food_app.Core.Domain.Entities
{
	public class UserRole : AuditableEntity
	{
		public string UserId { get; set; } = default!;
		public User User { get; set; } = default!;
		public string RoleId { get; set; } = default!;
		public Role Role { get; set; } = default!;
		
	}
}