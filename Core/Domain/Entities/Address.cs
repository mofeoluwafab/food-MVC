using System;

namespace food_app.Core.Domain.Entities
{
	public class Address : AuditableEntity
	{
		public string Number{ get; set; } = default!;
		public string Street{ get; set; } = default!;
		public string City{ get; set; } = default!;
		public string State{ get; set; } = default!;
		public string Nationality{ get; set; } = default!;
		public string ZipCode{ get; set; } = default!;
		public string BranchId{ get; set; } = default!;
		public Branch Branch{ get; set; } = default!;
		public string UserId{ get; set; } = default!;
		public User User{ get; set; } = default!;
		
	}
}