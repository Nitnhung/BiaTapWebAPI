using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Implementations;
using BiaTapWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BiaTapWebAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("details")]
        public IActionResult GetDetailOrder()
        {
            var result = _orderService.GetDetailOrder();
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
