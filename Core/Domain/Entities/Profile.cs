using System;
using food_app.Core.Domain.Enums;

namespace food_app.Core.Domain.Entities
{
    public class Profile : AuditableEntity
    {
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Image { get; set; } = default!;
        public DateTime DOB { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
    }
}