using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models.Entities;
using RestaurantProject.Services;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoriesService;

        public CategoryController(ICategoryService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = categoriesService.GetAll();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = categoriesService.GetById(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            categoriesService.Add(category);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Category category)
        {
            categoriesService.Update(id, category);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            categoriesService.Delete(id);
            return Ok();

        }
       


    }
}
