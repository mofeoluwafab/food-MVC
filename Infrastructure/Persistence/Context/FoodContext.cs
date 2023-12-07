using System;
using food_app.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace food_app.Infrastructure.Persistence.Context
{
	public class FoodContext : DbContext
	{
		public FoodContext(DbContextOptions<FoodContext> options) : base(options)
		{
			
		}
		
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Branch> Branches { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<CompanyFood> CompanyFoods { get; set; }
		public DbSet<Director> Directors { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Manager> Managers { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Rider> Riders { get; set; }
		public DbSet<Wallet> Wallets { get; set; }
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderFood> OrderFoods { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Role> Roles { get; set; }
	}
}