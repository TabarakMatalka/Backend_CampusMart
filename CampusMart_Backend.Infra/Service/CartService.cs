using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public void CreateCart(Cart cart)
        {
            this.cartRepository.CreateCart(cart);
        }

        public void DeleteCart(int cartId)
        {
            this.cartRepository.DeleteCart(cartId);
        }

        public List<Cart> GetAllCarts()
        {
            return this.cartRepository.GetAllCarts();
        }

        public Cart GetCartById(int cartId)
        {
            return this.cartRepository.GetCartById(cartId);
        }

        public void UpdateCart(Cart cart)
        {
            this.cartRepository.UpdateCart(cart);
        }
    }

}
