using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class ManufacturingTrack
	{
		public ManufacturingTrack()
		{
		}

		[Key]
		public int TrackingId { get; set; }
		public string CurrentStatus { get; set; }
		public DateTime EstDelivDate { get; set; }
		public string Notifications { get; set; }

		//Relationships
		public int OrderId { get; set; }

		[ForeignKey("OrderId")]
		public Order Order { get; set; }
	}
}

