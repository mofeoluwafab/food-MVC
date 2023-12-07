using System;

namespace food_app.Core.Domain.Entities
{
	public class CompanyFood : AuditableEntity
	{
		public string CompanyId { get; set; } = default!;
		public Company Company { get; set; } = default!;
		public string FoodId { get; set; } = default!;
		public Food Food { get; set; } = default!;
		public double Price { get; set; } = default!;
	}
}