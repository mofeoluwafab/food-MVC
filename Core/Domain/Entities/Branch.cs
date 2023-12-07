using System;

namespace food_app.Core.Domain.Entities
{
	public class Branch : AuditableEntity
	{
		public string Name { get; set; } = default!;
		public string CompanyId { get; set; } = default!;
		public Company Company { get; set; } = default!;
		public Address Address{ get; set; } = default!;
		public Director Director{ get; set; } = default!;
		public ICollection<Rider> Riders { get; set; } = new HashSet<Rider>();
	}
}