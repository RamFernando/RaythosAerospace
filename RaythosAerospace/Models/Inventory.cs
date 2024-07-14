using RaythosAerospace.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaythosAerospace.Models
{
	public class Inventory: IEntityBase
	{
		public Inventory()
		{
		}
		[Key]
		public int Id { get; set; }

		[Display(Name ="Quantity")]
		public int Quantity { get; set; }

		[Display(Name ="Restock Date")]
		public DateTime RestockDate { get; set; }

        //Relationships
        public int AircraftId { get; set; }

		[ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
    }
}

