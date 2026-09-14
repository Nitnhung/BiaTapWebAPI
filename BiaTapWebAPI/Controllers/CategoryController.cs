using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("Category Report")]
        public IActionResult GetCategoryReport()
        {
            var result = _categoryService.GetCategoryReport();
            return Ok(result);
        }

        [HttpGet("GetListCategoryDetail")]
        public IActionResult GetListCategoryDetail(Category category, Product product)
        {
            var result = _categoryService.GetListCategoryDetail(category, product);
            return Ok(result);
        }
    }

}
