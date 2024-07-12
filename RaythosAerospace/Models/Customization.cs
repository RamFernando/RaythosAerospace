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
        public string OptionName { get; set; }
        public string OptionDetails { get; set; }

        //Relationships
        public int AircraftId { get; set; }

        [ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
    }
}

