// AddCart.cs
using System.ComponentModel.DataAnnotations;

namespace FURNITURE.Models
{
    public class AddCart
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public string Images{ get; set; }
    }
}
