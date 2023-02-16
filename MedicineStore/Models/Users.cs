using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineStore.Models
{
	[Table("Users")]
	public class Users
	{
		public int Id { get; set; }

		//[Column(TypeName = "nvarchar(100)")]
		public string FirstName { get; set; }

		//[Column(TypeName = "nvarchar(100)")]
		public string LastName { get; set; }

		//[Column(TypeName = "nvarchar(100)")]
		public string Password { get; set; }

		//[Column(TypeName = "nvarchar(100)")]
		public string Email { get; set; }

		//[Column(TypeName = "decimal(18,2)")]
		public decimal Fund { get; set; }

		//[Column(TypeName = "nvarchar(100)")]
		public string Type { get; set; }

		//[Column(TypeName = "int (100)")]
		public int Status { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.UtcNow;


		//public Cart Cart { get; set; }
		//public Medicines Medicines { get; set; }
		//public OrderItems OrderItems { get; set; }
		//public Orders Orders { get; set; } 
		 
	}
}
