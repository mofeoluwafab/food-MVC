using System;

namespace food_app.Core.Domain.Entities
{
	public class Role : AuditableEntity
	{
		public string Name{ get; set; } = default!;
		public string Description{ get; set; } = default!;
		public ICollection<UserRole> UserRoles = new HashSet<UserRole>();
	}
}