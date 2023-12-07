using System;

namespace food_app.Core.Domain.Entities
{
	public class Food : AuditableEntity
	{
		public string CategoryId { get; set; } = default!;
		public Category Category { get; set; } = default!;
		public ICollection<CompanyFood> CompanyFoods { get; set; } = new HashSet<CompanyFood>();
		public ICollection<OrderFood> OrderFoods { get; set; } = new HashSet<OrderFood>();
	}
}