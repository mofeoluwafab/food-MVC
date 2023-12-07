using System;

namespace food_app.Core.Domain.Entities
{
	public class Company : AuditableEntity
	{
		public string Name { get; set; } = default!;
		public string Logo { get; set; } = default!;
		public string CACCertificate { get; set; } = default!;
		public string CACRegNumber { get; set; } = default!;
		public Manager Manager { get; set; } = default!;
		public ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();
		public ICollection<CompanyFood> CompanyFoods { get; set; } = new HashSet<CompanyFood>();
		
	}
}