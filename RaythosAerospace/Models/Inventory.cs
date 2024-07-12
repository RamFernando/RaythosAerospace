using System;
using System.ComponentModel.DataAnnotations;

namespace RaythosAerospace.Models
{
	public class Inventory
	{
		public Inventory()
		{
		}
		[Key]
		public int InventoryId { get; set; }
		public string ComponentName { get; set; }
		public int Quantity { get; set; }
		public DateTime RestockDate { get; set; }
	}
}

