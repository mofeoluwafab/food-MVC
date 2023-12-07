using System;

namespace food_app.Core.Domain
{
	public abstract class AuditableEntity
	{
		public string Id{ get; set; } = Guid.NewGuid().ToString();
		public bool IsDeleted{ get; set; } 
		public string DeletedBy{ get; set; } = default!;
		public string ModifiedBy{ get; set; } = default!;
		public DateTime DateCreated{ get; set; } = DateTime.Now;
		public DateTime DateModified{ get; set; } = DateTime.Now;
		
	}
}