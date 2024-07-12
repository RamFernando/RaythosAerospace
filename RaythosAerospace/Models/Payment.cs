using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class Payment
	{
		public Payment()
		{
		}
		[Key]
		public int PaymentId { get; set; }
		public double Amount { get; set; }
		public string PaymentMethod { get; set; }
		public DateTime PaymentDate { get; set; }
		public string PaymentStatus { get; set; }

		//Relationships
		public int OrderId { get; set; }

		[ForeignKey("OrderId")]
		public Order Order { get; set; }
	}
}

