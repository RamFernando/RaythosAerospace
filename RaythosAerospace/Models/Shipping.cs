using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class Shipping
	{
		public Shipping()
		{
		}
		[Key]
		public int ShippingId { get; set; }
		public string ShippingMethod { get; set; }
		public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }

		//Relationships
		public int OrderId { get; set; }
		[ForeignKey("OrderId")]
		public Order Order { get; set; }
	}
}

