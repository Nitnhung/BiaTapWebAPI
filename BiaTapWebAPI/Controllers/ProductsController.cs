using BiaTapWebAPI.Data;
using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("available")]
        public IActionResult GetAvailable()
        {
            var result = _productService.GetAvailableProducts();
            return Ok(result);
        }

        [HttpGet("sorted")]
        public IActionResult GetSortProduct()
        {
            var result = _productService.GetSortProducts();
            return Ok(result);
        }


        [HttpGet("pageNumber={pageNumber}&pageSize={pageSize}")]
        public IActionResult GetProductsPaging(int pageNumber, int pageSize)
        {
            var result = _productService.GetProductsPaging(pageNumber, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int idProduct)
        {
            var result = _productService.GetProductById(idProduct);
            return Ok(result);
        }

        [HttpGet("total-inventory-value")]
        public IActionResult GetTotalInventoryValue()
        {
            var result = _productService.GetTotalInventoryValue();
            return Ok(result);
        }

        [HttpGet("most-expensive-available")]
        public IActionResult GetProductMax()
        {
            var result = _productService.GetProductMax();
            return Ok(result);
        }

        [HttpGet("total-completed-quantity")]
        public IActionResult GetSoLuongSanPhamDaBan()
        {
            var result = _productService.GetSoLuongSanPhamDaBan();
            return Ok(result);
        }


        [HttpGet("stock-status")]
        public IActionResult GetProductReport()
        {
            var result = _productService.GetProductReport();
            return Ok(result);
        }

        [HttpGet("top-3-best-sellers")]
        public IActionResult GetTopProductDto()
        {
            var result = _productService.GetTopProductDto();
            return Ok(result);
        }

        [HttpGet("unsold")]
        public IActionResult GetSanPhamChuaBan()
        {
            var result = _productService.GetSanPhamChuaBan();
            return Ok(result);
        }




    }
}
