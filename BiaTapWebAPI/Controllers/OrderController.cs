using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Implementations;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("OrderDetail")]
        public IActionResult GetDetailOrder()
        {
            var result = _orderService.GetDetailOrder();
            return Ok(result);
        }

        [HttpGet("GetSanPhamChuaBan")]
        public IActionResult GetSanPhamChuaBan()
        {
            var result = _orderService.GetSanPhamChuaBan();
            return Ok(result);
        }

        [HttpGet("GetMonthlyRevenueDto")]
        public IActionResult GetMonthlyRevenueDto()
        {
            var result = _orderService.GetMonthlyRevenueDto();
            return Ok(result);
        }


    }
}
