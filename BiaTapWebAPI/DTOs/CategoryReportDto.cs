using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.DTOs
{
    public class CategoryReportDto
    {
        public int CategoryId { get; set; }
        public int TotalStock { get; set; }
        public double MaxPrice { get; set; }
        public double MinPrice { get; set; }
    }
    public class CategoryListProduct
    {
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
