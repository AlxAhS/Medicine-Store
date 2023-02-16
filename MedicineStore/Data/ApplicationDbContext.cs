using MedicineStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicineStore.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<Cart> Cart { get; set; }
		public DbSet<Medicines> Medicines{ get; set; }
		public DbSet<OrderItems> OrderItems{ get; set; }
		public DbSet<Orders> Orders{ get; set; }
		public DbSet<Users> Users{ get; set; }
	}
}
