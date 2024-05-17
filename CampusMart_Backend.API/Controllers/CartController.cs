using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using CampusMart_Backend.Core.Service;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
    private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        [Route("GetAllCarts")]
        public List<Cart> GetAllCarts()
        {
            return cartService.GetAllCarts();
        }

        [HttpGet]
        [Route("GetCartById/{id}")]
        public Cart GetCartById(int id)
        {
            return cartService.GetCartById(id);
        }

        [HttpPost]
        [Route("CreateCart")]
        public void CreateCart(Cart cart)
        {
            cartService.CreateCart(cart);
        }

        [HttpPut]
        [Route("UpdateCart")]
        public void UpdateCart(Cart cart)
        {
            cartService.UpdateCart(cart);
        }

        [HttpDelete]
        [Route("DeleteCart/{id}")]
        public void DeleteCart(int id)
        {
            cartService.DeleteCart(id);
        }

        [HttpGet]
        [Route("GetCartMerchandiseByConsumerID")]
        public List<ConsumerCart> GetCartMerchandiseByConsumerID(int consumerId)
        {
            return this.cartService.GetCartMerchandiseByConsumerID(consumerId);
        }

        [HttpGet]
        [Route("GetMerchandiseInCartByStoreID")]
        public List<ConsumerCart> GetMerchandiseInCartByStoreID(int storeid, int consumerId)
        {
            return this.cartService.GetMerchandiseInCartByStoreID(storeid, consumerId);
        }
    }
}
