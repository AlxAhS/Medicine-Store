using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineStore.Models
{
	[Table("Cart")]
	public class Cart
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Discount { get; set; }
		public int Quantity { get; set; }
		public decimal TotalPrice { get; set; }
		public int MedicineId { get; set; }
		 

		//public Medicines Medicines { get; set; }
		//public OrderItems OrderItems { get; set; }
		//public Orders Orders { get; set;}
		//public Users Users { get; set; }

	}
}
