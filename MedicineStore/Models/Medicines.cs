using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineStore.Models
{
	[Table("Medicines")]
	public class Medicines
	{
		public int Id{ get; set; }

		public string Name { get; set; }
		public string Manufacturer{ get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Discount { get; set; }
		public int Quantity { get; set; }
		public DateTime ExpDate { get; set; }
		public string ImageUrl{ get; set; }
		public int Status{ get; set; }
		public string Type{ get; set; }


		//public Cart Cart { get; set; }
		//public OrderItems OrderItems { get; set; }
		//public Orders Orders { get; set; }
		//public Users Users { get; set; }


	}
}
