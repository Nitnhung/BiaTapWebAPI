using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/categories")]

    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("ategory-report")]
        public IActionResult GetCategoryReport()
        {
            var result = _categoryService.GetCategoryReport();
            return Ok(result);
        }

        [HttpGet("with-products")]
        public IActionResult GetListCategoryDetail()
        {
            var result = _categoryService.GetListCategoryDetail();
            return Ok(result);
        }
    }

}
