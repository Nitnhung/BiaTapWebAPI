namespace BiaTapWebAPI.DTOs
{
    public class CategoryRevenueDto
    {
        public int CategoryId { get; set; }
        public double TotalRevennue { get; set; }
        public List<OrderReportDto> OrderDetail { get; set; }

    
    }
}
