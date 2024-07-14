using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class Customization
	{
		public Customization()
		{

		}
        [Key]
        public int CustomizationId { get; set; }
        public string OptionCategory { get; set; }
        public string FloorPlan { get; set; }
        public string Interior { get; set; }
        public string Ext_StripeColor { get; set; }
        public double Price { get; set; }

        //Relationships
        public int AircraftId { get; set; }

        [ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
    }
}

