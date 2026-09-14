namespace BiaTapWebAPI.DTOs
{
    public class OrderReportDto
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
    }
}
