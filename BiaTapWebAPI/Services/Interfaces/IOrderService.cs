using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderReportDto> GetDetailOrder();
        List<Product> GetSanPhamChuaBan();
        List<MonthlyRevenueDto> GetMonthlyRevenueDto();
    }
}
