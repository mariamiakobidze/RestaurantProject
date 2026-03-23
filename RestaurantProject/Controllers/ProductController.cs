using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Services;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = productService.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var product = productService.GetById(id);
            if (product == null)
                return NotFound();
            return Ok(product);

        } }
