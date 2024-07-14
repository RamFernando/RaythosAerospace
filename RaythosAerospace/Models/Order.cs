using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class Order
	{
		public Order()
		{
        }
        [Key]
        public int Id { get; set; }

        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        //Relationships
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int AircraftId { get; set; }
        [ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }

        public int CustomizationId { get; set; }
        [ForeignKey("CustomizationId")]
        public Customization Customization { get; set; }
    }
}


