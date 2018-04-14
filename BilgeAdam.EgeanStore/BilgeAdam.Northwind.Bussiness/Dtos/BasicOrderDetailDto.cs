namespace BilgeAdam.Northwind.Bussiness.Dtos
{
    public class BasicOrderDetailDto
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
    }
}
