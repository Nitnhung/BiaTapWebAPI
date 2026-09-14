using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAvailableProducts();

        List<Product> GetSortProducts();
        List<Product> GetProductsPaging(int pageNumber, int pageSize);

        Product GetProductById(int idProduct);
        double GetTotalInventoryValue();
        Product GetProductMax();

        int GetSoLuongSanPhamDaBan();
        List<ProductReportDto> GetProductReport();
        List<Product> GetSanPhamChuaBan();
        List<TopProductDto> GetTopProductDto();
    }
}
