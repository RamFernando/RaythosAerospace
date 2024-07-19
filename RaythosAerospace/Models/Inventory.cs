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
        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

		[Display(Name ="Restock Date")]
        [Required(ErrorMessage = "Restock is Required")]
        public DateTime RestockDate { get; set; }

        //Relationships
        public int AircraftId { get; set; }

		[ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
    }
}

