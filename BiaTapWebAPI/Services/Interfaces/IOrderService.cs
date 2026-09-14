using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderReportDto> GetDetailOrder();

        List<MonthlyRevenueDto> GetMonthlyRevenueDto();
    }
}
