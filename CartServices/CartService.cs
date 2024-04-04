// CartService.cs
using System.Collections.Generic;
using System.Linq;

namespace FURNITURE.CartServices
{
    public class CartService : ICartService
    {
        private List<CartItem> _cartItems;

        public CartService()
        {
            _cartItems = new List<CartItem>();
        }

        public void AddToCart(int productId, string productName, decimal productPrice, int quantity)
        {
            var existingItem = _cartItems.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem { ProductId = productId, ProductName = productName, ProductPrice = productPrice, Quantity = quantity });
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }
    }
}
