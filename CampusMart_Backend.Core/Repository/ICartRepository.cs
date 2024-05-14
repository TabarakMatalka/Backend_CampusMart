using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ICartRepository
    {
       List<Cart> GetAllCarts();
        Cart GetCartById(int cartId);
        void CreateCart(Cart cart);
        void UpdateCart(Cart cart);
        void DeleteCart(int cartId);
         List<ConsumerCart> GetCartMerchandiseByConsumerID(int consumerId);
    }
}
