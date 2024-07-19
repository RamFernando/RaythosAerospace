using RaythosAerospace.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace RaythosAerospace.Models
{
	public class Aircraft: IEntityBase
    {
		public Aircraft()
		{
		
		}
        [Key]
        public int Id { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        [Display(Name = "Model Name")]
        [Required(ErrorMessage = "Model Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Model Name must be between 3 and 50 characters")]
        public string ModelName { get; set; }

        [Display(Name = "Specification")]
        [Required(ErrorMessage = "Specification is Required")]
        public string Specifications { get; set; }

        [Display(Name = "Base Price")]
        [Required(ErrorMessage = "Base Price is Required")]
        public double BasePrice { get; set; }

        [Display(Name = "Availability")]
        public bool Status { get; set; }

        //public Inventory Inventory { get; set; }
    }
}

