using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models.Entities;
using RestaurantProject.Services;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketsService;   

        public BasketController(IBasketService basketsService)
        {
            this._basketsService = basketsService;  
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var baskets = _basketsService.GetAll();
            return Ok(baskets);
        }
        [HttpPost]
        public IActionResult Add(Basket item)
        {
            _basketsService.Add(item);
            return Ok();
        }
        [HttpDelete("{productId}")]
        public IActionResult Remove(int productId)
        {
            _basketsService.Remove(productId);
            return Ok();
        }
        [HttpDelete("clear")]
        public IActionResult Clear()
        {
            _basketsService.Clear();
            return Ok();
        }

    }
}
