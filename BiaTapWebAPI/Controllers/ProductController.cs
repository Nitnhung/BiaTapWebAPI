using BiaTapWebAPI.Data;
using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("available")]
        public IActionResult GetAvailable()
        {
            var result = _productService.GetAvailableProducts();
            return Ok(result);
        }

        [HttpGet("sort")]
        public IActionResult GetSortProduct()
        {
            var result = _productService.GetSortProducts();
            return Ok(result);
        }


        [HttpGet("page")]
        public IActionResult GetProductsPaging(int pageNumber, int pageSize)
        {
            var result = _productService.GetProductsPaging(pageNumber, pageSize);
            return Ok(result);
        }

        [HttpGet("Find")]
        public IActionResult GetProductById(int idProduct)
        {
            var result = _productService.GetProductById(idProduct);
            return Ok(result);
        }

        [HttpGet("InventoryValue")]
        public IActionResult GetTotalInventoryValue()
        {
            var result = _productService.GetTotalInventoryValue();
            return Ok(result);
        }

        [HttpGet("max")]
        public IActionResult GetProductMax()
        {
            var result = _productService.GetProductMax();
            return Ok(result);
        }

        [HttpGet("sum")]
        public IActionResult GetSoLuongSanPhamDaBan(Order order, Product product)
        {
            var result = _productService.GetSoLuongSanPhamDaBan(order, product);
            return Ok(result);
        }


        [HttpGet("ProductReport")]
        public IActionResult GetProductReport()
        {
            var result = _productService.GetProductReport();
            return Ok(result);
        }

        [HttpGet("GetTopProductDto")]
        public IActionResult GetTopProductDto()
        {
            var result = _productService.GetTopProductDto();
            return Ok(result);
        }





    }
}
