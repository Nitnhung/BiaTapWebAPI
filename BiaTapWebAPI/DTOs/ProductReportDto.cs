using BiaTapWebAPI.Models;

namespace BiaTapWebAPI.DTOs
{
    public class ProductReportDto
    {
        public string Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
