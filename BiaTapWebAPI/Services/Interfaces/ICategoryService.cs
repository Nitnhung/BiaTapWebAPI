using BiaTapWebAPI.DTOs;
using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryReportDto> GetCategoryReport();

        List<CategoryListProduct> GetListCategoryDetail();
        //List<CategoryRevenueDto> GetCategoryRevenueDto();
    }
}
