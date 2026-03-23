using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Services;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketsService _basketsService;   

        public BasketsController(IBasketsService basketsService)
        {
            this._basketsService = basketsService;  
        }
    }
}
