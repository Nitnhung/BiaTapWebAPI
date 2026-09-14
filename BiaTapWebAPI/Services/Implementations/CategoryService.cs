using BiaTapWebAPI.Data;
using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;

namespace BiaTapWebAPI.Services.Implementations
{
    public class CategoryService:ICategoryService
    {
        public List<CategoryReportDto> GetCategoryReport()
        {
            return SeedData.Products
                .GroupBy(c => c.CategoryId)
                .Select(
                g => new CategoryReportDto()
                    {
                        CategoryId = g.Key
                        , TotalStock = g.Sum(p=>p.Stock)
                        , MaxPrice = g.Max(p=>p.Price)
                        , MinPrice = g.Min(p=>p.Price)
                    }
                ).ToList();
        }

        public List<CategoryListProduct> GetListCategoryDetail(Category category, Product product)
        {
            return SeedData.Categories
                .GroupJoin(
                SeedData.Products
                , c => c.Id
                , p => p.CategoryId
                , (c, p) => new CategoryListProduct{
                                CategoryId = c.Id
                                , NameCategory = c.Name
                                , Products = p.ToList() }
                ).ToList();
        }

        public List<CategoryRevenueDto> GetCategoryRevenueDto()
        {
            return SeedData.Orders
                .Where(o => o.Status == "completed")
                .Join(SeedData.Products
                , o => o.ProductId
                , p => p.Id
                , (o, p) => new OrderReportDto
                {
                    OrderId = o.Id
                ,
                    Price = p.Price
                ,
                    ProductName = p.Name
                ,
                    Quantity = o.Quantity
                ,
                    TotalAmount = p.Price * o.Quantity
                }
                )
                .Join(SeedData.Categories
                , c=>c.OrderId
                , o=>o.Id
                ,(o,c)=> new CategoryRevenueDto { CategoryId = c.Id, OrderDetail = } )
                //.Select(g=>new CategoryRevenueDto {CategoryId = g. })
                .ToList();
                

            //return SeedData.Orders
            //   .Where(o => o.Status == "completed")
            //   .Join(SeedData.Products
            //   , o => o.ProductId
            //   , p => p.Id
            //   , (o, p) => new OrderReportDto()
            //   {
            //       OrderId = o.ProductId
            //       ,
            //       ProductName = p.Name
            //       ,
            //       Quantity = o.Quantity
            //       ,
            //       Price = p.Price
            //       ,
            //       TotalAmount = p.Price * o.Quantity
            //   }).ToList();
        }
    }
}
