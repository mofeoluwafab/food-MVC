using System;

namespace food_app.Core.Domain.Entities
{
	public class User : AuditableEntity
	{
		public string Email{ get; set; } = default!;
		public string Password{ get; set; } = default!;
		public Manager Manager{ get; set; } = default!;
		public Director Director{ get; set; } = default!;
		public Rider Rider{ get; set; } = default!;
		public Customer Customer{ get; set; } = default!;
		public Wallet Wallet{ get; set; } = default!;
		public Address Address{ get; set; } = default!;
		public Profile Profile{ get; set; } = default!;
		public ICollection<UserRole> UserRoles = new HashSet<UserRole>();
	}
}