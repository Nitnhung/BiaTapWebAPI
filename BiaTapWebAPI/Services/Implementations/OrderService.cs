using BiaTapWebAPI.Data;
using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;

namespace BiaTapWebAPI.Services.Implementations
{
    public class OrderService:IOrderService
    {
        public List<OrderReportDto> GetDetailOrder()
        {
            return SeedData.Orders
                .Where(o => o.Status == "completed")
                .Join(SeedData.Products, 
                o => o.ProductId, 
                p => p.Id, 
                (o, p) => new OrderReportDto()
                {
                    OrderId = o.ProductId, 
                    ProductName = p.Name, 
                    Quantity = o.Quantity,
                    Price = p.Price, 
                    TotalAmount = p.Price * o.Quantity
                }).ToList();
        }

        
        public List<MonthlyRevenueDto> GetMonthlyRevenueDto()
        {
            return SeedData.Orders
                .Where(o => o.Status == "completed")
                .GroupBy(o=>o.OrderDate.Month)
                .Select(
                g=> new MonthlyRevenueDto { 
                Month = g.Key, 
                    OrderCount = g.Count(), 
                    TotalQuantitySold = g.Sum(p=>p.Quantity)}
                ).ToList();

        }
    }
}
