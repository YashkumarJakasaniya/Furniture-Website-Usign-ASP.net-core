using System.ComponentModel.DataAnnotations;

namespace FURNITURE.Models
{
    public class FurnitureViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public string ImagePath { get; set; }



    }
}
