using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineStore.Models
{
	[Table("Orders")]
	public class Orders
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string OrderNo{ get; set; }
		public decimal OrderTotal { get; set; }
		public string OrderStatus{ get; set; }

		//public Cart Cart { get; set; }
		//public Medicines Medicines { get; set; }
		public OrderItems OrderItems { get; set; } 
		public Users Users { get; set; }
	}
}
