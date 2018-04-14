using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Northwind.Bussiness.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
    }
}
