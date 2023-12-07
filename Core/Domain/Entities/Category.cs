using System;

namespace food_app.Core.Domain.Entities
{
	public class Category : AuditableEntity
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public ICollection<Food> Foods { get; set; } = new HashSet<Food>();
	}
}