using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
