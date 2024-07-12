using System;
using System.ComponentModel.DataAnnotations;

namespace RaythosAerospace.Models
{
	public class Aircraft
	{
		public Aircraft()
		{
		
		}
        [Key]
        public int AircraftId { get; set; }

        public string ImageURL { get; set; }
        public string ModelName { get; set; }
        public string Specifications { get; set; }
        public double Pricing { get; set; }
    }
}

