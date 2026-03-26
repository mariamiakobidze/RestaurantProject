using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models.Entities;
using RestaurantProject.Services;
using System.Threading.Tasks;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            List<Product> products = await productService.GetAllAsync();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid product id.");

            var product = productService.GetById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            productService.Add(product);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Product product)
        {
            productService.Add(product);
            return Ok();
        }
    }
}
