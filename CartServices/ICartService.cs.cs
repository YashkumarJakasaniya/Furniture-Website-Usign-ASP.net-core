// ICartService.cs
using System.Collections.Generic;

namespace FURNITURE.CartServices
{
    public interface ICartService
    {
        void AddToCart(int productId, string productName, decimal productPrice, int quantity);
        List<CartItem> GetCartItems();
        // Add more methods as needed
    }

    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
