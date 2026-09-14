using BiaTapWebAPI.Data;
using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;
using BiaTapWebAPI.Services.Interfaces;
namespace BiaTapWebAPI.Services.Implementations
{
    public class ProductService:IProductService
    {
        public List<Product> GetAvailableProducts()
        {
            return SeedData.Products.Where(p => p.Stock > 0).ToList();
        }

        public List<Product> GetSortProducts()
        {
            return SeedData.Products
                .OrderByDescending(p=>p.Price)
                .ThenBy(p=>p.Name)
                .ToList();
        }

        public List<Product> GetProductsPaging(int pageNumber, int pageSize)
        {
            return SeedData.Products
                .Skip((pageNumber -1) *pageSize)
                .Take(pageSize)
                .ToList();
        }

        public Product GetProductById(int idProduct)
        {
            return SeedData.Products
                .FirstOrDefault(p => p.Id == idProduct);
        }

        public double GetTotalInventoryValue()
        {
            return SeedData.Products
                .Sum(p => p.Price * p.Stock);
        }

        public Product GetProductMax()
        {
            return SeedData.Products
                .OrderByDescending(p => p.Price)
                .FirstOrDefault();
        }

        public int GetSoLuongSanPhamDaBan()
        {
            return SeedData.Orders
                .Where(o => o.Status == "completed")
                .Join(
                SeedData.Products, 
                p => p.ProductId, 
                o => o.Id, 
                (o, p) => new { p, o } )
                .Sum(p => p.o.Quantity);
   

        }
        public List<Product> GetSanPhamChuaBan()
        {
            return SeedData.Products
                .Where(p => !SeedData.Orders
                    .Any(o => o.Status == "completed" && o.ProductId == p.Id))
                .ToList();

        }

        public List<ProductReportDto> GetProductReport()
        {
            return SeedData.Products
                .GroupBy(p => p.Stock > 0 ? "con" : "het")
                .Select(g => new ProductReportDto {
                    Status = g.Key
                    ,Products = g.ToList() })
                .ToList();

        }

        public List<TopProductDto> GetTopProductDto()
        {
            return SeedData.Orders
                .Where(o => o.Status == "completed")
                .Join(SeedData.Products, 
                o => o.ProductId, 
                p => p.Id, 
                (o, p) => new { o, p })
                .GroupBy(x=> new { x.p.Id, x.p.Name})
                .Select(
                g => new TopProductDto {
                    ProductId = g.Key.Id, 
                    ProductName = g.Key.Name, 
                    TotalQuantitySold = g.Sum(x=>x.o.Quantity) })
                .OrderByDescending(dto=>dto.TotalQuantitySold)
                .Take(3)
                .ToList();
        }
    }
}
