using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FURNITURE.Models
{
    public class CheckoutViewModel
    {
        // Properties for individual product details
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string Images { get; set; }

        // Property to hold a list of items in the checkout
        public List<CheckoutViewModel> Items { get; set; }
    }
}
